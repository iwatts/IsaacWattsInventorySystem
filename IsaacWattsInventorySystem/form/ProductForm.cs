using IsaacWattsInventorySystem.models;
using System.ComponentModel;
using System.Globalization;

namespace IsaacWattsInventorySystem.forms
{
    public partial class ProductForm : Form
    {
        private static BindingList<Part>? productPartsNew = new BindingList<Part>();
        private static BindingSource allPartItems = new BindingSource();
        private int productIndex { get; set; }

        public ProductForm(int productID, Product productData, int rowIndex = -1)
        {
            InitializeComponent();

            productIDInput.Text = productID.ToString();
            productIndex = rowIndex;


            if (productData is Product)
            {
                //fill in form
                productNameInput.Text = productData.Name;
                productPriceInput.Text = productData.Price.ToString();
                ProductStockInput.Text = productData.InStock.ToString();
                productMinInput.Text = productData.Min.ToString();
                productMaxInput.Text = productData.Max.ToString();

                productPartsNew = new BindingList<Part>(productData.AssociatedParts.ToList());
                productPartsGrid.DataSource = productPartsNew;
            } else
            {
                productPartsNew = new BindingList<Part>();
            }

            allPartItems.DataSource = Part.parts;



            allPartsGrid.DataSource = allPartItems;
            allPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allPartsGrid.ReadOnly = true;
            allPartsGrid.MultiSelect = false;
            allPartsGrid.AllowUserToAddRows = false;

            productPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productPartsGrid.ReadOnly = true;
            productPartsGrid.MultiSelect = false;
            productPartsGrid.AllowUserToAddRows = false;

        }

        public static void addPart(Part partData)
        {
            productPartsNew.Add(partData);
            productPartsNew.ResetBindings();
        }
        public static bool removePart(int partIndex)
        {
            if (lookupPart(partIndex) is Part)
            {
                productPartsNew.RemoveAt(partIndex);
                productPartsNew.ResetBindings();
                return true;
            }
            return false;
        }

        public static Part lookupPart(int partIndex)
        {
            return Part.parts[partIndex];
        }

        private void filterAllParts_Click(object sender, EventArgs e)
        {
            string searchAllPartsValue = searchAllPartsInput.Text;
            BindingList<Part> filteredAllParts = new BindingList<Part>(Part.parts
                .Where(partData => partData.Name.partialStringMatch(searchAllPartsValue, StringComparison.OrdinalIgnoreCase)).ToList());
            if (filteredAllParts.Count > 0)
            {
                allPartsGrid.DataSource = filteredAllParts;
            }
            else
            {
                allPartsGrid.DataSource = Part.parts;
                MessageBox.Show("Part Not Found");
            }
        }

        private void filterProductParts_Click(object sender, EventArgs e)
        {
            string searchAssociatedPartsValue = searchProductPartsInput.Text;
            BindingList<Part> filteredProductsBindingList = new BindingList<Part>(productPartsNew
                .Where(partData => partData.Name.partialStringMatch(searchAssociatedPartsValue, StringComparison.OrdinalIgnoreCase)).ToList());
            if (filteredProductsBindingList.Count > 0)
            {
                productPartsGrid.DataSource = filteredProductsBindingList;
            }
            else
            {
                productPartsGrid.DataSource = productPartsNew;
                MessageBox.Show("Part Not Found");
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Focus();
                if (!Validate())
                {
                    DialogResult = DialogResult.None;
                    return;
                }
            }

            if (productIndex >= 0)
            {
                var productPrice = string.Format("{0:#.00}", Convert.ToDecimal(productPriceInput.Text));
                var updatedProduct = new Product {
                    ProductID = int.Parse(productIDInput.Text),
                    Name = productNameInput.Text,
                    Price = decimal.Parse(productPrice, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                    InStock = int.Parse(ProductStockInput.Text),
                    Min = int.Parse(productMinInput.Text),
                    Max = int.Parse(productMaxInput.Text),
                    AssociatedParts = productPartsNew
                };
                if (Globals.validateObject(updatedProduct)){
                    // TODO: verify updatedProduct is correct
                    Inventory.updateProduct(productIndex, updatedProduct);
                }

            }
            else
            {
                int newID = Globals.maxGlobalProductID;
                var productPrice = string.Format("{0:#.00}", Convert.ToDecimal(productPriceInput.Text));

                var newProduct = new Product {
                    ProductID = newID,
                    Name = productNameInput.Text,
                    Price = decimal.Parse(productPrice, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                    InStock = int.Parse(ProductStockInput.Text),
                    Min = int.Parse(productMinInput.Text),
                    Max = int.Parse(productMaxInput.Text),
                    AssociatedParts = productPartsNew
                };
                if (Globals.validateObject(newProduct))
                {
                    Inventory.addProduct(newProduct);
                    Globals.maxGlobalProductID++;
                } else
                {

                }
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            errorProvider_Product.Clear();
            while (Controls.Count > 0)
            {
                Controls[0].Dispose();
            }
            Close();
        }

        private void productName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productNameInput.Text))
            {
                e.Cancel = true;
                productNameInput.Focus();
                errorProvider_Product.SetError(productNameInput, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_Product.SetError(productNameInput, "");
            }
        }

        private void priceInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productPriceInput.Text))
            {
                e.Cancel = true;
                productPriceInput.Focus();
                errorProvider_Product.SetError(productPriceInput, "Price should not be left blank!");
            }
            else if (!decimal.TryParse(productPriceInput.Text, out decimal numberValue))
            {
                e.Cancel = true;
                productPriceInput.Focus();
                errorProvider_Product.SetError(productPriceInput, "Price value should be number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_Product.SetError(productPriceInput, "");
            }
        }

