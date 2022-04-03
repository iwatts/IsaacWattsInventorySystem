using IsaacWattsInventorySystem.models;
using System.ComponentModel;
using System.Globalization;

namespace IsaacWattsInventorySystem.forms
{
    public partial class ProductForm : Form
    {
        private BindingList<Part> productParts;
        private int dataGridRowIndex { get; set; }
        public List<Part> backupPartList { get; private set; }

        public ProductForm(int productID, Product productData, int rowIndex = -1)
        {
            InitializeComponent();

            productIDInput.Text = productID.ToString();
            int dataGridRowIndex = rowIndex;
            List<Part> backupPartList = null;

            if (productData is Product)
            {
                //fill in form
                productNameInput.Text = productData.Name;
                productPriceInput.Text = productData.Price.ToString();
                ProductStockInput.Text = productData.InStock.ToString();
                productMinInput.Text = productData.Min.ToString();
                productMaxInput.Text = productData.Max.ToString();

                productParts = new BindingList<Part>(productData.AssociatedParts);
                productPartsGrid.DataSource = productParts;

                backupPartList = new List<Part>(productParts);

            }

            BindingSource allPartItems = new BindingSource();
            allPartItems.DataSource = productPartsGrid.DataSource;


            allPartsGrid.DataSource = allPartItems;
            allPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allPartsGrid.ReadOnly = true;
            allPartsGrid.MultiSelect = false;
            allPartsGrid.AllowUserToAddRows = false;

        }

        private void addPartToProduct(object sender, DataGridViewCellEventArgs e)
        {
            if (allPartsGrid.CurrentRow.Selected)
            {
                Part partData = (Part)allPartsGrid.CurrentRow.DataBoundItem;
                productParts.Add(partData);
            }
        }

        private void removePartFromProdcut(object sender, DataGridViewCellEventArgs e)
        {
            if (productPartsGrid.CurrentRow.Selected)
            {
                DataGridViewRow removeRow = productPartsGrid.CurrentRow;
                productPartsGrid.Rows.Remove(removeRow);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            if (dataGridRowIndex > 0)
            {
                dataGridProducts.Rows[dataGridRowIndex].SetValues(new Product
                {
                    ProductID = int.Parse(this.productIDInput.Text),
                    Name = this.productNameInput.Text,
                    Price = float.Parse(this.productPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                    InStock = int.Parse(this.ProductStockInput.Text),
                    Min = int.Parse(this.productMinInput.Text),
                    Max = int.Parse(this.productMaxInput.Text),
                    AssociatedParts = productParts
                });

            }
            else
            {
                int newID = Globals.maxGlobalProductID;
                dataGridProducts.Rows.Add(new Product
                {
                    ProductID = newID,
                    Name = this.productNameInput.Text,
                    Price = float.Parse(this.productPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                    InStock = int.Parse(this.ProductStockInput.Text),
                    Min = int.Parse(this.productMinInput.Text),
                    Max = int.Parse(this.productMaxInput.Text),
                    AssociatedParts = productParts
                });
                Globals.maxGlobalProductID++;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (backupPartList is List<Part>)
            {
                productParts = new BindingList<Part>(backupPartList);
            }
            this.Close();
        }


    }
}
