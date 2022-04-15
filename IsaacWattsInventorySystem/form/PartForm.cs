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
            toggleInOrOutsource(partData, new EventArgs());
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toggleInOrOutsource(object sender, EventArgs e)
        {
            if (CompanyNameButton.Checked)
            {
                companyNameLabel.Visible = true;
                companyNameInput.Visible = true;
                machineIDLabel.Visible = false;
                machineIDInput.Visible = false;
            }
            else
            {
                companyNameLabel.Visible = false;
                companyNameInput.Visible = false;
                machineIDLabel.Visible = true;
                machineIDInput.Visible = true;
            }

        }

        private void PartForm_Closing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (partIndex > 0)
            {
                if (CompanyNameButton.Checked)
                {
                    Part updatedOutsourcePart = new Outsource {
                        PartID = int.Parse(partIDInput.Text),
                        Name = partNameInput.Text,
                        Price = decimal.Parse(partPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                        InStock = int.Parse(stockInput.Text),
                        Min = int.Parse(partMinInput.Text),
                        Max = int.Parse(partMaxInput.Text),
                        SourceType = Globals.sourceType.OutSource,
                        CompanyName = companyNameInput.Text
                    };
                    // inventory.updatePart(updatedOutsourcePart)
                    Inventory.updatePart(partIndex, updatedOutsourcePart);
                }
                else
                {
                    // dataGridParts.Rows[dataGridRowIndex].SetValues(new InHouse
                    var updatedInHousePart = new InHouse {
                        PartID = int.Parse(partIDInput.Text),
                        Name = partNameInput.Text,
                        Price = decimal.Parse(partPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                        InStock = int.Parse(stockInput.Text),
                        Min = int.Parse(partMinInput.Text),
                        Max = int.Parse(partMaxInput.Text),
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
                        Name = partNameInput.Text,
                        Price = decimal.Parse(partPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                        InStock = int.Parse(stockInput.Text),
                        Min = int.Parse(partMinInput.Text),
                        Max = int.Parse(partMaxInput.Text),
                        SourceType = Globals.sourceType.OutSource,
                        CompanyName = companyNameInput.Text
                    };
                    Inventory.addPart(newOutsourcePart);
                }
                else
                {
                    // dataGridParts.Rows.Add(new InHouse
                    var newInHousePart = new InHouse {
                        PartID = newID,
                        Name = partNameInput.Text,
                        Price = decimal.Parse(partPriceInput.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                        InStock = int.Parse(stockInput.Text),
                        Min = int.Parse(partMinInput.Text),
                        Max = int.Parse(partMaxInput.Text),
                        SourceType = Globals.sourceType.InHouse,
                        MachineID = int.Parse(machineIDInput.Text)
                    };
                    Inventory.addPart(newInHousePart);
                }
                Globals.maxGlobalPartID++;

            }
            Close();
        }
    }
}
