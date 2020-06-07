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
    public partial class frmPurchasing : Form
    {
        private void showMdiChild(Form thisForm, string action)
        {
            thisForm.MdiParent = this.ParentForm;
            thisForm.Text = action;
            thisForm.WindowState = FormWindowState.Maximized;
            thisForm.Show();
        }

        private void clearForm()
        {
            tbAuthorizedBy.Text = "";
            tbColor.Text = "";
            tbMake.Text = "";
            tbModel.Text = "";
            tbSource.Text = "";
            tbType.Text = "";
            tbVIN.Text = "";
            numCost.Value = 0;
            numMileage.Value = 0;
            numYear.Value = 1890;
        }

        public frmPurchasing()
        {
            InitializeComponent();
        }

        private void frmPurchasing_Activated(object sender, EventArgs e)
        {
            cboPurchaseOrder.DataSource = null;            
            cboPurchaseOrder.DataSource = GlobalListForTesting.totalPOList;
            


            if (this.Text == "Add New Purchases")
            {
                // sets input states to editable/visible
                cboPurchaseOrder.Visible = false;
                tbColor.Visible = true;
                lblColor.Visible = true;
                numMileage.Visible = true;
                lblMileage.Visible = true;
                numCost.Visible = true;
                lblCost.Visible = true;
                tbType.Visible = true;
                lblType.Visible = true;
                tbVIN.Visible = true;
                lblVIN.Visible = true;
                lblExpected.Visible = true;
                dtpLotArrival.Visible = true;
                dtpLotArrival.Value = DateTime.Now;

                numYear.Enabled = true;
                numYear.ReadOnly = false;
                tbMake.Enabled = true;
                tbMake.ReadOnly = false;
                tbModel.Enabled = true;
                tbModel.ReadOnly = false;
                tbColor.Enabled = true;
                tbColor.ReadOnly = false;
                numMileage.Enabled = true;
                numMileage.ReadOnly = false;
                tbType.Enabled = true;
                tbType.ReadOnly = false;
                tbVIN.Enabled = true;
                tbVIN.ReadOnly = false;

                btnInventoryDetail.Enabled = false;
                btnInventoryDetail.Visible = false;
                clearForm();
                btnAction.Text = "Add";
            }
            else if (this.Text == "Edit Purchases")
            {
                // sets appropriate inputs to editable/visible
                cboPurchaseOrder.Visible = true;

                tbColor.Visible = true;
                lblColor.Visible = true;
                numMileage.Visible = true;
                lblMileage.Visible = true;
                numCost.Visible = true;
                lblCost.Visible = true;
                tbType.Visible = true;
                lblType.Visible = true;
                tbVIN.Visible = true;
                lblVIN.Visible = true;
                lblExpected.Visible = true;
                dtpLotArrival.Visible = true;

                btnInventoryDetail.Enabled = false;
                btnInventoryDetail.Visible = false;

                btnAction.Text = "Save";
            }
            else if (this.Text == "Delete Purchases")
            {
                cboPurchaseOrder.Visible = true;
                btnAction.Text = "Delete";
            }
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (btnAction.Text == "Delete")
            {
                if (cboPurchaseOrder.SelectedIndex > -1) // ensures something is selected
                {
                    if (MessageBox.Show("Are you sure you want to delete purchase order " + cboPurchaseOrder.SelectedItem.ToString() + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clsPurchaseOrder.deletePurchaseOrder((cboPurchaseOrder.SelectedItem as clsPurchaseOrder).PurchaseOrderID);
                    }
                }
                cboPurchaseOrder.DataSource = null;
                cboPurchaseOrder.DataSource = clsPurchaseOrder.selectAllPurchaseOrders();
            }
            else if (btnAction.Text == "Add")
            /* Need better way to retrieve SalesOrderID from new sales order to assign to new inventory item */
            {
                bool isAvailable = false;
                clsPurchaseOrder.insertPurchaseOrder(new clsPurchaseOrder("",tbVIN.Text,tbSource.Text,tbAuthorizedBy.Text,numCost.Value,""));
                if (dtpLotArrival.Value >= DateTime.Now)
                {
                    isAvailable = false;
                }
                else
                {
                    isAvailable = true;
                }
                clsInventory.insertInventory(new clsInventory("", tbMake.Text, tbModel.Text, tbColor.Text, Convert.ToInt32(numYear.Value), 
                    Convert.ToInt32(numMileage.Value), dtpLotArrival.Value, numCost.Value, 0, tbType.Text, tbVIN.Text, "", "", "", isAvailable));
                MessageBox.Show("Vehicle added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                clearForm();
            }
            else if (btnAction.Text == "Save")
            {
                
                clsPurchaseOrder.insertPurchaseOrder(new clsPurchaseOrder("", tbVIN.Text, tbSource.Text, tbAuthorizedBy.Text, numCost.Value, ""));
                
                MessageBox.Show("Sales Order Updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                clearForm();
                cboPurchaseOrder.DataSource = null;
                cboPurchaseOrder.DataSource = GlobalListForTesting.totalPOList;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInventoryDetail_Click(object sender, EventArgs e)
        {
            if (cboPurchaseOrder.SelectedIndex > -1)
            {
                frmInventoryDetail frmDetail = new frmInventoryDetail();
                frmDetail.vehicleLoaded = clsInventory.searchInventory((cboPurchaseOrder.SelectedItem as clsPurchaseOrder).
                    InventoryID);
                showMdiChild(frmDetail, "Vehicle Detail");
            }
            else
            {
                MessageBox.Show("No Purchase Order Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CboPurchaseOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPurchaseOrder.SelectedIndex > -1)
            {
                numCost.Value = (cboPurchaseOrder.SelectedItem as clsPurchaseOrder).Cost;
                tbMake.Text = clsInventory.searchInventory((cboPurchaseOrder.SelectedItem as clsPurchaseOrder).InventoryID).Make;
                tbModel.Text = clsInventory.searchInventory((cboPurchaseOrder.SelectedItem as clsPurchaseOrder).InventoryID).Model;
                numYear.Value = clsInventory.searchInventory((cboPurchaseOrder.SelectedItem as clsPurchaseOrder).InventoryID).Year;
                numMileage.Value = clsInventory.searchInventory((cboPurchaseOrder.SelectedItem as clsPurchaseOrder).InventoryID).Mileage;
                tbColor.Text = clsInventory.searchInventory((cboPurchaseOrder.SelectedItem as clsPurchaseOrder).InventoryID).Color;
                tbVIN.Text = clsInventory.searchInventory((cboPurchaseOrder.SelectedItem as clsPurchaseOrder).InventoryID).Vin;
                tbType.Text = clsInventory.searchInventory((cboPurchaseOrder.SelectedItem as clsPurchaseOrder).InventoryID).BodyType;
            }
            

        }
    }
}
