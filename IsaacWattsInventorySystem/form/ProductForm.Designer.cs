
namespace IsaacWattsInventorySystem.forms
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
            this.allPartsGrid = new System.Windows.Forms.DataGridView();
            this.productPartsGrid = new System.Windows.Forms.DataGridView();
            this.allPartsLabel = new System.Windows.Forms.Label();
            this.productPartLabel = new System.Windows.Forms.Label();
            this.productIDInput = new System.Windows.Forms.TextBox();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.partNameLabel = new System.Windows.Forms.Label();
            this.productNameInput = new System.Windows.Forms.TextBox();
            this.submitProductButton = new System.Windows.Forms.Button();
            this.CancelProduct = new System.Windows.Forms.Button();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productPriceInput = new System.Windows.Forms.TextBox();
            this.inStockLabel = new System.Windows.Forms.Label();
            this.ProductStockInput = new System.Windows.Forms.TextBox();
            this.productMinLabel = new System.Windows.Forms.Label();
            this.productMinInput = new System.Windows.Forms.TextBox();
            this.productMaxLabel = new System.Windows.Forms.Label();
            this.productMaxInput = new System.Windows.Forms.TextBox();
            this.searchAllPartsInput = new System.Windows.Forms.TextBox();
            this.searchAllParts = new System.Windows.Forms.Button();
            this.searchProductParts = new System.Windows.Forms.Button();
            this.searchProductPartsInput = new System.Windows.Forms.TextBox();
            this.errorProvider_Product = new System.Windows.Forms.ErrorProvider(this.components);
            this.addPartButton = new System.Windows.Forms.Button();
            this.removePartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // allPartsGrid
            // 
            this.allPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsGrid.Location = new System.Drawing.Point(568, 32);
            this.allPartsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.allPartsGrid.Name = "allPartsGrid";
            this.allPartsGrid.ReadOnly = true;
            this.allPartsGrid.RowHeadersWidth = 51;
            this.allPartsGrid.Size = new System.Drawing.Size(444, 210);
            this.allPartsGrid.TabIndex = 0;
            // 
            // productPartsGrid
            // 
            this.productPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productPartsGrid.Location = new System.Drawing.Point(568, 296);
            this.productPartsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.productPartsGrid.Name = "productPartsGrid";
            this.productPartsGrid.ReadOnly = true;
            this.productPartsGrid.RowHeadersWidth = 51;
            this.productPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productPartsGrid.Size = new System.Drawing.Size(444, 210);
            this.productPartsGrid.TabIndex = 1;
            // 
            // allPartsLabel
            // 
            this.allPartsLabel.AutoSize = true;
            this.allPartsLabel.Location = new System.Drawing.Point(568, 10);
            this.allPartsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.allPartsLabel.Name = "allPartsLabel";
            this.allPartsLabel.Size = new System.Drawing.Size(50, 15);
            this.allPartsLabel.TabIndex = 2;
            this.allPartsLabel.Text = "All Parts";
            // 
            // productPartLabel
            // 
            this.productPartLabel.AutoSize = true;
            this.productPartLabel.Location = new System.Drawing.Point(568, 274);
            this.productPartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productPartLabel.Name = "productPartLabel";
            this.productPartLabel.Size = new System.Drawing.Size(78, 15);
            this.productPartLabel.TabIndex = 3;
            this.productPartLabel.Text = "Product Parts";
            // 
            // productIDInput
            // 
            this.productIDInput.Location = new System.Drawing.Point(87, 90);
            this.productIDInput.Margin = new System.Windows.Forms.Padding(4);
            this.productIDInput.Name = "productIDInput";
            this.productIDInput.ReadOnly = true;
            this.productIDInput.Size = new System.Drawing.Size(116, 23);
            this.productIDInput.TabIndex = 4;
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Location = new System.Drawing.Point(15, 94);
            this.productIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(60, 15);
            this.productIdLabel.TabIndex = 5;
            this.productIdLabel.Text = "ProductID";
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.Location = new System.Drawing.Point(15, 136);
            this.partNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partNameLabel.Name = "partNameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(39, 15);
            this.partNameLabel.TabIndex = 7;
            this.partNameLabel.Text = "Name";
            // 
            // productNameInput
            // 
            this.productNameInput.Location = new System.Drawing.Point(87, 133);
            this.productNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.productNameInput.Name = "productNameInput";
            this.productNameInput.Size = new System.Drawing.Size(225, 23);
            this.productNameInput.TabIndex = 6;
            this.productNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.productName_Validating);
            // 
            // submitProductButton
            // 
            this.submitProductButton.Location = new System.Drawing.Point(87, 452);
            this.submitProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitProductButton.Name = "submitProductButton";
            this.submitProductButton.Size = new System.Drawing.Size(88, 26);
            this.submitProductButton.TabIndex = 22;
            this.submitProductButton.Text = "Submit";
            this.submitProductButton.UseVisualStyleBackColor = true;
            this.submitProductButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelProduct
            // 
            this.CancelProduct.Location = new System.Drawing.Point(192, 452);
            this.CancelProduct.Margin = new System.Windows.Forms.Padding(4);
            this.CancelProduct.Name = "CancelProduct";
            this.CancelProduct.Size = new System.Drawing.Size(88, 26);
            this.CancelProduct.TabIndex = 21;
            this.CancelProduct.Text = "Cancel";
            this.CancelProduct.UseVisualStyleBackColor = true;
            this.CancelProduct.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(15, 184);
            this.productPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(33, 15);
            this.productPriceLabel.TabIndex = 24;
            this.productPriceLabel.Text = "Price";
            // 
            // productPriceInput
            // 
            this.productPriceInput.Location = new System.Drawing.Point(87, 182);
            this.productPriceInput.Margin = new System.Windows.Forms.Padding(4);
            this.productPriceInput.Name = "productPriceInput";
            this.productPriceInput.Size = new System.Drawing.Size(116, 23);
            this.productPriceInput.TabIndex = 23;
            this.productPriceInput.Validating += new System.ComponentModel.CancelEventHandler(this.priceInput_Validating);
            // 
            // inStockLabel
            // 
            this.inStockLabel.AutoSize = true;
            this.inStockLabel.Location = new System.Drawing.Point(15, 223);
            this.inStockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inStockLabel.Name = "inStockLabel";
            this.inStockLabel.Size = new System.Drawing.Size(49, 15);
            this.inStockLabel.TabIndex = 26;
            this.inStockLabel.Text = "In Stock";
            // 
            // ProductStockInput
            // 
            this.ProductStockInput.Location = new System.Drawing.Point(87, 219);
            this.ProductStockInput.Margin = new System.Windows.Forms.Padding(4);
            this.ProductStockInput.Name = "ProductStockInput";
            this.ProductStockInput.Size = new System.Drawing.Size(116, 23);
            this.ProductStockInput.TabIndex = 25;
            this.ProductStockInput.Validating += new System.ComponentModel.CancelEventHandler(this.stockInput_Validating);
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.Location = new System.Drawing.Point(15, 268);
            this.productMinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(28, 15);
            this.productMinLabel.TabIndex = 28;
            this.productMinLabel.Text = "Min";
            // 
            // productMinInput
            // 
            this.productMinInput.Location = new System.Drawing.Point(87, 266);
            this.productMinInput.Margin = new System.Windows.Forms.Padding(4);
            this.productMinInput.Name = "productMinInput";
            this.productMinInput.Size = new System.Drawing.Size(116, 23);
            this.productMinInput.TabIndex = 27;
            this.productMinInput.Validating += new System.ComponentModel.CancelEventHandler(this.minInput_Validating);
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Location = new System.Drawing.Point(15, 309);
            this.productMaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(30, 15);
            this.productMaxLabel.TabIndex = 30;
            this.productMaxLabel.Text = "Max";
            // 
            // productMaxInput
            // 
            this.productMaxInput.Location = new System.Drawing.Point(87, 306);
            this.productMaxInput.Margin = new System.Windows.Forms.Padding(4);
            this.productMaxInput.Name = "productMaxInput";
            this.productMaxInput.Size = new System.Drawing.Size(116, 23);
            this.productMaxInput.TabIndex = 29;
            this.productMaxInput.Validating += new System.ComponentModel.CancelEventHandler(this.maxInput_Validating);
            // 
            // searchAllPartsInput
            // 
            this.searchAllPartsInput.Location = new System.Drawing.Point(738, 5);
            this.searchAllPartsInput.Margin = new System.Windows.Forms.Padding(4);
            this.searchAllPartsInput.Name = "searchAllPartsInput";
            this.searchAllPartsInput.Size = new System.Drawing.Size(180, 23);
            this.searchAllPartsInput.TabIndex = 31;
            // 
            // searchAllParts
            // 
            this.searchAllParts.Location = new System.Drawing.Point(924, 2);
            this.searchAllParts.Margin = new System.Windows.Forms.Padding(4);
            this.searchAllParts.Name = "searchAllParts";
            this.searchAllParts.Size = new System.Drawing.Size(88, 26);
            this.searchAllParts.TabIndex = 32;
            this.searchAllParts.Text = "Search";
            this.searchAllParts.UseVisualStyleBackColor = true;
            this.searchAllParts.Click += new System.EventHandler(this.filterAllParts_Click);
            // 
            // searchProductParts
            // 
            this.searchProductParts.Location = new System.Drawing.Point(924, 266);
            this.searchProductParts.Margin = new System.Windows.Forms.Padding(4);
            this.searchProductParts.Name = "searchProductParts";
            this.searchProductParts.Size = new System.Drawing.Size(88, 26);
            this.searchProductParts.TabIndex = 33;
            this.searchProductParts.Text = "Search";
            this.searchProductParts.UseVisualStyleBackColor = true;
            this.searchProductParts.Click += new System.EventHandler(this.filterProductParts_Click);
            // 
            // searchProductPartsInput
            // 
            this.searchProductPartsInput.Location = new System.Drawing.Point(738, 268);
            this.searchProductPartsInput.Margin = new System.Windows.Forms.Padding(4);
            this.searchProductPartsInput.Name = "searchProductPartsInput";
            this.searchProductPartsInput.Size = new System.Drawing.Size(180, 23);
            this.searchProductPartsInput.TabIndex = 34;
            // 
            // errorProvider_Product
            // 
            this.errorProvider_Product.ContainerControl = this;
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(486, 32);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(75, 23);
            this.addPartButton.TabIndex = 35;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // removePartButton
            // 
            this.removePartButton.Location = new System.Drawing.Point(486, 296);
            this.removePartButton.Name = "removePartButton";
            this.removePartButton.Size = new System.Drawing.Size(75, 23);
            this.removePartButton.TabIndex = 36;
            this.removePartButton.Text = "Remove";
            this.removePartButton.UseVisualStyleBackColor = true;
            this.removePartButton.Click += new System.EventHandler(this.removePartButton_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 519);
            this.Controls.Add(this.removePartButton);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.searchProductPartsInput);
            this.Controls.Add(this.searchProductParts);
            this.Controls.Add(this.searchAllParts);
            this.Controls.Add(this.searchAllPartsInput);
            this.Controls.Add(this.productMaxLabel);
            this.Controls.Add(this.productMaxInput);
            this.Controls.Add(this.productMinLabel);
            this.Controls.Add(this.productMinInput);
            this.Controls.Add(this.inStockLabel);
            this.Controls.Add(this.ProductStockInput);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productPriceInput);
            this.Controls.Add(this.submitProductButton);
            this.Controls.Add(this.CancelProduct);
            this.Controls.Add(this.partNameLabel);
            this.Controls.Add(this.productNameInput);
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.productIDInput);
            this.Controls.Add(this.productPartLabel);
            this.Controls.Add(this.allPartsLabel);
            this.Controls.Add(this.productPartsGrid);
            this.Controls.Add(this.allPartsGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allPartsGrid;
        private System.Windows.Forms.DataGridView productPartsGrid;
        private System.Windows.Forms.Label allPartsLabel;
        private System.Windows.Forms.Label productPartLabel;
        private System.Windows.Forms.TextBox productIDInput;
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.Label partNameLabel;
        private System.Windows.Forms.TextBox productNameInput;
        private System.Windows.Forms.Button submitProductButton;
        private System.Windows.Forms.Button CancelProduct;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.TextBox productPriceInput;
        private System.Windows.Forms.Label inStockLabel;
        private System.Windows.Forms.TextBox ProductStockInput;
        private System.Windows.Forms.Label productMinLabel;
        private System.Windows.Forms.TextBox productMinInput;
        private System.Windows.Forms.Label productMaxLabel;
        private System.Windows.Forms.TextBox productMaxInput;
        private System.Windows.Forms.TextBox searchAllPartsInput;
        private System.Windows.Forms.Button searchAllParts;
        private System.Windows.Forms.Button searchProductParts;
        private System.Windows.Forms.TextBox searchProductPartsInput;
        private ErrorProvider errorProvider_Product;
        private Button removePartButton;
        private Button addPartButton;
    }
}