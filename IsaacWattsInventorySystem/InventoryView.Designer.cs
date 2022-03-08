namespace IsaacWattsInventorySystem
{
    partial class InventoryView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.dataGridParts = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.ModifyProduct = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.AddPart = new System.Windows.Forms.Button();
            this.ModifyPart = new System.Windows.Forms.Button();
            this.DeletePart = new System.Windows.Forms.Button();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.textSearchProduct = new System.Windows.Forms.TextBox();
            this.searchProduct = new System.Windows.Forms.Button();
            this.searchPart = new System.Windows.Forms.Button();
            this.textSearchPart = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Location = new System.Drawing.Point(10, 73);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.RowHeadersWidth = 51;
            this.dataGridProducts.Size = new System.Drawing.Size(521, 360);
            this.dataGridProducts.TabIndex = 0;
            this.dataGridProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductEditCell);
            this.dataGridProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ProductsBindingComplete);
            // 
            // dataGridParts
            // 
            this.dataGridParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParts.Location = new System.Drawing.Point(539, 73);
            this.dataGridParts.Name = "dataGridParts";
            this.dataGridParts.RowHeadersWidth = 51;
            this.dataGridParts.Size = new System.Drawing.Size(521, 360);
            this.dataGridParts.TabIndex = 1;
            this.dataGridParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.PartsBindingComplete);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(455, 456);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // ModifyProduct
            // 
            this.ModifyProduct.Location = new System.Drawing.Point(374, 456);
            this.ModifyProduct.Name = "ModifyProduct";
            this.ModifyProduct.Size = new System.Drawing.Size(75, 23);
            this.ModifyProduct.TabIndex = 3;
            this.ModifyProduct.Text = "Modify";
            this.ModifyProduct.UseVisualStyleBackColor = true;
            this.ModifyProduct.Click += new System.EventHandler(this.modifyProductButton_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(293, 456);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(75, 23);
            this.AddProduct.TabIndex = 4;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // AddPart
            // 
            this.AddPart.Location = new System.Drawing.Point(824, 456);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(75, 23);
            this.AddPart.TabIndex = 7;
            this.AddPart.Text = "Add";
            this.AddPart.UseVisualStyleBackColor = true;
            this.AddPart.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // ModifyPart
            // 
            this.ModifyPart.Location = new System.Drawing.Point(904, 456);
            this.ModifyPart.Name = "ModifyPart";
            this.ModifyPart.Size = new System.Drawing.Size(75, 23);
            this.ModifyPart.TabIndex = 6;
            this.ModifyPart.Text = "Modify";
            this.ModifyPart.UseVisualStyleBackColor = true;
            this.ModifyPart.Click += new System.EventHandler(this.modifyPartButton_Click);
            // 
            // DeletePart
            // 
            this.DeletePart.Location = new System.Drawing.Point(986, 456);
            this.DeletePart.Name = "DeletePart";
            this.DeletePart.Size = new System.Drawing.Size(75, 23);
            this.DeletePart.TabIndex = 5;
            this.DeletePart.Text = "Delete";
            this.DeletePart.UseVisualStyleBackColor = true;
            this.DeletePart.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Location = new System.Drawing.Point(10, 54);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(49, 13);
            this.ProductsLabel.TabIndex = 8;
            this.ProductsLabel.Text = "Products";
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Location = new System.Drawing.Point(539, 54);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(31, 13);
            this.PartsLabel.TabIndex = 9;
            this.PartsLabel.Text = "Parts";
            this.PartsLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(985, 508);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // textSearchProduct
            // 
            this.textSearchProduct.Location = new System.Drawing.Point(293, 46);
            this.textSearchProduct.Margin = new System.Windows.Forms.Padding(2);
            this.textSearchProduct.Name = "textSearchProduct";
            this.textSearchProduct.Size = new System.Drawing.Size(157, 20);
            this.textSearchProduct.TabIndex = 11;
            // 
            // searchProduct
            // 
            this.searchProduct.Location = new System.Drawing.Point(455, 44);
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.Size = new System.Drawing.Size(75, 23);
            this.searchProduct.TabIndex = 12;
            this.searchProduct.Text = "Search";
            this.searchProduct.UseVisualStyleBackColor = true;
            // 
            // searchPart
            // 
            this.searchPart.Location = new System.Drawing.Point(986, 44);
            this.searchPart.Name = "searchPart";
            this.searchPart.Size = new System.Drawing.Size(75, 23);
            this.searchPart.TabIndex = 14;
            this.searchPart.Text = "Search";
            this.searchPart.UseVisualStyleBackColor = true;
            // 
            // textSearchPart
            // 
            this.textSearchPart.Location = new System.Drawing.Point(824, 46);
            this.textSearchPart.Margin = new System.Windows.Forms.Padding(2);
            this.textSearchPart.Name = "textSearchPart";
            this.textSearchPart.Size = new System.Drawing.Size(157, 20);
            this.textSearchPart.TabIndex = 13;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 552);
            this.Controls.Add(this.searchPart);
            this.Controls.Add(this.textSearchPart);
            this.Controls.Add(this.searchProduct);
            this.Controls.Add(this.textSearchProduct);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.ModifyPart);
            this.Controls.Add(this.DeletePart);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.ModifyProduct);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dataGridParts);
            this.Controls.Add(this.dataGridProducts);
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.DataGridView dataGridParts;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button ModifyProduct;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.Button ModifyPart;
        private System.Windows.Forms.Button DeletePart;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox textSearchProduct;
        private System.Windows.Forms.Button searchProduct;
        private System.Windows.Forms.Button searchPart;
        private System.Windows.Forms.TextBox textSearchPart;
    }
}
}