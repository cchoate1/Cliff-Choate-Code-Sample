namespace CustomerResourceManagement
{
    partial class frmCRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuCRM = new System.Windows.Forms.MenuStrip();
            this.leadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLeadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditLeadm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteLead = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchLeads = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceOrdrersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewMainOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditMainOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteMainOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchMainOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteCustomerss = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewPurchases = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditPurchases = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeletetePurchases = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchPurchases = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCRM.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuCRM
            // 
            this.mnuCRM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leadsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.maintenanceOrdrersToolStripMenuItem,
            this.mnuCustomer,
            this.employeesToolStripMenuItem,
            this.purchasingToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.mnuCRM.Location = new System.Drawing.Point(0, 0);
            this.mnuCRM.Name = "mnuCRM";
            this.mnuCRM.Size = new System.Drawing.Size(779, 24);
            this.mnuCRM.TabIndex = 1;
            this.mnuCRM.Text = "menuStrip1";
            // 
            // leadsToolStripMenuItem
            // 
            this.leadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLeadToolStripMenuItem,
            this.mnuEditLeadm,
            this.mnuDeleteLead,
            this.mnuSearchLeads});
            this.leadsToolStripMenuItem.Name = "leadsToolStripMenuItem";
            this.leadsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.leadsToolStripMenuItem.Text = "Leads";
            // 
            // newLeadToolStripMenuItem
            // 
            this.newLeadToolStripMenuItem.Name = "newLeadToolStripMenuItem";
            this.newLeadToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.newLeadToolStripMenuItem.Text = "New Lead";
            this.newLeadToolStripMenuItem.Click += new System.EventHandler(this.mnuNewLeads_Click);
            // 
            // mnuEditLeadm
            // 
            this.mnuEditLeadm.Name = "mnuEditLeadm";
            this.mnuEditLeadm.Size = new System.Drawing.Size(166, 22);
            this.mnuEditLeadm.Text = "Edit Lead";
            this.mnuEditLeadm.Click += new System.EventHandler(this.mnuEditLeads_Click);
            // 
            // mnuDeleteLead
            // 
            this.mnuDeleteLead.Name = "mnuDeleteLead";
            this.mnuDeleteLead.Size = new System.Drawing.Size(166, 22);
            this.mnuDeleteLead.Text = "Delete Lead";
            this.mnuDeleteLead.Click += new System.EventHandler(this.mnuDeleteLeads_Click);
            // 
            // mnuSearchLeads
            // 
            this.mnuSearchLeads.Name = "mnuSearchLeads";
            this.mnuSearchLeads.Size = new System.Drawing.Size(166, 22);
            this.mnuSearchLeads.Text = "List / Search Lead";
            this.mnuSearchLeads.Click += new System.EventHandler(this.mnuSearchLeads_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.mnuEditInventory,
            this.mnuDeleteInventory,
            this.mnuSearchInventory});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.addToolStripMenuItem1.Text = "New Inventory";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.mnuNewInventory_Click);
            // 
            // mnuEditInventory
            // 
            this.mnuEditInventory.Name = "mnuEditInventory";
            this.mnuEditInventory.Size = new System.Drawing.Size(191, 22);
            this.mnuEditInventory.Text = "Edit Inventory";
            this.mnuEditInventory.Click += new System.EventHandler(this.mnuEditInventory_Click);
            // 
            // mnuDeleteInventory
            // 
            this.mnuDeleteInventory.Name = "mnuDeleteInventory";
            this.mnuDeleteInventory.Size = new System.Drawing.Size(191, 22);
            this.mnuDeleteInventory.Text = "Delete Inventory";
            this.mnuDeleteInventory.Click += new System.EventHandler(this.mnuDeleteInventory_Click);
            // 
            // mnuSearchInventory
            // 
            this.mnuSearchInventory.Name = "mnuSearchInventory";
            this.mnuSearchInventory.Size = new System.Drawing.Size(191, 22);
            this.mnuSearchInventory.Text = "List / Search Inventory";
            this.mnuSearchInventory.Click += new System.EventHandler(this.mnuSearchInventory_Click);
            // 
            // maintenanceOrdrersToolStripMenuItem
            // 
            this.maintenanceOrdrersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewMainOrder,
            this.mnuEditMainOrder,
            this.mnuDeleteMainOrder,
            this.mnuSearchMainOrder});
            this.maintenanceOrdrersToolStripMenuItem.Name = "maintenanceOrdrersToolStripMenuItem";
            this.maintenanceOrdrersToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.maintenanceOrdrersToolStripMenuItem.Text = "Maintenance Ordrers";
            // 
            // mnuNewMainOrder
            // 
            this.mnuNewMainOrder.Name = "mnuNewMainOrder";
            this.mnuNewMainOrder.Size = new System.Drawing.Size(244, 22);
            this.mnuNewMainOrder.Text = "New Maintenance Orders";
            this.mnuNewMainOrder.Click += new System.EventHandler(this.mnuNewMainOrder_Click);
            // 
            // mnuEditMainOrder
            // 
            this.mnuEditMainOrder.Name = "mnuEditMainOrder";
            this.mnuEditMainOrder.Size = new System.Drawing.Size(244, 22);
            this.mnuEditMainOrder.Text = "Edit Maintenance Orders";
            this.mnuEditMainOrder.Click += new System.EventHandler(this.mnuEditMainOrder_Click);
            // 
            // mnuDeleteMainOrder
            // 
            this.mnuDeleteMainOrder.Name = "mnuDeleteMainOrder";
            this.mnuDeleteMainOrder.Size = new System.Drawing.Size(244, 22);
            this.mnuDeleteMainOrder.Text = "Delete Maintenance Orders";
            this.mnuDeleteMainOrder.Click += new System.EventHandler(this.mnuDeleteMainOrder_Click);
            // 
            // mnuSearchMainOrder
            // 
            this.mnuSearchMainOrder.Name = "mnuSearchMainOrder";
            this.mnuSearchMainOrder.Size = new System.Drawing.Size(244, 22);
            this.mnuSearchMainOrder.Text = "List / Seach Maintenance Orders";
            this.mnuSearchMainOrder.Click += new System.EventHandler(this.mnuSearchMainOrder_Click);
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewCustomers,
            this.mnuEditCustomers,
            this.mnuDeleteCustomerss,
            this.mnuSearchCustomers});
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(76, 20);
            this.mnuCustomer.Text = "Customers";
            // 
            // mnuNewCustomers
            // 
            this.mnuNewCustomers.Name = "mnuNewCustomers";
            this.mnuNewCustomers.Size = new System.Drawing.Size(198, 22);
            this.mnuNewCustomers.Text = "New Customers";
            this.mnuNewCustomers.Click += new System.EventHandler(this.mnuNewCustomers_Click);
            // 
            // mnuEditCustomers
            // 
            this.mnuEditCustomers.Name = "mnuEditCustomers";
            this.mnuEditCustomers.Size = new System.Drawing.Size(198, 22);
            this.mnuEditCustomers.Text = "Edit Customers";
            this.mnuEditCustomers.Click += new System.EventHandler(this.mnuEditCustomers_Click);
            // 
            // mnuDeleteCustomerss
            // 
            this.mnuDeleteCustomerss.Name = "mnuDeleteCustomerss";
            this.mnuDeleteCustomerss.Size = new System.Drawing.Size(198, 22);
            this.mnuDeleteCustomerss.Text = "Delete Customers";
            this.mnuDeleteCustomerss.Click += new System.EventHandler(this.mnuDeleteCustomers_Click);
            // 
            // mnuSearchCustomers
            // 
            this.mnuSearchCustomers.Name = "mnuSearchCustomers";
            this.mnuSearchCustomers.Size = new System.Drawing.Size(198, 22);
            this.mnuSearchCustomers.Text = "List / Search Customers";
            this.mnuSearchCustomers.Click += new System.EventHandler(this.mnuSearchCustomers_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.mnuEditEmployees,
            this.mnuDeleteEmployees,
            this.mnuSearchEmployees});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.addToolStripMenuItem.Text = "New Employees";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.mnuNewEmployees_Click);
            // 
            // mnuEditEmployees
            // 
            this.mnuEditEmployees.Name = "mnuEditEmployees";
            this.mnuEditEmployees.Size = new System.Drawing.Size(198, 22);
            this.mnuEditEmployees.Text = "Edit Employees";
            this.mnuEditEmployees.Click += new System.EventHandler(this.mnuEditEmployees_Click);
            // 
            // mnuDeleteEmployees
            // 
            this.mnuDeleteEmployees.Name = "mnuDeleteEmployees";
            this.mnuDeleteEmployees.Size = new System.Drawing.Size(198, 22);
            this.mnuDeleteEmployees.Text = "Delete Employees";
            this.mnuDeleteEmployees.Click += new System.EventHandler(this.mnuDeleteEmployees_Click);
            // 
            // mnuSearchEmployees
            // 
            this.mnuSearchEmployees.Name = "mnuSearchEmployees";
            this.mnuSearchEmployees.Size = new System.Drawing.Size(198, 22);
            this.mnuSearchEmployees.Text = "List / Search Employees";
            this.mnuSearchEmployees.Click += new System.EventHandler(this.mnuSearchEmployees_Click);
            // 
            // purchasingToolStripMenuItem
            // 
            this.purchasingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewPurchases,
            this.mnuEditPurchases,
            this.mnuDeletetePurchases,
            this.mnuSearchPurchases});
            this.purchasingToolStripMenuItem.Name = "purchasingToolStripMenuItem";
            this.purchasingToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.purchasingToolStripMenuItem.Text = "Purchasing";
            // 
            // mnuNewPurchases
            // 
            this.mnuNewPurchases.Name = "mnuNewPurchases";
            this.mnuNewPurchases.Size = new System.Drawing.Size(194, 22);
            this.mnuNewPurchases.Text = "New Purchases";
            this.mnuNewPurchases.Click += new System.EventHandler(this.mnuNewPurchases_Click);
            // 
            // mnuEditPurchases
            // 
            this.mnuEditPurchases.Name = "mnuEditPurchases";
            this.mnuEditPurchases.Size = new System.Drawing.Size(194, 22);
            this.mnuEditPurchases.Text = "Edit Purchases";
            this.mnuEditPurchases.Click += new System.EventHandler(this.mnuEditPurchases_Click);
            // 
            // mnuDeletetePurchases
            // 
            this.mnuDeletetePurchases.Name = "mnuDeletetePurchases";
            this.mnuDeletetePurchases.Size = new System.Drawing.Size(194, 22);
            this.mnuDeletetePurchases.Text = "Delete Purchases";
            this.mnuDeletetePurchases.Click += new System.EventHandler(this.mnuDeletetePurchases_Click);
            // 
            // mnuSearchPurchases
            // 
            this.mnuSearchPurchases.Name = "mnuSeachPurchases";
            this.mnuSearchPurchases.Size = new System.Drawing.Size(194, 22);
            this.mnuSearchPurchases.Text = "List / Search Purchases";
            this.mnuSearchPurchases.Click += new System.EventHandler(this.mnuSearchPurchases_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // frmCRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 441);
            this.Controls.Add(this.mnuCRM);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuCRM;
            this.Name = "frmCRM";
            this.Text = "Customer Resource Management";
            this.Load += new System.EventHandler(this.frmCRM_Load);
            this.mnuCRM.ResumeLayout(false);
            this.mnuCRM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCRM;
        private System.Windows.Forms.ToolStripMenuItem leadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceOrdrersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteCustomerss;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchCustomers;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEditEmployees;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteEmployees;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchEmployees;
        private System.Windows.Forms.ToolStripMenuItem newLeadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEditLeadm;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteLead;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchLeads;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuEditInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuNewMainOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuEditMainOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteMainOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchMainOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuNewPurchases;
        private System.Windows.Forms.ToolStripMenuItem mnuEditPurchases;
        private System.Windows.Forms.ToolStripMenuItem mnuDeletetePurchases;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchPurchases;
    }
}