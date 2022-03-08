
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
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPartsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // allPartsGrid
            // 
            this.allPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsGrid.Location = new System.Drawing.Point(487, 28);
            this.allPartsGrid.Name = "allPartsGrid";
            this.allPartsGrid.RowHeadersWidth = 51;
            this.allPartsGrid.Size = new System.Drawing.Size(380, 182);
            this.allPartsGrid.TabIndex = 0;
            this.allPartsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addPartToProduct);
            // 
            // productPartsGrid
            // 
            this.productPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productPartsGrid.Location = new System.Drawing.Point(487, 256);
            this.productPartsGrid.Name = "productPartsGrid";
            this.productPartsGrid.RowHeadersWidth = 51;
            this.productPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productPartsGrid.Size = new System.Drawing.Size(380, 182);
            this.productPartsGrid.TabIndex = 1;
            this.productPartsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.removePartFromProdcut);
            // 
            // allPartsLabel
            // 
            this.allPartsLabel.AutoSize = true;
            this.allPartsLabel.Location = new System.Drawing.Point(487, 9);
            this.allPartsLabel.Name = "allPartsLabel";
            this.allPartsLabel.Size = new System.Drawing.Size(45, 13);
            this.allPartsLabel.TabIndex = 2;
            this.allPartsLabel.Text = "All Parts";
            // 
            // productPartLabel
            // 
            this.productPartLabel.AutoSize = true;
            this.productPartLabel.Location = new System.Drawing.Point(487, 237);
            this.productPartLabel.Name = "productPartLabel";
            this.productPartLabel.Size = new System.Drawing.Size(71, 13);
            this.productPartLabel.TabIndex = 3;
            this.productPartLabel.Text = "Product Parts";
            // 
            // productIDInput
            // 
            this.productIDInput.Location = new System.Drawing.Point(74, 78);
            this.productIDInput.Name = "productIDInput";
            this.productIDInput.ReadOnly = true;
            this.productIDInput.Size = new System.Drawing.Size(100, 20);
            this.productIDInput.TabIndex = 4;
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Location = new System.Drawing.Point(13, 81);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(55, 13);
            this.productIdLabel.TabIndex = 5;
            this.productIdLabel.Text = "ProductID";
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.Location = new System.Drawing.Point(13, 118);
            this.partNameLabel.Name = "partNameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(35, 13);
            this.partNameLabel.TabIndex = 7;
            this.partNameLabel.Text = "Name";
            // 
            // productNameInput
            // 
            this.productNameInput.Location = new System.Drawing.Point(74, 115);
            this.productNameInput.Name = "productNameInput";
            this.productNameInput.Size = new System.Drawing.Size(194, 20);
            this.productNameInput.TabIndex = 6;
            // 
            // submitProductButton
            // 
            this.submitProductButton.Location = new System.Drawing.Point(74, 392);
            this.submitProductButton.Name = "submitProductButton";
            this.submitProductButton.Size = new System.Drawing.Size(75, 23);
            this.submitProductButton.TabIndex = 22;
            this.submitProductButton.Text = "Submit";
            this.submitProductButton.UseVisualStyleBackColor = true;
            // 
            // CancelProduct
            // 
            this.CancelProduct.Location = new System.Drawing.Point(164, 392);
            this.CancelProduct.Name = "CancelProduct";
            this.CancelProduct.Size = new System.Drawing.Size(75, 23);
            this.CancelProduct.TabIndex = 21;
            this.CancelProduct.Text = "Cancel";
            this.CancelProduct.UseVisualStyleBackColor = true;
            this.CancelProduct.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(13, 160);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.productPriceLabel.TabIndex = 24;
            this.productPriceLabel.Text = "Price";
            // 
            // productPriceInput
            // 
            this.productPriceInput.Location = new System.Drawing.Point(74, 157);
            this.productPriceInput.Name = "productPriceInput";
            this.productPriceInput.Size = new System.Drawing.Size(100, 20);
            this.productPriceInput.TabIndex = 23;
            // 
            // inStockLabel
            // 
            this.inStockLabel.AutoSize = true;
            this.inStockLabel.Location = new System.Drawing.Point(13, 193);
            this.inStockLabel.Name = "inStockLabel";
            this.inStockLabel.Size = new System.Drawing.Size(47, 13);
            this.inStockLabel.TabIndex = 26;
            this.inStockLabel.Text = "In Stock";
            // 
            // ProductStockInput
            // 
            this.ProductStockInput.Location = new System.Drawing.Point(74, 190);
            this.ProductStockInput.Name = "ProductStockInput";
            this.ProductStockInput.Size = new System.Drawing.Size(100, 20);
            this.ProductStockInput.TabIndex = 25;
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.Location = new System.Drawing.Point(13, 233);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(24, 13);
            this.productMinLabel.TabIndex = 28;
            this.productMinLabel.Text = "Min";
            // 
            // productMinInput
            // 
            this.productMinInput.Location = new System.Drawing.Point(74, 230);
            this.productMinInput.Name = "productMinInput";
            this.productMinInput.Size = new System.Drawing.Size(100, 20);
            this.productMinInput.TabIndex = 27;
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Location = new System.Drawing.Point(13, 268);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.productMaxLabel.TabIndex = 30;
            this.productMaxLabel.Text = "Max";
            // 
            // productMaxInput
            // 
            this.productMaxInput.Location = new System.Drawing.Point(74, 265);
            this.productMaxInput.Name = "productMaxInput";
            this.productMaxInput.Size = new System.Drawing.Size(100, 20);
            this.productMaxInput.TabIndex = 29;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
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
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPartsGrid)).EndInit();
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
    }
}