        private void stockInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductStockInput.Text))
            {
                e.Cancel = true;
                ProductStockInput.Focus();
                errorProvider_Product.SetError(ProductStockInput, "Stock should not be left blank!");
            }
            else if (!int.TryParse(ProductStockInput.Text, out int numberValue))
            {
                e.Cancel = true;
                ProductStockInput.Focus();
                errorProvider_Product.SetError(ProductStockInput, "Stock value should be number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_Product.SetError(ProductStockInput, "");
            }
            if (!string.IsNullOrWhiteSpace(productMinInput.Text))
            {
                if (int.Parse(ProductStockInput.Text) < int.Parse(productMinInput.Text))
                {
                    e.Cancel = true;
                    ProductStockInput.Focus();
                    errorProvider_Product.SetError(ProductStockInput, "Stock value should be greater than Minimum Amount!");
                }

            }
            if (!string.IsNullOrWhiteSpace(productMaxInput.Text))
            {
                if (int.Parse(ProductStockInput.Text) > int.Parse(productMaxInput.Text))
                {
                    e.Cancel = true;
                    ProductStockInput.Focus();
                    errorProvider_Product.SetError(ProductStockInput, "Stock value should be smaller than Maximum Amount!");
                }
            }
        }

        private void minInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productMinInput.Text))
            {
                e.Cancel = true;
                productMinInput.Focus();
                errorProvider_Product.SetError(productMinInput, "Minimum Amount should not be left blank!");
            }
            else if (!int.TryParse(productMinInput.Text, out int numberValue))
            {
                e.Cancel = true;
                productMinInput.Focus();
                errorProvider_Product.SetError(productMinInput, "Minimum Amount value should be number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_Product.SetError(productMinInput, "");
            }
            if (!string.IsNullOrWhiteSpace(productMaxInput.Text))
            {
                if (int.Parse(productMinInput.Text) > int.Parse(productMaxInput.Text))
                {
                    e.Cancel = true;
                    productMinInput.Focus();
                    errorProvider_Product.SetError(productMinInput, "Minimum Amount value should be smaller than Maximum Amount!");
                }
            }
        }

        private void maxInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productMaxInput.Text))
            {
                e.Cancel = true;
                productMaxInput.Focus();
                errorProvider_Product.SetError(productMaxInput, "Maximum Amount should not be left blank!");
            }
            else if (!int.TryParse(productMaxInput.Text, out int numberValue))
            {
                e.Cancel = true;
                productMaxInput.Focus();
                errorProvider_Product.SetError(productMaxInput, "Maximum Amount value should be number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_Product.SetError(productMaxInput, "");
            }
            if (!string.IsNullOrWhiteSpace(productMaxInput.Text))
            {
                if (int.Parse(productMinInput.Text) > int.Parse(productMaxInput.Text))
                {
                    e.Cancel = true;
                    productMaxInput.Focus();
                    errorProvider_Product.SetError(productMaxInput, "Maximum Amount value should be greater than Minimum Amount!");
                }
            }
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            if (allPartsGrid.CurrentRow.Selected)
            {
                int selectedPartIndex = allPartsGrid.CurrentRow.Index;
                Part partData = (Part)allPartItems[selectedPartIndex];
                addPart(partData);
                productPartsGrid.DataSource = productPartsNew;
            }
            else
            {
                MessageBox.Show("Part Not Selected", "Error");
            }
        }

        private void removePartButton_Click(object sender, EventArgs e)
        {
            if (productPartsGrid.CurrentRow.Selected)
            {
                string promptMessage = "Are you sure you wish to remove part: " + (string)productPartsGrid.CurrentRow.Cells["Name"].Value;
                if (Globals.confirmationPrompt(promptMessage))
                {
                    int removePartIndex = productPartsGrid.CurrentRow.Index;
                    bool partRemoved = removePart(removePartIndex);
                    if (partRemoved)
                    {
                        MessageBox.Show("Part Removed", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Part Not Removed", "Error");
                    }
                    productPartsGrid.DataSource = productPartsNew;
                }
            }
            else
            {
                MessageBox.Show("Part Not Selected", "Error");
            }
        }

        private void allPartsGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            allPartsGrid.ClearSelection();
        }

        private void productPartsGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productPartsGrid.ClearSelection();
        }
    }
}
