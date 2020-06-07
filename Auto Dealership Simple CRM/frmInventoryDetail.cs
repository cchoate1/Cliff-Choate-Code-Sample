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
    public partial class frmInventoryDetail : Form
    {
        private void showMdiChild(Form thisForm, string action)
        {
            thisForm.MdiParent = this.ParentForm;
            thisForm.Text = action;
            thisForm.WindowState = FormWindowState.Maximized;
            thisForm.Show();
        }

        public clsInventory vehicleLoaded { get; set; }
        public frmInventoryDetail()
        {
            InitializeComponent();
            
        }

        private void FrmInventoryDetail_Load(object sender, EventArgs e)
        {
            clsInventory vehicle = clsInventory.searchInventory(vehicleLoaded.InventoryID);
            tbMake.Text = vehicle.Make;
            tbColor.Text = vehicle.Color;
            tbModel.Text = vehicle.Model;
            tbMileage.Text = vehicle.Mileage.ToString();
            tbPrice.Text = vehicle.StickerPrice.ToString();
            tbPurchaseOrderID.Text = vehicle.PurchaseOrderID;
            tbSalespersonID.Text = vehicle.SalespersonID;
            tbType.Text = vehicle.BodyType;
            tbVIN.Text = vehicle.Vin;
            tbYear.Text = vehicle.Year.ToString();
            tbCustomerHold.Text = vehicle.CustomerHold;
            tbDealerCost.Text = vehicle.CostPaid.ToString();

            if (vehicle.Available == true)
            {
                tbAvailable.Text = "Available";
            }
            else
            {
                tbAvailable.Text = "Not Available";
            }


            tbTimeOnLot.Text = Convert.ToInt32((DateTime.Now - vehicle.ArrivedOnLot).TotalDays).ToString();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            if (vehicleLoaded.Available == true)
            {
                frmNewSalesOrder frmSO = new frmNewSalesOrder();
                frmSO.vehicleLoaded = vehicleLoaded;
                showMdiChild(frmSO, "Initiate Sale");
            }
            else
            {
                MessageBox.Show("Vehicle Not Available", "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnHold_Click(object sender, EventArgs e)
        {
            clsInventory vehicle = clsInventory.searchInventory(vehicleLoaded.InventoryID);
            if (btnHold.Text == "Add/Edit Hold")
            {
                tbCustomerHold.Enabled = true;
                tbCustomerHold.ReadOnly = false;
                btnHold.Text = "Save Hold";
            }
            else if (btnHold.Text == "Save Hold")
            {
                vehicle.CustomerHold = tbCustomerHold.Text;
                clsInventory.insertInventory(vehicle);
                btnHold.Text = "Add/Edit Hold";
                tbCustomerHold.Enabled = false;
                tbCustomerHold.ReadOnly = true;
            }
        }
    }
}
