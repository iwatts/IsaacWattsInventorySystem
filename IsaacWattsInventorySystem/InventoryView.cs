using IsaacWattsInventorySystem.forms;
using IsaacWattsInventorySystem.models;

namespace IsaacWattsInventorySystem
{
    public partial class InventoryView : Form
    {
            public InventoryView()
            {
                InitializeComponent();

                dataGridProducts.DataSource = Product.products;
                dataGridProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridProducts.ReadOnly = true;
                dataGridProducts.MultiSelect = false;
                dataGridProducts.AllowUserToAddRows = false;

                dataGridParts.DataSource = Part.parts;
                dataGridParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridParts.ReadOnly = true;
                dataGridParts.MultiSelect = false;
                dataGridParts.AllowUserToAddRows = false;

            }

            private void ProductsBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
            {
                dataGridProducts.ClearSelection();
            }

            private void PartsBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
            {
                dataGridParts.ClearSelection();
            }

            /***********  PRODUCTS FUNCTIONS ************/

            private void ProductEditCell(object sender, DataGridViewCellEventArgs e)
            {
                // Double click to edit selected product
                // this.modifyProductButton_Click(sender, e);
            }

            private void modifyProductButton_Click(object sender, EventArgs e)
            {
                // load "modify" product form (create form with inputs loaded from selected product)
                if (dataGridProducts.RowCount > 0 && dataGridProducts.CurrentRow.Selected)
                {
                    int productID = (int)dataGridProducts.CurrentRow.Cells["ProductID"].Value;
                    Product productData = (Product)dataGridProducts.CurrentRow.DataBoundItem;
                    ProductForm modifyProduct = new ProductForm(productID, productData);
                    modifyProduct.Owner = this;
                    modifyProduct.Show();
                }
                else
                {
                    MessageBox.Show("Product Not Selected");
                }
            }
            private void addProductButton_Click(object sender, EventArgs e)
            {
                // load create product form
                int productID = Globals.maxGlobalProductID;
                Product productData = null;
                ProductForm newProduct = new ProductForm(productID, productData);
                newProduct.Owner = this;
                // this.Hide();
                newProduct.Show();


            }
            private void deleteProductButton_Click(object sender, EventArgs e)
            {
                // Load confirmation prompt
                // call delete on true
                if (dataGridProducts.CurrentRow.Selected)
                {
                    string promptMessage = "Are you sure you wish to delete Product: " + (string)dataGridProducts.CurrentRow.Cells["Name"].Value;
                    if (Globals.confirmationPrompt(promptMessage))
                    {
                        int index = dataGridProducts.CurrentRow.Index;
                        Product.products.RemoveAt(index);
                    }
                }
                else
                {
                    MessageBox.Show("Product Not Selected");
                }

            }
            /***********  PARTS FUNCTIONS ************/

            private void PartEditCell(object sender, DataGridViewCellEventArgs e)
            {
                // Double click to edit selected part
                this.modifyPartButton_Click(sender, e);
            }
            private void modifyPartButton_Click(object sender, EventArgs e)
            {
                // load "modify" part form (create form with inputs loaded from selected part)
                if (dataGridParts.RowCount > 0 && dataGridParts.CurrentRow.Selected)
                {
                    int partID = (int)dataGridParts.CurrentRow.Cells["PartID"].Value;
                    Part partData = (Part)dataGridParts.CurrentRow.DataBoundItem;
                    PartForm modifyPart = new PartForm(partID, partData);
                    modifyPart.Owner = this;
                    modifyPart.Show();
                }
                else
                {
                    MessageBox.Show("Part Not Selected");
                }

            }

            private void addPartButton_Click(object sender, EventArgs e)
            {
                // load create part form
                int partID = Globals.maxGlobalPartID;
                Part partData = null;
                PartForm newPart = new PartForm(partID, partData);
                newPart.Owner = this;
                newPart.Show();
            }

            private void deletePartButton_Click(object sender, EventArgs e)
            {
                // Load confirmation prompt
                // call delete on true
                if (dataGridParts.CurrentRow.Selected)
                {
                    string promptMessage = "Are you sure you wish to delete Part: " + (string)dataGridParts.CurrentRow.Cells["Name"].Value;
                    if (Globals.confirmationPrompt(promptMessage))
                    {
                        int index = dataGridParts.CurrentRow.Index;
                        Part.parts.RemoveAt(index);
                    }
                }
                else
                {
                    MessageBox.Show("Part Not Selected");
                }

            }

            private void exitButton_Click(object sender, EventArgs e)
            {
                //close program
                System.Windows.Forms.Application.Exit();
            }
        }
}