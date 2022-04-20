
namespace IsaacWattsInventorySystem.forms
{
    partial class PartForm
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
            this.CancelPart = new System.Windows.Forms.Button();
            this.PartType = new System.Windows.Forms.GroupBox();
            this.MachineIDButton = new System.Windows.Forms.RadioButton();
            this.CompanyNameButton = new System.Windows.Forms.RadioButton();
            this.partIDLabel = new System.Windows.Forms.Label();
            this.partIDInput = new System.Windows.Forms.TextBox();
            this.partNameLabel = new System.Windows.Forms.Label();
            this.partNameInput = new System.Windows.Forms.TextBox();
            this.partPriceLabel = new System.Windows.Forms.Label();
            this.partPriceInput = new System.Windows.Forms.TextBox();
            this.stockLabel = new System.Windows.Forms.Label();
            this.stockInput = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.partMinInput = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.partMaxInput = new System.Windows.Forms.TextBox();
            this.machineIDLabel = new System.Windows.Forms.Label();
            this.machineIDInput = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyNameInput = new System.Windows.Forms.TextBox();
            this.submitPartButton = new System.Windows.Forms.Button();
            this.errorProvider_Part = new System.Windows.Forms.ErrorProvider(this.components);
            this.PartType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Part)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelPart
            // 
            this.CancelPart.Location = new System.Drawing.Point(345, 547);
            this.CancelPart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelPart.Name = "CancelPart";
            this.CancelPart.Size = new System.Drawing.Size(88, 27);
            this.CancelPart.TabIndex = 0;
            this.CancelPart.Text = "Cancel";
            this.CancelPart.UseVisualStyleBackColor = true;
            this.CancelPart.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PartType
            // 
            this.PartType.Controls.Add(this.MachineIDButton);
            this.PartType.Controls.Add(this.CompanyNameButton);
            this.PartType.Location = new System.Drawing.Point(40, 54);
            this.PartType.Margin = new System.Windows.Forms.Padding(2);
            this.PartType.Name = "PartType";
            this.PartType.Padding = new System.Windows.Forms.Padding(2);
            this.PartType.Size = new System.Drawing.Size(394, 99);
            this.PartType.TabIndex = 1;
            this.PartType.TabStop = false;
            this.PartType.Text = "Type";
            // 
            // MachineIDButton
            // 
            this.MachineIDButton.AutoSize = true;
            this.MachineIDButton.Location = new System.Drawing.Point(52, 43);
            this.MachineIDButton.Margin = new System.Windows.Forms.Padding(2);
            this.MachineIDButton.Name = "MachineIDButton";
            this.MachineIDButton.Size = new System.Drawing.Size(72, 19);
            this.MachineIDButton.TabIndex = 1;
            this.MachineIDButton.Text = "In House";
            this.MachineIDButton.UseVisualStyleBackColor = true;
            this.MachineIDButton.Click += new System.EventHandler(this.toggleInOrOutsource);
            // 
            // CompanyNameButton
            // 
            this.CompanyNameButton.AutoSize = true;
            this.CompanyNameButton.Location = new System.Drawing.Point(220, 43);
            this.CompanyNameButton.Margin = new System.Windows.Forms.Padding(2);
            this.CompanyNameButton.Name = "CompanyNameButton";
            this.CompanyNameButton.Size = new System.Drawing.Size(84, 19);
            this.CompanyNameButton.TabIndex = 0;
            this.CompanyNameButton.Text = "Out Source";
            this.CompanyNameButton.UseVisualStyleBackColor = true;
            this.CompanyNameButton.Click += new System.EventHandler(this.toggleInOrOutsource);
            // 
            // partIDLabel
            // 
            this.partIDLabel.AutoSize = true;
            this.partIDLabel.Location = new System.Drawing.Point(41, 178);
            this.partIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partIDLabel.Name = "partIDLabel";
            this.partIDLabel.Size = new System.Drawing.Size(42, 15);
            this.partIDLabel.TabIndex = 5;
            this.partIDLabel.Text = "Part ID";
            // 
            // partIDInput
            // 
            this.partIDInput.Location = new System.Drawing.Point(91, 175);
            this.partIDInput.Margin = new System.Windows.Forms.Padding(2);
            this.partIDInput.Name = "partIDInput";
            this.partIDInput.ReadOnly = true;
            this.partIDInput.Size = new System.Drawing.Size(76, 23);
            this.partIDInput.TabIndex = 4;
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.Location = new System.Drawing.Point(41, 204);
            this.partNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partNameLabel.Name = "partNameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(39, 15);
            this.partNameLabel.TabIndex = 7;
            this.partNameLabel.Text = "Name";
            // 
            // partNameInput
            // 
            this.partNameInput.Location = new System.Drawing.Point(91, 202);
            this.partNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.partNameInput.Name = "partNameInput";
            this.partNameInput.Size = new System.Drawing.Size(152, 23);
            this.partNameInput.TabIndex = 6;
            this.partNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.partNameInput_Validating);
            // 
            // partPriceLabel
            // 
            this.partPriceLabel.AutoSize = true;
            this.partPriceLabel.Location = new System.Drawing.Point(41, 231);
            this.partPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partPriceLabel.Name = "partPriceLabel";
            this.partPriceLabel.Size = new System.Drawing.Size(33, 15);
            this.partPriceLabel.TabIndex = 9;
            this.partPriceLabel.Text = "Price";
            // 
            // partPriceInput
            // 
            this.partPriceInput.Location = new System.Drawing.Point(91, 227);
            this.partPriceInput.Margin = new System.Windows.Forms.Padding(2);
            this.partPriceInput.Name = "partPriceInput";
            this.partPriceInput.Size = new System.Drawing.Size(76, 23);
            this.partPriceInput.TabIndex = 8;
            this.partPriceInput.Validating += new System.ComponentModel.CancelEventHandler(this.partPriceInput_Validating);
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(41, 257);
            this.stockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(36, 15);
            this.stockLabel.TabIndex = 11;
            this.stockLabel.Text = "Stock";
            // 
            // stockInput
            // 
            this.stockInput.Location = new System.Drawing.Point(91, 254);
            this.stockInput.Margin = new System.Windows.Forms.Padding(2);
            this.stockInput.Name = "stockInput";
            this.stockInput.Size = new System.Drawing.Size(76, 23);
            this.stockInput.TabIndex = 10;
            this.stockInput.Validating += new System.ComponentModel.CancelEventHandler(this.stockInput_Validating);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(41, 283);
            this.minLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(28, 15);
            this.minLabel.TabIndex = 13;
            this.minLabel.Text = "Min";
            // 
            // partMinInput
            // 
            this.partMinInput.Location = new System.Drawing.Point(91, 280);
            this.partMinInput.Margin = new System.Windows.Forms.Padding(2);
            this.partMinInput.Name = "partMinInput";
            this.partMinInput.Size = new System.Drawing.Size(76, 23);
            this.partMinInput.TabIndex = 12;
            this.partMinInput.Validating += new System.ComponentModel.CancelEventHandler(this.partMinInput_Validating);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(41, 309);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(30, 15);
            this.maxLabel.TabIndex = 15;
            this.maxLabel.Text = "Max";
            // 
            // partMaxInput
            // 
            this.partMaxInput.Location = new System.Drawing.Point(91, 307);
            this.partMaxInput.Margin = new System.Windows.Forms.Padding(2);
            this.partMaxInput.Name = "partMaxInput";
            this.partMaxInput.Size = new System.Drawing.Size(76, 23);
            this.partMaxInput.TabIndex = 14;
            this.partMaxInput.Validating += new System.ComponentModel.CancelEventHandler(this.partMaxInput_Validating);
            // 
            // machineIDLabel
            // 
            this.machineIDLabel.AutoSize = true;
            this.machineIDLabel.Location = new System.Drawing.Point(41, 407);
            this.machineIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.machineIDLabel.Name = "machineIDLabel";
            this.machineIDLabel.Size = new System.Drawing.Size(67, 15);
            this.machineIDLabel.TabIndex = 17;
            this.machineIDLabel.Text = "Machine ID";
            // 
            // machineIDInput
            // 
            this.machineIDInput.Location = new System.Drawing.Point(114, 405);
            this.machineIDInput.Margin = new System.Windows.Forms.Padding(2);
            this.machineIDInput.Name = "machineIDInput";
            this.machineIDInput.Size = new System.Drawing.Size(152, 23);
            this.machineIDInput.TabIndex = 16;
            this.machineIDInput.Validating += new System.ComponentModel.CancelEventHandler(this.machineIDInput_Validating);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(41, 407);
            this.companyNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(94, 15);
            this.companyNameLabel.TabIndex = 19;
            this.companyNameLabel.Text = "Company Name";
            // 
            // companyNameInput
            // 
            this.companyNameInput.Location = new System.Drawing.Point(141, 405);
            this.companyNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.companyNameInput.Name = "companyNameInput";
            this.companyNameInput.Size = new System.Drawing.Size(152, 23);
            this.companyNameInput.TabIndex = 18;
            this.companyNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.companyNameInput_Validating);
            // 
            // submitPartButton
            // 
            this.submitPartButton.Location = new System.Drawing.Point(240, 547);
            this.submitPartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.submitPartButton.Name = "submitPartButton";
            this.submitPartButton.Size = new System.Drawing.Size(88, 27);
            this.submitPartButton.TabIndex = 20;
            this.submitPartButton.Text = "Submit";
            this.submitPartButton.UseVisualStyleBackColor = true;
            this.submitPartButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // errorProvider_Part
            // 
            this.errorProvider_Part.ContainerControl = this;
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 606);
            this.Controls.Add(this.submitPartButton);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.companyNameInput);
            this.Controls.Add(this.machineIDLabel);
            this.Controls.Add(this.machineIDInput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.partMaxInput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.partMinInput);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.stockInput);
            this.Controls.Add(this.partPriceLabel);
            this.Controls.Add(this.partPriceInput);
            this.Controls.Add(this.partNameLabel);
            this.Controls.Add(this.partNameInput);
            this.Controls.Add(this.partIDLabel);
            this.Controls.Add(this.partIDInput);
            this.Controls.Add(this.PartType);
            this.Controls.Add(this.CancelPart);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PartForm";
            this.Text = "Part Form";
            this.PartType.ResumeLayout(false);
            this.PartType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Part)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelPart;
        private System.Windows.Forms.GroupBox PartType;
        private System.Windows.Forms.RadioButton MachineIDButton;
        private System.Windows.Forms.RadioButton CompanyNameButton;
        private System.Windows.Forms.Label partIDLabel;
        private System.Windows.Forms.TextBox partIDInput;
        private System.Windows.Forms.Label partNameLabel;
        private System.Windows.Forms.TextBox partNameInput;
        private System.Windows.Forms.Label partPriceLabel;
        private System.Windows.Forms.TextBox partPriceInput;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.TextBox stockInput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox partMinInput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox partMaxInput;
        private System.Windows.Forms.Label machineIDLabel;
        private System.Windows.Forms.TextBox machineIDInput;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox companyNameInput;
        private System.Windows.Forms.Button submitPartButton;
        private ErrorProvider errorProvider_Part;
    }
}