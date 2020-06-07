using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CustomerResourceManagement
{
    
    public partial class frmInventory : Form
    {
        
        private void showMdiChild(Form thisForm, string action)
        {
            thisForm.MdiParent = this.ParentForm;
            thisForm.Text = action;
            thisForm.WindowState = FormWindowState.Maximized;
            thisForm.Show();
        }

        public void clearInputs()
        {
            tbColor.Text = "";
            numDealerCost.Value = 0;
            tbMake.Text = "";
            numMileage.Value = 0;
            tbModel.Text = "";
            numPrice.Value = 0;
            tbPurchaseOrderID.Text = "";
            tbType.Text = "";
            tbVIN.Text = "";
            numYear.Value = 1890;
            dtpLotArrival.Value = DateTime.Now;
        }

        public frmInventory()
        {
            InitializeComponent();
        }

        private void frmInvoices_Activated(object sender, EventArgs e)
        {

            if (this.Text == "Add New Inventory")
            {
                numPrice.ReadOnly = false;
                tbMake.ReadOnly = false;
                tbModel.ReadOnly = false;
                numMileage.ReadOnly = false;
                numYear.ReadOnly = false;
                numDealerCost.ReadOnly = false;
                tbType.ReadOnly = false;
                tbColor.ReadOnly = false;
                tbPurchaseOrderID.ReadOnly = false;
                tbVIN.ReadOnly = false;


                numPrice.Enabled = true;
                tbMake.Enabled = true;
                tbModel.Enabled = true;
                numMileage.Enabled = true;
                numYear.Enabled = true;
                numDealerCost.Enabled = true;
                tbType.Enabled = true;
                tbColor.Enabled = true;
                tbPurchaseOrderID.Enabled = true;
                tbVIN.Enabled = true;

                tbPurchaseOrderID.Visible = true;
                numDealerCost.Visible = true;
                tbVIN.Visible = true;
                dtpLotArrival.Visible = true;
                dtpLotArrival.Value = DateTime.Now;
                lblCost.Visible = true;
                lblVIN.Visible = true;
                lblPO.Visible = true;
                lblReceived.Visible = true;
                
                tbTimeOnLot.Visible = false;

                
                lblLotArrival.Visible = false;
                cboInventory.Visible = false;
                btnAction.Text = "Add";
                btnAction.Enabled = false;
            }
            else if (this.Text == "Edit Inventory")
            {
                numPrice.Enabled = true;
                tbMake.Enabled = true;
                tbModel.Enabled = true;
                numMileage.Enabled = true;
                numYear.Enabled = true;
                tbType.Enabled = true;
                tbColor.Enabled = true;
                

                numPrice.ReadOnly = false;
                tbMake.ReadOnly = false;
                tbModel.ReadOnly = false;
                numMileage.ReadOnly = false;
                numYear.ReadOnly = false;
                tbType.ReadOnly = false;
                tbColor.ReadOnly = false;

                cboInventory.Visible = true;
                btnAction.Text = "Save";
            }
            else if (this.Text == "Delete Inventory")
            {
                cboInventory.Visible = true;
                btnAction.Text = "Delete";
            }
            else if (this.Text == "Search Inventory")
            {
                cboInventory.Visible = true;
                btnAction.Text = "Detail";
            }

            
            cboInventory.DataSource = null;
            cboInventory.DataSource = GlobalListForTesting.totalInventoryList;
           
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (btnAction.Text == "Delete")
            {
                if (cboInventory.SelectedIndex > -1)
                {
                    if (MessageBox.Show("Are you sure you want to delete vehicle " + cboInventory.SelectedItem.ToString() + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clsInventory.deleteInventory((cboInventory.SelectedItem as clsInventory).InventoryID);
                    }

                    cboInventory.DataSource = null;
                    cboInventory.DataSource = clsInventory.selectAllInventory();
                }
                else
                {
                    MessageBox.Show("No vehicle selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        
            else if (btnAction.Text == "Save")
            {
                if (cboInventory.SelectedIndex > -1)
                {
                    clsInventory DBVersion = clsInventory.searchInventory((cboInventory.SelectedItem as clsInventory).InventoryID);
                    clsInventory LoadedVersion = new clsInventory(cboInventory.SelectedItem as clsInventory, 1);
                    clsInventory UpdatedVersion = new clsInventory((cboInventory.SelectedItem as clsInventory).InventoryID, tbMake.Text, tbModel.Text, tbColor.Text, Convert.ToInt32(numYear.Value), Convert.ToInt32(numMileage.Value), dtpLotArrival.Value,
                                                            numDealerCost.Value, numPrice.Value, tbType.Text.ToString(), tbVIN.Text.ToString(), tbPurchaseOrderID.Text.ToString(), LoadedVersion.SalespersonID, LoadedVersion.CustomerHold, LoadedVersion.Available);

                    if (DBVersion == LoadedVersion)
                    {
                        // error message
                        MessageBox.Show("Edits not saved", "Abject Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        clsInventory.insertInventory(UpdatedVersion);
                    }

                    cboInventory.DataSource = null;
                    cboInventory.DataSource = clsInventory.selectAllInventory();
                }
                else
                {
                    MessageBox.Show("No vehicle selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (btnAction.Text == "Add")
            {
                
                clsInventory newItem = new clsInventory(DateTime.Now.ToString(),tbMake.Text,tbModel.Text,tbColor.Text,Convert.ToInt32(numYear.Value),Convert.ToInt32(numMileage.Value),dtpLotArrival.Value,
                                                        numDealerCost.Value, numPrice.Value, tbType.Text.ToString(),tbVIN.Text.ToString(),tbPurchaseOrderID.Text.ToString(),"","",true);

                clsInventory.insertInventory(newItem);
                MessageBox.Show("Vehicle added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cboInventory.DataSource = null;
                cboInventory.DataSource = clsInventory.selectAllInventory();
                clearInputs();

                
            }
            else if (btnAction.Text == "Detail")
            {
                if (cboInventory.SelectedIndex > -1)
                {
                    frmInventoryDetail frmDetail = new frmInventoryDetail();
                    frmDetail.vehicleLoaded = clsInventory.searchInventory((cboInventory.SelectedItem as clsInventory).InventoryID);
                    showMdiChild(frmDetail, "Vehicle Detail");
                }
                else
                {
                    MessageBox.Show("No vehicle selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
        }

        private void CboInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboInventory.SelectedIndex > -1 && btnAction.Text != "Add")
            {
                tbMake.Text = (cboInventory.SelectedItem as clsInventory).Make;
                tbModel.Text = (cboInventory.SelectedItem as clsInventory).Model;
                numYear.Value = (cboInventory.SelectedItem as clsInventory).Year;
                numPrice.Value = (cboInventory.SelectedItem as clsInventory).StickerPrice;
                numMileage.Value = (cboInventory.SelectedItem as clsInventory).Mileage;
                numDealerCost.Value = (cboInventory.SelectedItem as clsInventory).CostPaid;
                tbType.Text = (cboInventory.SelectedItem as clsInventory).BodyType;
                tbColor.Text = (cboInventory.SelectedItem as clsInventory).Color;
                tbVIN.Text = (cboInventory.SelectedItem as clsInventory).Vin;
                tbPurchaseOrderID.Text = (cboInventory.SelectedItem as clsInventory).PurchaseOrderID;
                
                
                tbTimeOnLot.Text = Convert.ToInt32((DateTime.Now - (cboInventory.SelectedItem as clsInventory).ArrivedOnLot).TotalDays).ToString();
            }
            if (btnAction.Text == "Save")
            {
                btnAction.Enabled = false;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (btnAction.Text == "Save" || btnAction.Text == "Add")
            {
                if (MessageBox.Show("Are you sure you want to exit without saving?", "Confirm Discard Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void TbPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vehicle_Information_Enter(object sender, EventArgs e)
        {

        }

        private void LblLotArrive_Click(object sender, EventArgs e)
        {

        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {

        }

        private void TbTimeOnLot_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            if (Int32.TryParse(tbTimeOnLot.Text,out x) && x < 0)
            {
                tbTimeOnLot.Text = "Not yet received";
            }
        }

        private void NumPrice_ValueChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
        }

        private void NumYear_ValueChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
        }

        private void TbMake_TextChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
        }

        private void TbModel_TextChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
        }

        private void NumMileage_ValueChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
        }

        private void TbType_TextChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
        }

        private void TbColor_TextChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
        }

        private void DtpLotArrival_ValueChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
        }

        private void NumDealerCost_ValueChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
        }

        private void TbVIN_TextChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
        }

        private void TbPurchaseOrderID_TextChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
        }
    }
}
