using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerResourceManagement
{
    public partial class frmCustomer : Form
    {

        /* ...............................................
         * ....Customer Objects for each database action 
         *                                              */
        // New Customer
        internal Customer newCustomer = new Customer();

        // Update Customer
        internal Customer updCustomer = new Customer();

        // Delete Customer
        internal Customer delCustomer = new Customer();

        // Select Customer
        internal Customer selCustomer = new Customer();

        public frmCustomer()
        {
            InitializeComponent();
        }

        /*....................................................
        .........* ....Form Load Event
        .........*                                          */
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadCustomerComboBox();
            LoadPreferredContactComboBox();
            //cboCustomer.SelectedIndex = 0;
        }
        /*............................................
         *....... Form Activated Event
         *                                          */
        private void frmCustomer_Activated(object sender, EventArgs e)
        {
            //....Check Form Tag For Database Action
            //.......INSERT

            //----For screenshots
            cboCustomer.DataSource = null;
            cboCustomer.DataSource = GlobalListForTesting.totalCustomerList;
            //-------------------

            if (this.Tag.ToString() == DBactionType.INSERT.ToString())
            {
                cboCustomer.Visible = false;
                btnAction.Text = "Add";
                newCustomer.DBAction = DBactionType.INSERT;
            }
            //.......UPDATE
            else if (this.Tag.ToString() == DBactionType.UPDATE.ToString())
            {
                cboCustomer.Visible = true;
                btnAction.Text = "Save";
                Customer updCustomer = new Customer();
                updCustomer.DBAction = DBactionType.UPDATE;
            }
            //.......DELETE
            else if (this.Tag.ToString() == DBactionType.DELETE.ToString())
            {
                cboCustomer.Visible = true;
                btnAction.Text = "Delete";
                Customer delCustomer = new Customer();
                delCustomer.DBAction = DBactionType.DELETE;
            }
            //.......SELECT
            else if (this.Tag.ToString() == DBactionType.SELECT.ToString())
            {
                cboCustomer.Visible = true;
                btnAction.Text = "Delete";
                Customer delCustomer = new Customer();
                delCustomer.DBAction = DBactionType.DELETE;
            }
            else
            {
                throw new CrmErrors(string.Format("Ivalid DbAction {0}", this.Tag));
            }
        }

        /*............................................
        *....... Load Combo Boxes
        *                                          */
        private void LoadPreferredContactComboBox()
        {
            this.cboPreferredContact.Items.Add("Employee 1");
            this.cboPreferredContact.Items.Add("Employee 2");

        }
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            ClearTextBox(this.txtFirstName);
            ClearTextBox(this.txtLastName);
            ClearTextBox(this.txtAddress1);
            ClearTextBox(this.txtAddress2);
            ClearTextBox(this.txtCity);
            ClearMaskedTextBox(this.txtState);
            ClearMaskedTextBox(this.txtZipCode);
            ClearUpDown(this.nudMinPrice);
            ClearUpDown(this.nudMaxPrice);
            ClearMaskedTextBox(this.txtPhone);
            ClearMaskedTextBox(this.txtEmail);
            ClearComboBox(this.cboCustomer);
            ClearComboBox(this.cboPreferredContact);
            ClearRichText(this.rtfInterests);
        }

        // Clear Text Boxes Method
        private void ClearTextBox(TextBox tb)
        {
            tb.Text = "";
            tb.Visible = true;
            tb.Enabled = true;
            tb.ReadOnly = false;
        }
        // CLear Combo Boxed Method
        private void ClearComboBox(ComboBox cb)
        {
            cb.Enabled = true;
            cb.SelectedIndex = -1;
            cb.Visible = true;
        }
        // Clear Rich Text Boxes
        private void ClearRichText(RichTextBox rt)
        {
            rt.Text = "";
            rt.Enabled = true;
            rt.Visible = true;
            rt.ReadOnly = false;
        }
        // Clear Maxked Text Boxes
        private void ClearMaskedTextBox(MaskedTextBox mtb)
        {
            mtb.Text = "";
            mtb.ReadOnly = false;
            mtb.Visible = true;
            mtb.Enabled = true;
        }
        // Clear Numeric Up/Down Boxes
        private void ClearUpDown(NumericUpDown nud)
        {
            nud.ResetText();
            nud.Value = 0;
            nud.ReadOnly = false;
            nud.Visible = true;
            nud.Enabled = true;
        }


        /*.......................................
         * .....Control Leave Events
         *                                   */
        // First Name Textbox
        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            newCustomer.FirstName = this.txtFirstName.Text;
        }
        // Last Name Textbox

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            newCustomer.LastName = this.txtLastName.Text;
        }

        // Address1 Textbox
        private void txtAddress1_Leave(object sender, EventArgs e)
        {
            newCustomer.Address1 = this.txtAddress1.Text;
        }
        // Address2 Textbox
        private void txtAddress2_Leave(object sender, EventArgs e)
        {
            newCustomer.Address2 = this.txtAddress2.Text;
        }

        // City Textbox
        private void txtCity_Leave(object sender, EventArgs e)
        {
            newCustomer.City = this.txtCity.Text;
        }

        // State Textbox
        private void txtState_Leave(object sender, EventArgs e)
        {
            newCustomer.State = this.txtState.Text;
        }

        // Phone Textbox
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            newCustomer.Phone = this.txtPhone.Text;
        }

        // Email Textbox
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            newCustomer.Email = this.txtEmail.Text;
        }

        // Minimum Price Textbox
        private void nudMinPrice_Leave(object sender, EventArgs e)
        {
            newCustomer.MinPrice = nudMinPrice.Value;
        }

        // Maximum Price Textbox
        private void nudMaxPrice_ValueChanged(object sender, EventArgs e)
        {
            newCustomer.MaxPrice =nudMaxPrice.Value;
        }

        // Interests Rich Textbox
        private void rtfInterests_Leave(object sender, EventArgs e)
        {
            newCustomer.Interests = this.rtfInterests.Rtf;
        }

        private void txtMaxPrice_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            //this.txtMaxPrice.Text = "";
            //MessageBox.Show("Maximum pice must be numeric.");
        }



        // Zip Code Text Box (Masked)
        private void txtZipCode_Leave(object sender, EventArgs e)
        {
            newCustomer.ZipCode = this.txtZipCode.Text;
        }

        // Preferred Contact Combo Box
        private void cboPreferredContact_Leave(object sender, EventArgs e)
        {
            //ComboBox cmb = (ComboBox)sender;
            //int selectedIndex = cmb.SelectedIndex;
            //int selectedValue = (int)cmb.SelectedValue;            
            // newCustomer.PreferredContactID = cboPreferredContact.SelectedValue;
        }

        /*.............................................
         * ....Combo Boxes Selected Value Changed Event
         *                                          */
        private void cboPreferredContact_SelectedValueChanged(object sender, EventArgs e)
        {
            //ComboBox cmb = (ComboBox)sender;
            //int selectedIndex = cmb.SelectedIndex;
            //int selectedValue = (int)cmb.SelectedValue;
        }

        private void LoadCustomerComboBox()
        {
            //  this.uspFillCustomerComboBoxTableAdapter.Fill(this.f.uspFillCustomerComboBox);
        }
        /*...........................................
         *.... Button Event Handlers
         *                                           */

        //....Action Button Click Event
        //      The Action button text changes depending on the database 
        //      action of the form (INSERT, UPDATE, DELETE, or SELECT

        private void btnAction_Click(object sender, EventArgs e)
        {
            switch ((int)this.Tag)
            {
                //....INSERT action requested
                //      1. Instantiate an instance of the CRM Database Object (CrmDb)
                //      2. Populate the database parameters (KVP) for the insert
                //         The CRM Database Object includes a Dictionary<TKey,TValue> Class
                //         Object created when the object is created.
                //         for an INSERT, all columns on the form are included, and include 
                //         NULL or Empty values for empty form fields.
                case (int)DbAction.INSERT:
                    {
                        CrmDb crmDB = new CrmDb();

                        crmDB.InsertCustomer(newCustomer);
                        break;
                    }
                //....UPDATE action requested
                //      1. Instantiate an instance of the CRM Database Object (CrmDb)
                //      2. Populate the database parameters (KVP) for the update.
                //         The CRM Database Object includes a Dictionary<TKey,TValue> Class
                //         Object created when the object is created
                case (int)DbAction.UPDATE:
                    {

                        break;
                    }
                case (int)DbAction.DELETE:
                    {


                        break;
                    }
                case (int)DbAction.SELECT:
                    {


                        break;
                    }
                default:
                    {
                        throw new CrmErrors(string.Format("Invalid DbAction {0}", this.Tag));
                    }
            }
        }

        //.... Clear Button Click Event
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        /*.............................................
         * .... Fill Form (from Customer Object)
         *                                            */
        private void FillForm()
        {
            
        }

        private void CboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFirstName.Text = (cboCustomer.SelectedItem as Customer).FirstName;
            txtLastName.Text = (cboCustomer.SelectedItem as Customer).LastName;
            txtAddress1.Text = (cboCustomer.SelectedItem as Customer).Address1;
            txtAddress2.Text = (cboCustomer.SelectedItem as Customer).Address2;
            txtCity.Text = (cboCustomer.SelectedItem as Customer).City;
            txtState.Text = (cboCustomer.SelectedItem as Customer).State;
            txtZipCode.Text = (cboCustomer.SelectedItem as Customer).ZipCode;
            txtEmail.Text = (cboCustomer.SelectedItem as Customer).Email;
            txtPhone.Text = (cboCustomer.SelectedItem as Customer).Phone;
            nudMaxPrice.Value = (cboCustomer.SelectedItem as Customer).MaxPrice;
            nudMinPrice.Value = (cboCustomer.SelectedItem as Customer).MinPrice;
            cboPreferredContact.SelectedIndex = 0;
        }

        //private Customer FillCustomer()
        //{


        //    //return custOut;
        //}

    }
}
