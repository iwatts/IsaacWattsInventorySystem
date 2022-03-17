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
    public partial class PartForm : Form
    {
        public PartForm(int partID, Part partData, int rowIndex = -1)
        {
            InitializeComponent();

            partIDInput.Text = partID.ToString();
            dataGridRowIndex = rowIndex;
            dynamic typedPartData = null;
            if (partData is Part)
            {
                // fill in form
                partNameInput.Text = partData.Name;
                partPriceInput.Text = partData.Price.ToString();
                stockInput.Text = partData.InStock.ToString();
                partMinInput.Text = partData.Min.ToString();
                partMaxInput.Text = partData.Max.ToString();
                if(partData.SourceType == Globals.sourceType.OutSource)
                {
                    typedPartData = partData as Outsource;
                } else
                {
                    typedPartData = partData as InHouse;
                }


                if(typedPartData is InHouse)
                {
                    machineIDInput.Text = typedPartData.MachineID.ToString();
                }else if(typedPartData is Outsource)
                {
                    companyNameInput.Text = typedPartData.CompanyName;
                }
            } else
            {
                partData = { }
            }


            // set type to matching data if editing part
            if (partData is Part && partData is Outsource)
            {
                CompanyNameButton.Checked = true;
            } else
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
            } else
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
            if(rowIndex > 0)
            {
                if(CompanyNameButton.Checked)
                {
                    dataGridParts.Rows.SetValues(new Outsource{
                        PartID = this.partIDInput,
                        Name = this.partNameInput.Text,
                        Price = float.Parse(this.partPriceInput, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                        InStock = Int32.Parse(this.stockInput.Text),
                        Min = Int32.Parse(this.partMinInput.Text),
                        Max = Int32.Parse(this.partMaxInput.Text)
                        SourceType = Globals.sourceType.OutSource,
                        CompanyName = this.companyNameInput
                    });
                }else
                {
                    dataGridParts.Rows.SetValues(new InHouse{
                        PartID = this.partIDInput,
                        Name = this.partNameInput.Text,
                        Price = float.Parse(this.partPriceInput, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                        InStock = Int32.Parse(this.stockInput.Text),
                        Min = Int32.Parse(this.partMinInput.Text),
                        Max = Int32.Parse(this.partMaxInput.Text)
                        SourceType = Globals.sourceType.InHouse,
                        MachineID = this.machineIDInput
                    });
                }
            }
            else
            {
                newID = Globals.maxGlobalPartID
                if(CompanyNameButton.Checked)
                {
                    dataGridParts.Rows.Add(new Outsource{
                        PartID = this.partIDInput,
                        Name = this.partNameInput.Text,
                        Price = float.Parse(this.partPriceInput, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                        InStock = Int32.Parse(this.stockInput.Text),
                        Min = Int32.Parse(this.partMinInput.Text),
                        Max = Int32.Parse(this.partMaxInput.Text)
                        SourceType = Globals.sourceType.OutSource,
                        CompanyName = this.companyNameInput
                    });
                }else
                {
                    dataGridParts.Rows.Add(new InHouse{
                        PartID = this.partIDInput,
                        Name = this.partNameInput.Text,
                        Price = float.Parse(this.partPriceInput, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency),
                        InStock = Int32.Parse(this.stockInput.Text),
                        Min = Int32.Parse(this.partMinInput.Text),
                        Max = Int32.Parse(this.partMaxInput.Text)
                        SourceType = Globals.sourceType.InHouse,
                        MachineID = this.machineIDInput
                    });
                }
                Globals.maxGlobalPartID ++;

            }
            this.Close();
        }
    }
}
