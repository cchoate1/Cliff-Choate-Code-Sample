using System;
using System.Windows.Forms;

namespace CustomerResourceManagement
{
    public partial class frmNewSalesOrder : Form
    {
        public clsInventory vehicleLoaded { get; set; }

        public frmNewSalesOrder()
        {
            InitializeComponent();
        }

        private void FrmSalesOrder_Load(object sender, EventArgs e)
        {
           clsInventory vehicle = clsInventory.searchInventory(vehicleLoaded.InventoryID);
            tbMake.Text = vehicle.Make;
            tbColor.Text = vehicle.Color;
            tbModel.Text = vehicle.Model;
            numMileage.Value = vehicle.Mileage;
            tbVIN.Text = vehicle.Vin;
            numYear.Value = vehicle.Year;
            cboStatus.SelectedIndex = 4;
            //tbSalesperson.Text = [current user].FirstName + " " + [current user].LastName
            tbSalesperson.Text = "John P. Salesman";

            //Will load customer list from DB to combo box and display first name, last name

            btnSave.Enabled = false;
            

        }

       

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string errorMessage = "OK";
            
            
            if (numFinalPrice.Value > vehicleLoaded.CostPaid &&   // check for valid data
                dtpSaleDate.Value < dtpPickUp.Value && vehicleLoaded.Available == true)
            {
                // check for changes made by other user
                if (vehicleLoaded == clsInventory.searchInventory(vehicleLoaded.InventoryID))
                {
                    string SONumber = "";
                    string s = "SO" + DateTime.Now.ToString();

                    foreach (char c in s)
                    {
                        if (!char.IsPunctuation(c) && c != ' ' && c != 'A' && c != 'P' && c != 'M')
                            SONumber += c;
                    }

                    
                    clsSalesOrder.insertSalesOrder(new clsSalesOrder(SONumber, vehicleLoaded.InventoryID, "Customer", // customer and SO ID waiting for DB connection
                    numFinalPrice.Value, dtpSaleDate.Value, dtpPickUp.Value, tbSalesperson.Text, cboStatus.Text));

                    clsInventory.searchInventory(vehicleLoaded.InventoryID).Available = false;
                    
                    MessageBox.Show("Sales Order "+SONumber+"Created", "Sales Order Saved", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Another user has locked this vehicle.", "Sales Order Not Saved", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else // checks which error and sets message accordingly
            {
                
                if (numFinalPrice.Value < vehicleLoaded.CostPaid)
                {
                    errorMessage = "Final Price cannot be lower than initial cost";
                    numFinalPrice.Focus();
                }
                else if (dtpSaleDate.Value > dtpPickUp.Value)
                {
                    errorMessage = "Pick up date cannot be before sale date";
                    dtpPickUp.Focus();
                }
                else if (vehicleLoaded.Available == false)
                {
                    errorMessage = "Vehicle not available for sale.";
                    
                }
                MessageBox.Show(errorMessage, "Sales Order Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumFinalPrice_ValueChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void NumFinalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnSave.Enabled = true;
        }
    }
}
