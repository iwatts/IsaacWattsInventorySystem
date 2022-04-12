using IsaacWattsInventorySystem.models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace IsaacWattsInventorySystem.forms
{
    public partial class ProductForm : Form
    {
        private static BindingList<Part>? productPartsNew;
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

        private void addPartToProduct_click(object sender, DataGridViewCellEventArgs e)
        {
            if (allPartsGrid.CurrentRow.Selected)
            {
                Part partData = (Part)allPartsGrid.CurrentRow.DataBoundItem;
                addPart(partData);
            }
        }

        private void removePartFromProdcut_click(object sender, DataGridViewCellEventArgs e)
        {
            if (productPartsGrid.CurrentRow.Selected)
            {
                int removeIndex = productPartsGrid.CurrentRow.Index;
                removePart(removeIndex);
            }
        }

        private void filterAllParts_Click(object sender, EventArgs e)
        {
            string searchProductValue = this.searchAllParts.Text;
            BindingList<Product> filteredProductsBindingList = new BindingList<Product>(Product.products
                .Where(productData => productData.Name.partialStringMatch(searchProductValue, StringComparison.OrdinalIgnoreCase)).ToList());
            if (filteredProductsBindingList.Count > 0)
            {
                allPartsGrid.DataSource = filteredProductsBindingList;
            }
            else
            {
                allPartsGrid.DataSource = Part.parts;
                MessageBox.Show("Part Not Found");
            }
        }

        private void filterProductParts_Click(object sender, EventArgs e)
        {
            string searchProductValue = this.searchAllParts.Text;
            BindingList<Product> filteredProductsBindingList = new BindingList<Product>(Product.products
                .Where(productData => productData.Name.partialStringMatch(searchProductValue, StringComparison.OrdinalIgnoreCase)).ToList());
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
            if(productPartsNew.Count < 0)
            {
                MessageBox.Show("Product Requires Parts");
                return;
            }

            

            if (productIndex > 0)
            {
                // dataGridProducts.Rows[dataGridRowIndex].SetValues(new Product
                var updatedProduct = new Product {
                    ProductID = int.Parse(this.productIDInput.Text),
                    Name = this.productNameInput.Text,
                    Price = decimal.Parse(this.productPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                    InStock = int.Parse(this.ProductStockInput.Text),
                    Min = int.Parse(this.productMinInput.Text),
                    Max = int.Parse(this.productMaxInput.Text),
                    AssociatedParts = productPartsNew
                };
                if (Globals.validateObject(updatedProduct)){
                    Inventory.updateProduct(productIndex, updatedProduct);
                }

            }
            else
            {
                int newID = Globals.maxGlobalProductID;
                // dataGridProducts.Rows.Add(new Product
                var newProduct = new Product {
                    ProductID = newID,
                    Name = this.productNameInput.Text,
                    Price = decimal.Parse(this.productPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                    InStock = int.Parse(this.ProductStockInput.Text),
                    Min = int.Parse(this.productMinInput.Text),
                    Max = int.Parse(this.productMaxInput.Text),
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
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
