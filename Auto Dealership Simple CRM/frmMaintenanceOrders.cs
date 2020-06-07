using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
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
    public partial class frmMaintenanceOrders : Form
    {
        private DBactionType dbActionType;
        private List<MaintenanceOrder> existingOrders;
        private DateTime defaultDateTime;

        private void updateExistingOrders()
        {
            existingOrders = MaintenanceOrder.getRecords();
        }

        //Populates cboMaintenanceOrders with information from existingOrders
        //What information depends on which of the three radio buttons is selected
        private void populateOrderList()
        {
            cboMaintenanceOrders.Items.Clear();
            
            foreach (MaintenanceOrder order in existingOrders)
            {
                if (rdByWorkOrderNo.Checked)
                {
                    cboMaintenanceOrders.Items.Add(order.WorkOrderNum);
                } 
                else if (rdByVehicle.Checked) 
                {
                    //TODO: replace with vehicle name
                    cboMaintenanceOrders.Items.Add(order.InventoryId);
                }
                else
                {
                    //TODO: replace with customer name
                    cboMaintenanceOrders.Items.Add(order.CustomerId);
                }
            }
        }

        public frmMaintenanceOrders()
        {
            InitializeComponent();
        }

        // Sets the visible property of components related to Maintenance Order selection (chiefly cboMaintenanceOrders)
        private void setSearchOptionsVisible(bool visible)
        {
            cboMaintenanceOrders.Visible = visible;
            lblSearchBy.Visible = visible;
            rdByCustomer.Visible = visible;
            rdByVehicle.Visible = visible;
            rdByWorkOrderNo.Visible = visible;
        }

        //Sets the readonly (or enabled) property of form fields. WorkOrderNum is always readonly
        private void setInputReadOnly(bool readOnly)
        {
            cboCustomer.Enabled = !readOnly;
            cboVehicle.Enabled = !readOnly;
            tbCompletionStatus.ReadOnly = readOnly;
            taWorkDescription.ReadOnly = readOnly;
            numEstPartCost.ReadOnly = readOnly;
            numActualPartCost.ReadOnly = readOnly;
            numEstLaborCost.ReadOnly = readOnly;
            numActualLaborCost.ReadOnly = readOnly;
            dtArrivalDate.Enabled = !readOnly;
            dtEstCompletionDate.Enabled = !readOnly;
            dtActualCompletionDate.Enabled = !readOnly;
        }

        /*
         * Controls the visibility, read-only, and text properties of form components based on
         * the FormMode
        */
        private void controlComponents()
        {
            switch (dbActionType)
            {
                case DBactionType.INSERT:
                    setSearchOptionsVisible(false);
                    setInputReadOnly(false);
                    btnAction.Visible = true;
                    btnAction.Text = "Add";
                    break;

                case DBactionType.UPDATE:
                    setSearchOptionsVisible(true);
                    setInputReadOnly(false);
                    btnAction.Visible = true;
                    btnAction.Text = "Save";
                    break;

                case DBactionType.DELETE:
                    setSearchOptionsVisible(true);
                    setInputReadOnly(true);
                    btnAction.Visible = true;
                    btnAction.Text = "Delete";
                    break;

                case DBactionType.SELECT:
                    setSearchOptionsVisible(true);
                    setInputReadOnly(true);
                    btnAction.Visible = false;
                    break;
            }
        }

        private void clearForm()
        {
            cboMaintenanceOrders.Text = "";
            tbWorkOrderNum.Text = "";
            cboCustomer.Text = "";
            cboVehicle.Text = "";
            tbCompletionStatus.Text = "";
            taWorkDescription.Text = "";
            numEstPartCost.Value = 0;
            numActualPartCost.Value = 0;
            numEstLaborCost.Value = 0;
            numActualPartCost.Value = 0;

            dtArrivalDate.Value = defaultDateTime;
            dtEstCompletionDate.Value = defaultDateTime;
            dtActualCompletionDate.Value = defaultDateTime;
        }

        //Called as form loads
        private void frmServiceRequests_Activated(object sender, EventArgs e)
        {
            if (this.Text == "Add New Maintenance Orders")
            {
                dbActionType = DBactionType.INSERT;
            }
            else if (this.Text == "Edit Maintenance Orders")
            {
                dbActionType = DBactionType.UPDATE;
            }
            else if (this.Text == "Delete Maintenance Orders")
            {
                dbActionType = DBactionType.DELETE;
            }
            else
            {
                dbActionType = DBactionType.SELECT;
            }

            defaultDateTime = DateTime.Now;

            controlComponents();

            if (dbActionType != DBactionType.INSERT)
            {
                updateExistingOrders();
                populateOrderList();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //CheckedChanged handler for all radio buttons
        private void radioButton_checkedChanged(object sender, EventArgs e)
        {
            clearForm();
            populateOrderList();
        }

        //Populates form fields with the selected order's data
        private void cboMaintenanceOrders_SelectedValueChanged(object sender, EventArgs e)
        {
            MaintenanceOrder order = existingOrders[cboMaintenanceOrders.SelectedIndex];

            
            
            //TODO: replace with customer name and vehicle make/model
            cboCustomer.Text = order.CustomerId;
            cboVehicle.Text = order.InventoryId;

            tbWorkOrderNum.Text = order.WorkOrderNum;
            tbCompletionStatus.Text = order.CompletionStatus;
            taWorkDescription.Text = order.WorkDescription;
            numEstPartCost.Value = order.PartsEstimate;
            numActualPartCost.Value = order.PartsActual;
            numEstLaborCost.Value = order.LaborEstimate;
            numActualLaborCost.Value = order.LaborActual;
            dtArrivalDate.Value = order.ArrivalDate;
            dtEstCompletionDate.Value = order.EstimatedCompletionDate;
            dtActualCompletionDate.Value = order.ActualCompletionDate;
        }

        //Collects form data into a MaintanceOrder instance,
        //then takes the appropriate action based on formMode
        private void btnAction_Click(object sender, EventArgs e)
        {
            MaintenanceOrder order = new MaintenanceOrder();

            //TODO: replace with actual id
            order.CustomerId = cboCustomer.Text;
            order.InventoryId = cboVehicle.Text;
            
            order.WorkOrderNum = tbWorkOrderNum.Text;
            order.CompletionStatus = tbCompletionStatus.Text;
            order.WorkDescription = taWorkDescription.Text;
            order.PartsEstimate = numEstPartCost.Value;
            order.PartsActual = numActualPartCost.Value;
            order.LaborEstimate = numEstLaborCost.Value;
            order.LaborActual = numActualLaborCost.Value;
            order.ArrivalDate = dtArrivalDate.Value;
            order.EstimatedCompletionDate = dtEstCompletionDate.Value;
            order.ActualCompletionDate = dtActualCompletionDate.Value;
    
            switch (dbActionType)
            {
                case DBactionType.INSERT:
                    order.addRecord();
                    break;

                case DBactionType.UPDATE:
                    order.updateRecord(order.WorkOrderNum);
                    break;

                case DBactionType.DELETE:
                    order.updateRecord(order.WorkOrderNum);
                    break;
            }
        }
    }
}
