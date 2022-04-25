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
            foreach (Control control in Controls)
            {
                control.Focus();
                if (!Validate())
                {
                    DialogResult = DialogResult.None;
                    return;
                }
            }
            if (partIndex >= 0)
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

        private void partNameInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(partNameInput.Text))
            {
                e.Cancel = true;
                partNameInput.Focus();
                errorProvider_Part.SetError(partNameInput, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_Part.SetError(partNameInput, "");
            }
        }

        private void partPriceInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(partPriceInput.Text))
            {
                e.Cancel = true;
                partPriceInput.Focus();
                errorProvider_Part.SetError(partPriceInput, "Price should not be left blank!");
            }
            else if (!decimal.TryParse(partPriceInput.Text, out decimal numberValue))
            {
                e.Cancel = true;
                partPriceInput.Focus();
                errorProvider_Part.SetError(partPriceInput, "Price value should be number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_Part.SetError(partPriceInput, "");
            }
        }

        private void stockInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(stockInput.Text))
            {
                e.Cancel = true;
                stockInput.Focus();
                errorProvider_Part.SetError(stockInput, "Stock should not be left blank!");
            }
            else if (!int.TryParse(stockInput.Text, out int numberValue))
            {
                e.Cancel = true;
                stockInput.Focus();
                errorProvider_Part.SetError(stockInput, "Stock value should be number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_Part.SetError(stockInput, "");
            }
        }

        private void partMinInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(partMinInput.Text))
            {
                e.Cancel = true;
                partMinInput.Focus();
                errorProvider_Part.SetError(partMinInput, "Minimum Amount should not be left blank!");
            }
            else if (!int.TryParse(partMinInput.Text, out int numberValue))
            {
                e.Cancel = true;
                partMinInput.Focus();
                errorProvider_Part.SetError(partMinInput, "Minimum Amount value should be number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_Part.SetError(partMinInput, "");
            }
        }

        private void partMaxInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(partMaxInput.Text))
            {
                e.Cancel = true;
                partMaxInput.Focus();
                errorProvider_Part.SetError(partMaxInput, "Maximum Amount should not be left blank!");
            }
            else if (!int.TryParse(partMaxInput.Text, out int numberValue))
            {
                e.Cancel = true;
                partMaxInput.Focus();
                errorProvider_Part.SetError(partMaxInput, "Maximum Amount value should be number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_Part.SetError(partMaxInput, "");
            }
        }

        private void companyNameInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!CompanyNameButton.Checked)
            {
                e.Cancel = false;
                errorProvider_Part.SetError(companyNameInput, "");
                return;
            }
            if (string.IsNullOrWhiteSpace(companyNameInput.Text))
            {
                e.Cancel = true;
                companyNameInput.Focus();
                errorProvider_Part.SetError(companyNameInput, "Company Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_Part.SetError(companyNameInput, "");
            }
        }

        private void machineIDInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!MachineIDButton.Checked)
            {
                e.Cancel = false;
                errorProvider_Part.SetError(machineIDInput, "");
                return;
            }
            if (string.IsNullOrWhiteSpace(machineIDInput.Text))
            {
                e.Cancel = true;
                machineIDInput.Focus();
                errorProvider_Part.SetError(machineIDInput, "Machine ID should not be left blank!");
            }
            else if (!int.TryParse(machineIDInput.Text, out int numberValue))
            {
                e.Cancel = true;
                machineIDInput.Focus();
                errorProvider_Part.SetError(machineIDInput, "Machine ID value should be number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_Part.SetError(machineIDInput, "");
            }
        }
    }
}
