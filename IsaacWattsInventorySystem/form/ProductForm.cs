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

        private ProductForm(int productID, Product productData)
        {
            InitializeComponent();

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
            productIDInput.Text = productID.ToString();

            BindingSource includedItemsFiltered = new BindingSource();
            includedItemsFiltered.DataSource = Part.parts;

            allPartsGrid.DataSource = includedItemsFiltered;
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
            Part data = null;
            return data;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
