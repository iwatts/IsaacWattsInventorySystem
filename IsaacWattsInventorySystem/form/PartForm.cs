using IsaacWattsInventorySystem.models;
using System.Globalization;

namespace IsaacWattsInventorySystem.forms
{
    public partial class PartForm : Form
    {
        private int partIndex { get; set; }
        public PartForm(int partID, Part partData, int rowIndex = -1)
        {
            InitializeComponent();

            partIDInput.Text = partID.ToString();
            partIndex = rowIndex;
            dynamic typedPartData = null;
            if (partData is Part)
            {
                // fill in form
                partNameInput.Text = partData.Name;
                partPriceInput.Text = partData.Price.ToString();
                stockInput.Text = partData.InStock.ToString();
                partMinInput.Text = partData.Min.ToString();
                partMaxInput.Text = partData.Max.ToString();
                if (partData.SourceType == Globals.sourceType.OutSource)
                {
                    typedPartData = partData as Outsource;
                }
                else
                {
                    typedPartData = partData as InHouse;
                }


                if (typedPartData is InHouse)
                {
                    machineIDInput.Text = typedPartData.MachineID.ToString();
                }
                else if (typedPartData is Outsource)
                {
                    companyNameInput.Text = typedPartData.CompanyName;
                }
            }


            // set type to matching data if editing part
            if (partData is Part && partData is Outsource)
            {
                CompanyNameButton.Checked = true;
            }
            else
            {
                MachineIDButton.Checked = true;
            }

            // Update the toggle to match any changes
            this.toggleInOrOutsource(partData, new EventArgs());
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toggleInOrOutsource(object sender, EventArgs e)
        {
            if (CompanyNameButton.Checked)
            {
                this.companyNameLabel.Visible = true;
                this.companyNameInput.Visible = true;
                this.machineIDLabel.Visible = false;
                this.machineIDInput.Visible = false;
            }
            else
            {
                this.companyNameLabel.Visible = false;
                this.companyNameInput.Visible = false;
                this.machineIDLabel.Visible = true;
                this.machineIDInput.Visible = true;
            }

        }

        private void PartForm_Closing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (partIndex > 0)
            {
                if (CompanyNameButton.Checked)
                {
                    Part updatedOutsourcePart = new Outsource {
                        PartID = int.Parse(this.partIDInput.Text),
                        Name = this.partNameInput.Text,
                        Price = decimal.Parse(this.partPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                        InStock = int.Parse(this.stockInput.Text),
                        Min = int.Parse(this.partMinInput.Text),
                        Max = int.Parse(this.partMaxInput.Text),
                        SourceType = Globals.sourceType.OutSource,
                        CompanyName = this.companyNameInput.Text
                    };
                    // inventory.updatePart(updatedOutsourcePart)
                    Inventory.updatePart(partIndex, updatedOutsourcePart);
                }
                else
                {
                    // dataGridParts.Rows[dataGridRowIndex].SetValues(new InHouse
                    var updatedInHousePart = new InHouse {
                        PartID = int.Parse(this.partIDInput.Text),
                        Name = this.partNameInput.Text,
                        Price = decimal.Parse(this.partPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                        InStock = int.Parse(this.stockInput.Text),
                        Min = int.Parse(this.partMinInput.Text),
                        Max = int.Parse(this.partMaxInput.Text),
                        SourceType = Globals.sourceType.InHouse,
                        MachineID = int.Parse(machineIDInput.Text)
                    };
                    Inventory.updatePart(partIndex, updatedInHousePart);
                }
            }
            else
            {
                int newID = Globals.maxGlobalPartID;
                if (CompanyNameButton.Checked)
                {
                    // dataGridParts.Rows.Add(new Outsource
                    var newOutsourcePart = new Outsource {
                        PartID = newID,
                        Name = this.partNameInput.Text,
                        Price = decimal.Parse(this.partPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                        InStock = int.Parse(this.stockInput.Text),
                        Min = int.Parse(this.partMinInput.Text),
                        Max = int.Parse(this.partMaxInput.Text),
                        SourceType = Globals.sourceType.OutSource,
                        CompanyName = this.companyNameInput.Text
                    };
                    Inventory.addPart(newOutsourcePart);
                }
                else
                {
                    // dataGridParts.Rows.Add(new InHouse
                    var newInHousePart = new InHouse {
                        PartID = newID,
                        Name = this.partNameInput.Text,
                        Price = decimal.Parse(this.partPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                        InStock = int.Parse(this.stockInput.Text),
                        Min = int.Parse(this.partMinInput.Text),
                        Max = int.Parse(this.partMaxInput.Text),
                        SourceType = Globals.sourceType.InHouse,
                        MachineID = int.Parse(machineIDInput.Text)
                    };
                    Inventory.addPart(newInHousePart);
                }
                Globals.maxGlobalPartID++;

            }
            this.Close();
        }
    }
}
