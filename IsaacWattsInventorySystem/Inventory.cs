using IsaacWattsInventorySystem.forms;
using IsaacWattsInventorySystem.models;
using System.ComponentModel;

namespace IsaacWattsInventorySystem
{
    public partial class Inventory : Form
    {
        public Inventory()
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

        /***********  DATA FUNCTIONS ************/

        public static void addProduct(Product productData) {
            Product.products.Add(productData);
            Product.products.ResetBindings();
        }
        public static bool removeProduct(int productIndex) {
            if (lookupProduct(productIndex) is Product)
            {
                Product.products.RemoveAt(productIndex);
                Product.products.ResetBindings();
                return true;
            }
            return false;
        }
        public static Product lookupProduct(int productIndex) {
            return Product.products[productIndex];
        }
        public static void updateProduct(int productIndex, Product productData) {
            Product.products[productIndex] = productData;
            Product.products.ResetBindings();
        }

        public static void addPart(Part partData) {
            Part.parts.Add(partData);
            Part.parts.ResetBindings();
        }
        public static bool removePart(int partIndex) {
            if(lookupPart(partIndex) is Part)
            {
                Part.parts.RemoveAt(partIndex);
                Part.parts.ResetBindings();
                return true;
            }
            return false;
        }
        public static Part lookupPart(int partIndex) {
            return Part.parts[partIndex];
        }
        public static void updatePart(int partIndex, Part partData) {
            Part.parts[partIndex] = partData;
            Part.parts.ResetBindings();

        }

        /***********  PRODUCTS GUI FUNCTIONS ************/

        private void ProductEditCell(object sender, DataGridViewCellEventArgs e)
        {
            // Double click to edit selected product
            this.modifyProductButton_Click(sender, e);
        }

        private void findProductButton_Click(object sender, EventArgs e)
        {
            string searchProductValue = this.textSearchProduct.Text;
            BindingList<Product> filteredProductsBindingList = new BindingList<Product>(Product.products
                .Where(productData => productData.Name.partialStringMatch(searchProductValue, StringComparison.OrdinalIgnoreCase)).ToList());
            if (filteredProductsBindingList.Count > 0)
            {
                dataGridProducts.DataSource = filteredProductsBindingList;
            }
            else
            {
                dataGridProducts.DataSource = Part.parts;
                MessageBox.Show("Part Not Found");
            }
        }

        private void modifyProductButton_Click(object sender, EventArgs e)
        {
            // load product form (add product data to modify and include index)
            if (dataGridProducts.RowCount > 0 && dataGridProducts.CurrentRow.Selected)
            {
                int productIndex = dataGridProducts.CurrentRow.Index;
                Product productData = (Product)dataGridProducts.CurrentRow.DataBoundItem;
                ProductForm modifyProduct = new ProductForm(productIndex, productData, productIndex);
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
                    bool productRemoved = removeProduct(index);
                    if (productRemoved)
                    {
                        MessageBox.Show("Product Deleted");
                    }
                }
            }
            else
            {
                MessageBox.Show("Product Not Selected");
            }

        }
        /***********  PARTS GUI FUNCTIONS ************/

        private void PartEditCell(object sender, DataGridViewCellEventArgs e)
        {
            // Double click to edit selected part
            this.modifyPartButton_Click(sender, e);
        }

        private void findPartButton_Click(object sender, EventArgs e)
        {
            string searPartValue = this.textSearchPart.Text;
            BindingList<Part> filteredPartsBindingList = new BindingList<Part>(Part.parts.Where(
                partData => partData.Name.partialStringMatch(searPartValue, StringComparison.OrdinalIgnoreCase))
                .ToList());
            if(filteredPartsBindingList.Count > 0)
            {
                dataGridParts.DataSource = filteredPartsBindingList;
            } else
            {
                dataGridParts.DataSource = Part.parts;
                MessageBox.Show("Part Not Found");
            }

        }
        private void modifyPartButton_Click(object sender, EventArgs e)
        {
            // load "modify" part form (create form with inputs loaded from selected part)
            if (dataGridParts.RowCount > 0 && dataGridParts.CurrentRow.Selected)
            {
                int partIndex = dataGridParts.CurrentRow.Index;
                Part partData = (Part)dataGridParts.CurrentRow.DataBoundItem;
                PartForm modifyPart = new PartForm(partIndex, partData, partIndex);
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
                    bool partRemoved = removePart(index);
                    if (partRemoved)
                    {
                        MessageBox.Show("Part Deleted");
                    }
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