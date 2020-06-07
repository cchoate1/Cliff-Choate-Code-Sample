using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerResourceManagement
{
    public partial class frmCRM : Form
    {
        public frmCRM()
        {
            InitializeComponent();
            // test data factory=============================================================//
                                                                                             //
            for (int i = 0; i < 10; i++)                                                     // 
            {                                                                                //
                GlobalListForTesting.totalInventoryList.Add(new clsInventory());             //
                GlobalListForTesting.totalInventoryList[i].InventoryID = "aaaa" + i;         //
            }                                                                                //  
            GlobalListForTesting.totalInventoryList[1].Make = "Buick";                       //
            GlobalListForTesting.totalInventoryList[1].Model = "LeSabre";                    //
                                                                                             //
                                                                                             //
            for (int i = 0; i < 10; i++)                                                     //
            {
                string testPoID = "1000000" + i;                                             //
                GlobalListForTesting.totalPOList.Add(new clsPurchaseOrder());                //
                GlobalListForTesting.totalPOList[i].PurchaseOrderID = testPoID;              //
                GlobalListForTesting.totalPOList[i].InventoryID = GlobalListForTesting.totalInventoryList[i].InventoryID;
                GlobalListForTesting.totalInventoryList[i].PurchaseOrderID = testPoID;
            }                                                                                //
                                                                                             //
            string testSoID = "1000000";                                                     //
            for (int i = 0; i < 10; i++)                                                     //
            {                                                                                //
                GlobalListForTesting.totalSOList.Add(new clsSalesOrder());                   //
                testSoID += i;                                                               //
                GlobalListForTesting.totalSOList[i].SalesOrderID = testSoID;                 //
                GlobalListForTesting.totalSOList[i].InventoryID = GlobalListForTesting.totalInventoryList[i].InventoryID;
                                                                                             //
            }   
            
            for (int i = 0; i < 10; i++)
            {
                string initial ="";
                initial += ((char)(i + 65));
                GlobalListForTesting.totalCustomerList.Add(new Customer(initial, "Smith", i + 2 + " Fake Street", "B",
                                    "Allentown", "PA", "18195", "(610) " + i + i + i + "-5555", (char)(i + 65) + "smith@hotmail.com",
                                    1, "None", 1000, 13000));
            }
                                                                                                //
            //===============================================================================//
        }


        private void mnuNewCustomers_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.CUSTOMER_NEW);        
        }


        private object GetForm(int childForm)
        {
            Form retForm = null;   
            switch (childForm)
            {
                case 1:
                    retForm = new frmCustomer();
                    break;
                case 2:
                    retForm = new frmCustomer();
                    break;
                default:
                    break;
            }

            return retForm;
        }

        private void showChildForm(FormType childForm)
        {
            String frmAction = GetFormAction(childForm);

            bool bIsFormOpen = false;
            //Form formToShow = GetForm(childForm);
            foreach (Form frm in Application.OpenForms)
            {

                if (frm.Text == frmAction)
                {
                    bIsFormOpen = true;
                    frm.Focus();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    break;
                }
            }

            if (bIsFormOpen == false)
            {
                ShowNewChildForm(childForm);

            }
        }

        private String GetFormAction(FormType childForm)
        {
            switch (childForm)
            {
                case FormType.CUSTOMER_NEW:
                    return "Add New Customers";

                case FormType.CUSTOMER_EDIT:
                    return "Edit Customers";

                case FormType.CUSTOMER_DELETE:
                    return "Delete Customers";

                case FormType.CUSTOMER_SEARCH:
                    return "Search Customers";

                case FormType.EMPLOYEE_NEW:
                    return "Add New Employees";

                case FormType.EMPLOYEE_EDIT:
                    return "Edit Employees";

                case FormType.EMPLOYEE_DELETE:
                    return "Delete Employees";

                case FormType.EMPLOYEE_SEARCH:
                    return "Seach Employees";

                case FormType.LEADS_NEW:
                    return "Add New Leads";

                case FormType.LEADS_EDIT:
                    return "Edit Leads";

                case FormType.LEADS_DELETE:
                    return "Delete Leads";

                case FormType.LEADS_SEARCH:
                    return "Search Leads";

                case FormType.INVENTORY_NEW:
                    return "Add New Inventory";

                case FormType.INVENTORY_EDIT:
                    return "Edit Inventory";

                case FormType.INVENTORY_DELETE:
                    return "Delete Inventory";

                case FormType.INVENTORY_SEARCH:
                    return "Search Inventory";

                case FormType.MAINTENANCE_NEW:
                    return "Add New Maintenance Orders";

                case FormType.MAINTENANCE_EDIT:
                    return "Edit Maintenance Orders";

                case FormType.MAINTENANCE_DELETE:
                    return "Delete Maintenance Orders";

                case FormType.MAINTENANCE_SEARCH:
                    return "Search Maintenance Orders";

                case FormType.PURCHASES_NEW:
                    return "Add New Purchases";

                case FormType.PURCHASES_EDIT:
                    return "Edit Purchases";

                case FormType.PURCHASES_DELETE:
                    return "Delete Purchases";

                case FormType.PURCHASES_SEARCH:
                    return "Search Purchases";

                default:
                    return "----";
            }
            
        }
        private DBactionType GetDbAction(FormType childForm)
        {
            switch (childForm)
            {
                case FormType.CUSTOMER_NEW:
                case FormType.EMPLOYEE_NEW:
                case FormType.LEADS_NEW:
                case FormType.MAINTENANCE_NEW:
                case FormType.PURCHASES_NEW:
                    {
                        return DBactionType.INSERT;
                    }

                case FormType.CUSTOMER_EDIT:
                case FormType.EMPLOYEE_EDIT:
                case FormType.LEADS_EDIT:
                case FormType.MAINTENANCE_EDIT:
                case FormType.PURCHASES_EDIT:
                    {
                        return DBactionType.UPDATE;
                    }

                case FormType.CUSTOMER_DELETE:
                case FormType.EMPLOYEE_DELETE:
                case FormType.LEADS_DELETE:
                case FormType.MAINTENANCE_DELETE:
                case FormType.PURCHASES_DELETE:
                    {
                        return DBactionType.DELETE;
                    }

                case FormType.CUSTOMER_SEARCH:
                case FormType.EMPLOYEE_SEARCH:
                case FormType.LEADS_SEARCH:
                case FormType.MAINTENANCE_SEARCH:
                case FormType.PURCHASES_SEARCH:
                    {
                        return DBactionType.SELECT;
                    }

                default:
                    return DBactionType.UNKNOWN;

            }

        }

        private void ShowNewChildForm(FormType childForm)
        {
            String frmAction = GetFormAction(childForm);
            DBactionType dbAction = GetDbAction(childForm);
            switch (childForm)
            {
                case FormType.CUSTOMER_NEW:
                    frmCustomer frmCustNew = new frmCustomer();
                    ShowMDIChild(frmCustNew, frmAction, dbAction);
                    break;
                case FormType.CUSTOMER_EDIT:
                    frmCustomer frmCustEdit = new frmCustomer();
                    ShowMDIChild(frmCustEdit, frmAction, dbAction);
                    break;
                case FormType.CUSTOMER_DELETE:
                    frmCustomer frmCustDelete = new frmCustomer();
                    ShowMDIChild(frmCustDelete, frmAction, dbAction);
                    break;
                case FormType.CUSTOMER_SEARCH:
                    frmCustomer frmCustSearch = new frmCustomer();
                    ShowMDIChild(frmCustSearch, frmAction, dbAction);
                    break;
                case FormType.EMPLOYEE_NEW:
                    frmCustomer frmEmplNew = new frmCustomer();
                    ShowMDIChild(frmEmplNew, frmAction, dbAction);
                    break;
                case FormType.EMPLOYEE_EDIT:
                    frmCustomer frmEmplEdit = new frmCustomer();
                    ShowMDIChild(frmEmplEdit, frmAction, dbAction);
                    break;
                case FormType.EMPLOYEE_DELETE:
                    frmCustomer frmEmplDelete = new frmCustomer();
                    ShowMDIChild(frmEmplDelete, frmAction, dbAction);
                    break;
                case FormType.EMPLOYEE_SEARCH:
                    frmCustomer frmEmplSearch = new frmCustomer();
                    ShowMDIChild(frmEmplSearch, frmAction, dbAction);
                    break;
                case FormType.LEADS_NEW:
                    frmLeads frmLeadsNew = new frmLeads();
                    ShowMDIChild(frmLeadsNew, frmAction, dbAction);
                    break;
                case FormType.LEADS_EDIT:
                    frmLeads frmLeadsEdit = new frmLeads();
                    ShowMDIChild(frmLeadsEdit, frmAction, dbAction);
                    break;
                case FormType.LEADS_DELETE:
                    frmLeads frmLeadsDelete = new frmLeads();
                    ShowMDIChild(frmLeadsDelete, frmAction, dbAction);
                    break;
                case FormType.LEADS_SEARCH:
                    frmLeads frmLeadsSearch = new frmLeads();
                    ShowMDIChild(frmLeadsSearch, frmAction, dbAction);
                    break;
                case FormType.INVENTORY_NEW:
                    frmInventory frmInvNew = new frmInventory();
                    ShowMDIChild(frmInvNew, frmAction, dbAction);
                    break;
                case FormType.INVENTORY_EDIT:
                    frmInventory frmInvEdit = new frmInventory();
                    ShowMDIChild(frmInvEdit, frmAction, dbAction);
                    break;
                case FormType.INVENTORY_DELETE:
                    frmInventory frmInvDelete = new frmInventory();
                    ShowMDIChild(frmInvDelete, frmAction, dbAction);
                    break;
                case FormType.INVENTORY_SEARCH:
                    frmInventory frmInvSearch = new frmInventory();
                    ShowMDIChild(frmInvSearch, frmAction, dbAction);
                    break;
                case FormType.MAINTENANCE_NEW:
                    frmMaintenanceOrders frmMaintNew = new frmMaintenanceOrders();
                    ShowMDIChild(frmMaintNew, frmAction, dbAction);
                    break;
                case FormType.MAINTENANCE_EDIT:
                    frmMaintenanceOrders frmMaintEdit = new frmMaintenanceOrders();
                    ShowMDIChild(frmMaintEdit, frmAction, dbAction);
                    break;
                case FormType.MAINTENANCE_DELETE:
                    frmMaintenanceOrders frmMaintDelete = new frmMaintenanceOrders();
                    ShowMDIChild(frmMaintDelete, frmAction, dbAction);
                    break;
                case FormType.MAINTENANCE_SEARCH:
                    frmMaintenanceOrders frmMaintSearch = new frmMaintenanceOrders();
                    ShowMDIChild(frmMaintSearch, frmAction, dbAction);
                    break;
                case FormType.PURCHASES_NEW:
                    frmPurchasing frmNewPurchases = new frmPurchasing();
                    ShowMDIChild(frmNewPurchases, frmAction, dbAction);
                    break;
                case FormType.PURCHASES_EDIT:
                    frmPurchasing frmEditPurchases = new frmPurchasing();
                    ShowMDIChild(frmEditPurchases, frmAction, dbAction);
                    break;
                case FormType.PURCHASES_DELETE:
                    frmPurchasing frmDeletePurchases = new frmPurchasing();
                    ShowMDIChild(frmDeletePurchases, frmAction, dbAction);
                    break;
                case FormType.PURCHASES_SEARCH:
                    frmPurchasing frmSearchPurchases = new frmPurchasing();
                    ShowMDIChild(frmSearchPurchases, frmAction, dbAction);
                    break;
                default:
                    break;
            }
        }

        private void ShowMDIChild(Form thisForm, string action, DBactionType dbAction)
        {
            thisForm.MdiParent = this;
            thisForm.Text = action;
            thisForm.Tag = dbAction;
            thisForm.WindowState = FormWindowState.Maximized;
            thisForm.Show();
        }
        private void mnuDeleteCustomers_Click(object sender, EventArgs e)
        {

            showChildForm(FormType.CUSTOMER_DELETE);
        }

        private void mnuEditCustomers_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.CUSTOMER_EDIT);
        }

        private void frmCRM_Load(object sender, EventArgs e)
        {

        }

        private void mnuNewEmployees_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.EMPLOYEE_NEW);
        }

        private void mnuSearchCustomers_Click(object sender, EventArgs e)
        {

        }

        private void mnuEditEmployees_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.EMPLOYEE_EDIT);
        }

        private void mnuDeleteEmployees_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.EMPLOYEE_DELETE);
        }

        private void mnuSearchEmployees_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.EMPLOYEE_SEARCH);
        }

        private void mnuNewLeads_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.LEADS_NEW);
        }

        private void mnuEditLeads_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.LEADS_EDIT);
        }

        private void mnuDeleteLeads_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.LEADS_DELETE);
        }

        private void mnuSearchLeads_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.LEADS_SEARCH);
        }

        private void mnuNewInventory_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.INVENTORY_NEW);
        }

        private void mnuEditInventory_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.INVENTORY_EDIT);
        }

        private void mnuDeleteInventory_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.INVENTORY_DELETE);

        }

        private void mnuSearchInventory_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.INVENTORY_SEARCH);

        }

        private void mnuNewMainOrder_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.MAINTENANCE_NEW);
        }

        private void mnuEditMainOrder_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.MAINTENANCE_EDIT);
        }

        private void mnuDeleteMainOrder_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.MAINTENANCE_DELETE);
        }

        private void mnuSearchMainOrder_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.MAINTENANCE_SEARCH);
        }

        private void mnuNewPurchases_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.PURCHASES_NEW);
        }

        private void mnuEditPurchases_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.PURCHASES_EDIT);

        }

        private void mnuDeletetePurchases_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.PURCHASES_DELETE);
        }

        private void mnuSearchPurchases_Click(object sender, EventArgs e)
        {
            showChildForm(FormType.PURCHASES_SEARCH);
        }
    }




}
