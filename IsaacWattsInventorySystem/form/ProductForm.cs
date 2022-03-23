using IsaacWattsInventorySystem.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsaacWattsInventorySystem.forms
{
    public partial class ProductForm : Form
    {
        private BindingList<Part> productParts;

        public ProductForm(int productID, Product productData, int rowIndex = -1)
        {
            InitializeComponent();

            productIDInput.Text = productID.ToString();
            dataGridRowIndex = rowIndex;

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

            }

            BindingSource allPartItems = new BindingSource();
            allPartItems.DataSource = productPartsGrid.DataSource;
            

            allPartsGrid.DataSource = allPartItems;
            allPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allPartsGrid.ReadOnly = true;
            allPartsGrid.MultiSelect = false;
            allPartsGrid.AllowUserToAddRows = false;

            productIDInput.Text = productID.ToString();
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

        private Part submitPart(object sender, EventArgs e)
        {

            if(dataGridRowIndex > 0)
            {
                dataGridProducts.Rows[dataGridRowIndex].SetValues(new Product{
                    ProductID = this.productIDInput.Text,
                    Name = this.productNameInput.Text,
                    Price = float.Parse(this.productPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                    InStock = int.Parse(this.ProductStockInput.Text),
                    Min = int.Parse(this.productMinInput.Text),
                    Max = int.Parse(this.productMaxInput.Text),
                    AssociatedParts = productParts
                });
                 
            } else
            {
                newID = Globals.maxGlobalProductID;
                dataGridProducts.Rows.Add(new Product{
                    ProductID = this.newID.toString(),
                    Name = this.productNameInput.Text,
                    Price = float.Parse(this.productPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                    InStock = int.Parse(this.ProductStockInput),
                    Min = int.Parse(this.productMinInput.Text),
                    Max = int.Parse(this.productMaxInput.Text),
                    AssociatedParts = productParts
                });
                Globals.maxGlobalProductID ++;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
