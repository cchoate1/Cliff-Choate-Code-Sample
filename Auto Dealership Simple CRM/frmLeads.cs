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
    public partial class frmLeads : Form
    {

        private DBactionType dbActionType;
        private List<Lead> existingLeads;
        private DateTime defaultDateTime;

        //Updates the entries in cboLeads
        private void updateLeadList()
        {
            existingLeads = Lead.getRecords();
            cboLeads.Items.Clear();
            foreach (Lead lead in existingLeads)
            {
                cboLeads.Items.Add(lead.LeadId);
            }
        }

        public frmLeads()
        {
            InitializeComponent();
        }

        //Sets the readonly (or enabled) property of form fields. LeadId is always readonly
        private void setInputReadOnly(bool readOnly)
        {
            cboCustomer.Enabled = !readOnly;
            cboPriority.Enabled = !readOnly;
            numMinPrice.ReadOnly = readOnly;
            numMaxPrice.ReadOnly = readOnly;
            dtCreateDate.Enabled = !readOnly;
            dtExpirationDate.Enabled = !readOnly;
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
                    setInputReadOnly(false);
                    btnAction.Visible = true;
                    btnAction.Text = "Add";
                    break;

                case DBactionType.UPDATE:
                    setInputReadOnly(false);
                    btnAction.Visible = true;
                    btnAction.Text = "Save";
                    break;

                case DBactionType.DELETE:
                    setInputReadOnly(true);
                    btnAction.Visible = true;
                    btnAction.Text = "Delete";
                    break;

                case DBactionType.SELECT:
                    setInputReadOnly(true);
                    btnAction.Visible = false;
                    break;
            }
        }

        private void clearForm()
        {
            cboLeads.Text = "";
            tbLeadId.Text = "";
            cboCustomer.Text = "";
            cboPriority.Text = "";
            numMinPrice.Value = 0;
            numMaxPrice.Value = 0;
            dtCreateDate.Value = defaultDateTime;
            dtExpirationDate.Value = defaultDateTime;
        }

            private void frmLeads_Activated(object sender, EventArgs e)
        {
            if (this.Text == "Add New Leads")
            {
                dbActionType = DBactionType.INSERT;
            }
            else if (this.Text == "Edit Leads")
            {
                dbActionType = DBactionType.UPDATE;
            }
            else if (this.Text == "Delete Leads")
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
                updateLeadList();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboLeads_SelectedValueChanged(object sender, EventArgs e)
        {
            Lead lead = existingLeads[cboLeads.SelectedIndex];

            //TODO: replace with customer name
            cboCustomer.Text = lead.CustomerId;
            cboPriority.Text = lead.Priority.ToString();

            tbLeadId.Text = lead.LeadId;
            numMinPrice.Value = lead.MinPrice;
            numMaxPrice.Value = lead.MaxPrice;
            dtCreateDate.Value = lead.CreateDate;
            dtExpirationDate.Value = lead.ExpirationDate;
        }

        //Collects form data into a MaintanceOrder instance,
        //then takes the appropriate action based on formMode
        private void btnAction_Click(object sender, EventArgs e)
        {
            Lead lead = new Lead();

            //TODO: replace with customer name
            lead.CustomerId = cboCustomer.Text;
            lead.Priority = cboPriority.SelectedIndex + 1;

            lead.LeadId = tbLeadId.Text;
            lead.MinPrice = numMinPrice.Value;
            lead.MaxPrice = numMaxPrice.Value;
            lead.CreateDate = dtCreateDate.Value;
            lead.ExpirationDate = dtExpirationDate.Value;

            switch (dbActionType)
            {
                case DBactionType.INSERT:
                    lead.addRecord();
                    break;

                case DBactionType.UPDATE:
                    lead.updateRecord(lead.LeadId);
                    break;

                case DBactionType.DELETE:
                    lead.updateRecord(lead.LeadId);
                    break;
            }
        }
    }
}
