using IsaacWattsInventorySystem.models;
using System.ComponentModel;
using System.Globalization;

namespace IsaacWattsInventorySystem.forms
{
    public partial class ProductForm : Form
    {
        private static BindingList<Part>? productPartsNew = new BindingList<Part>();
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

            BindingSource allPartItems = new BindingSource();
            allPartItems.DataSource = Part.parts;



            allPartsGrid.DataSource = allPartItems;
            allPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allPartsGrid.ReadOnly = true;
            allPartsGrid.MultiSelect = false;
            allPartsGrid.AllowUserToAddRows = false;

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
            if (productPartsNew is null || (productPartsNew.Count <= 0))
            {
                productPartsGrid.Focus();
                errorProvider_Product.SetError(productPartsGrid, "Product requires minimum of 1 part!");
                return;
            }

            if (productIndex >= 0)
            {
                var updatedProduct = new Product {
                    ProductID = int.Parse(productIDInput.Text),
                    Name = productNameInput.Text,
                    Price = decimal.Parse(productPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
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
                var newProduct = new Product {
                    ProductID = newID,
                    Name = productNameInput.Text,
                    Price = decimal.Parse(productPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
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
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            if (allPartsGrid.CurrentRow.Selected)
            {
                Part partData = (Part)allPartsGrid.CurrentRow.DataBoundItem;
                addPart(partData);
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
                int removeIndex = productPartsGrid.CurrentRow.Index;
                removePart(removeIndex);
            }
            else
            {
                MessageBox.Show("Part Not Selected", "Error");
            }
        }
    }
}
