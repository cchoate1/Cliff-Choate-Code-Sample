namespace CustomerResourceManagement
{
    partial class frmNewSalesOrder
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
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.grpSaleInfo = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPickUp = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbSalesperson = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpVehicle = new System.Windows.Forms.GroupBox();
            this.lblSoldBy = new System.Windows.Forms.Label();
            this.lblHeldFor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCustomerHold = new System.Windows.Forms.TextBox();
            this.tbSalespersonID = new System.Windows.Forms.TextBox();
            this.tbVIN = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numMileage = new System.Windows.Forms.NumericUpDown();
            this.numFinalPrice = new System.Windows.Forms.NumericUpDown();
            this.tbCustLast = new System.Windows.Forms.TextBox();
            this.tbCustFirst = new System.Windows.Forms.TextBox();
            this.tbCustPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlInfo.SuspendLayout();
            this.grpSaleInfo.SuspendLayout();
            this.grpCustomerInfo.SuspendLayout();
            this.grpVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinalPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.Window;
            this.pnlInfo.Controls.Add(this.grpSaleInfo);
            this.pnlInfo.Controls.Add(this.grpCustomerInfo);
            this.pnlInfo.Controls.Add(this.btnCancel);
            this.pnlInfo.Controls.Add(this.btnSave);
            this.pnlInfo.Controls.Add(this.grpVehicle);
            this.pnlInfo.Location = new System.Drawing.Point(6, 6);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(796, 376);
            this.pnlInfo.TabIndex = 17;
            // 
            // grpSaleInfo
            // 
            this.grpSaleInfo.Controls.Add(this.cboStatus);
            this.grpSaleInfo.Controls.Add(this.dtpSaleDate);
            this.grpSaleInfo.Controls.Add(this.dtpPickUp);
            this.grpSaleInfo.Controls.Add(this.lblStatus);
            this.grpSaleInfo.Controls.Add(this.tbSalesperson);
            this.grpSaleInfo.Controls.Add(this.label10);
            this.grpSaleInfo.Controls.Add(this.label4);
            this.grpSaleInfo.Controls.Add(this.label9);
            this.grpSaleInfo.Location = new System.Drawing.Point(407, 11);
            this.grpSaleInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSaleInfo.Name = "grpSaleInfo";
            this.grpSaleInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSaleInfo.Size = new System.Drawing.Size(196, 198);
            this.grpSaleInfo.TabIndex = 26;
            this.grpSaleInfo.TabStop = false;
            this.grpSaleInfo.Text = "Sale Information";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Invoiced",
            "Paid",
            "Delivered",
            "Canceled",
            "Incomplete"});
            this.cboStatus.Location = new System.Drawing.Point(89, 97);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(91, 21);
            this.cboStatus.TabIndex = 4;
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaleDate.Location = new System.Drawing.Point(89, 135);
            this.dtpSaleDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpSaleDate.MinDate = new System.DateTime(2020, 5, 8, 0, 0, 0, 0);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(91, 20);
            this.dtpSaleDate.TabIndex = 5;
            // 
            // dtpPickUp
            // 
            this.dtpPickUp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPickUp.Location = new System.Drawing.Point(89, 28);
            this.dtpPickUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpPickUp.MinDate = new System.DateTime(2020, 5, 8, 0, 0, 0, 0);
            this.dtpPickUp.Name = "dtpPickUp";
            this.dtpPickUp.Size = new System.Drawing.Size(91, 20);
            this.dtpPickUp.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(15, 103);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSalesperson
            // 
            this.tbSalesperson.Location = new System.Drawing.Point(89, 64);
            this.tbSalesperson.Name = "tbSalesperson";
            this.tbSalesperson.Size = new System.Drawing.Size(91, 20);
            this.tbSalesperson.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Salesperson";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Sale Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Pick-Up Date";
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.label13);
            this.grpCustomerInfo.Controls.Add(this.label12);
            this.grpCustomerInfo.Controls.Add(this.label11);
            this.grpCustomerInfo.Controls.Add(this.tbCustPhone);
            this.grpCustomerInfo.Controls.Add(this.tbCustFirst);
            this.grpCustomerInfo.Controls.Add(this.tbCustLast);
            this.grpCustomerInfo.Controls.Add(this.cboCustomer);
            this.grpCustomerInfo.Location = new System.Drawing.Point(210, 9);
            this.grpCustomerInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCustomerInfo.Size = new System.Drawing.Size(193, 314);
            this.grpCustomerInfo.TabIndex = 25;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer Information";
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(4, 32);
            this.cboCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(187, 21);
            this.cboCustomer.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(650, 295);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(553, 295);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // grpVehicle
            // 
            this.grpVehicle.Controls.Add(this.numFinalPrice);
            this.grpVehicle.Controls.Add(this.numMileage);
            this.grpVehicle.Controls.Add(this.numYear);
            this.grpVehicle.Controls.Add(this.lblSoldBy);
            this.grpVehicle.Controls.Add(this.lblHeldFor);
            this.grpVehicle.Controls.Add(this.label3);
            this.grpVehicle.Controls.Add(this.label2);
            this.grpVehicle.Controls.Add(this.tbCustomerHold);
            this.grpVehicle.Controls.Add(this.tbSalespersonID);
            this.grpVehicle.Controls.Add(this.tbVIN);
            this.grpVehicle.Controls.Add(this.tbColor);
            this.grpVehicle.Controls.Add(this.label8);
            this.grpVehicle.Controls.Add(this.label7);
            this.grpVehicle.Controls.Add(this.label6);
            this.grpVehicle.Controls.Add(this.label5);
            this.grpVehicle.Controls.Add(this.label1);
            this.grpVehicle.Controls.Add(this.tbModel);
            this.grpVehicle.Controls.Add(this.tbMake);
            this.grpVehicle.Location = new System.Drawing.Point(12, 9);
            this.grpVehicle.Name = "grpVehicle";
            this.grpVehicle.Size = new System.Drawing.Size(193, 314);
            this.grpVehicle.TabIndex = 10;
            this.grpVehicle.TabStop = false;
            this.grpVehicle.Text = "Vehicle Information";
            // 
            // lblSoldBy
            // 
            this.lblSoldBy.AutoSize = true;
            this.lblSoldBy.Location = new System.Drawing.Point(373, 2);
            this.lblSoldBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoldBy.Name = "lblSoldBy";
            this.lblSoldBy.Size = new System.Drawing.Size(42, 13);
            this.lblSoldBy.TabIndex = 26;
            this.lblSoldBy.Text = "Sold by";
            // 
            // lblHeldFor
            // 
            this.lblHeldFor.AutoSize = true;
            this.lblHeldFor.Location = new System.Drawing.Point(373, 37);
            this.lblHeldFor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeldFor.Name = "lblHeldFor";
            this.lblHeldFor.Size = new System.Drawing.Size(44, 13);
            this.lblHeldFor.TabIndex = 25;
            this.lblHeldFor.Text = "Held for";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "VIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Color";
            // 
            // tbCustomerHold
            // 
            this.tbCustomerHold.Enabled = false;
            this.tbCustomerHold.Location = new System.Drawing.Point(437, 35);
            this.tbCustomerHold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCustomerHold.Name = "tbCustomerHold";
            this.tbCustomerHold.ReadOnly = true;
            this.tbCustomerHold.Size = new System.Drawing.Size(89, 20);
            this.tbCustomerHold.TabIndex = 21;
            // 
            // tbSalespersonID
            // 
            this.tbSalespersonID.Enabled = false;
            this.tbSalespersonID.Location = new System.Drawing.Point(437, 0);
            this.tbSalespersonID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSalespersonID.Name = "tbSalespersonID";
            this.tbSalespersonID.ReadOnly = true;
            this.tbSalespersonID.Size = new System.Drawing.Size(92, 20);
            this.tbSalespersonID.TabIndex = 20;
            // 
            // tbVIN
            // 
            this.tbVIN.Enabled = false;
            this.tbVIN.Location = new System.Drawing.Point(88, 242);
            this.tbVIN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbVIN.Name = "tbVIN";
            this.tbVIN.ReadOnly = true;
            this.tbVIN.Size = new System.Drawing.Size(91, 20);
            this.tbVIN.TabIndex = 18;
            // 
            // tbColor
            // 
            this.tbColor.Enabled = false;
            this.tbColor.Location = new System.Drawing.Point(88, 207);
            this.tbColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbColor.Name = "tbColor";
            this.tbColor.ReadOnly = true;
            this.tbColor.Size = new System.Drawing.Size(91, 20);
            this.tbColor.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mileage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Make";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Final Price";
            // 
            // tbModel
            // 
            this.tbModel.Enabled = false;
            this.tbModel.Location = new System.Drawing.Point(88, 137);
            this.tbModel.Name = "tbModel";
            this.tbModel.ReadOnly = true;
            this.tbModel.Size = new System.Drawing.Size(91, 20);
            this.tbModel.TabIndex = 3;
            // 
            // tbMake
            // 
            this.tbMake.Enabled = false;
            this.tbMake.Location = new System.Drawing.Point(88, 102);
            this.tbMake.Name = "tbMake";
            this.tbMake.ReadOnly = true;
            this.tbMake.Size = new System.Drawing.Size(91, 20);
            this.tbMake.TabIndex = 2;
            // 
            // numYear
            // 
            this.numYear.Enabled = false;
            this.numYear.Location = new System.Drawing.Point(88, 67);
            this.numYear.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1890,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.ReadOnly = true;
            this.numYear.Size = new System.Drawing.Size(91, 20);
            this.numYear.TabIndex = 4;
            this.numYear.Value = new decimal(new int[] {
            1890,
            0,
            0,
            0});
            // 
            // numMileage
            // 
            this.numMileage.Enabled = false;
            this.numMileage.Location = new System.Drawing.Point(88, 172);
            this.numMileage.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMileage.Name = "numMileage";
            this.numMileage.ReadOnly = true;
            this.numMileage.Size = new System.Drawing.Size(91, 20);
            this.numMileage.TabIndex = 53;
            this.numMileage.Visible = false;
            // 
            // numFinalPrice
            // 
            this.numFinalPrice.DecimalPlaces = 2;
            this.numFinalPrice.Location = new System.Drawing.Point(88, 32);
            this.numFinalPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numFinalPrice.Name = "numFinalPrice";
            this.numFinalPrice.Size = new System.Drawing.Size(91, 20);
            this.numFinalPrice.TabIndex = 0;
            this.numFinalPrice.ValueChanged += new System.EventHandler(this.NumFinalPrice_ValueChanged);
            this.numFinalPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumFinalPrice_KeyPress);
            // 
            // tbCustLast
            // 
            this.tbCustLast.Enabled = false;
            this.tbCustLast.Location = new System.Drawing.Point(93, 67);
            this.tbCustLast.Name = "tbCustLast";
            this.tbCustLast.ReadOnly = true;
            this.tbCustLast.Size = new System.Drawing.Size(100, 20);
            this.tbCustLast.TabIndex = 2;
            // 
            // tbCustFirst
            // 
            this.tbCustFirst.Enabled = false;
            this.tbCustFirst.Location = new System.Drawing.Point(93, 102);
            this.tbCustFirst.Name = "tbCustFirst";
            this.tbCustFirst.ReadOnly = true;
            this.tbCustFirst.Size = new System.Drawing.Size(100, 20);
            this.tbCustFirst.TabIndex = 3;
            // 
            // tbCustPhone
            // 
            this.tbCustPhone.Enabled = false;
            this.tbCustPhone.Location = new System.Drawing.Point(93, 137);
            this.tbCustPhone.Name = "tbCustPhone";
            this.tbCustPhone.ReadOnly = true;
            this.tbCustPhone.Size = new System.Drawing.Size(100, 20);
            this.tbCustPhone.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Last Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "First Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Phone";
            // 
            // frmNewSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 382);
            this.Controls.Add(this.pnlInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNewSalesOrder";
            this.Text = "New SalesOrder";
            this.Load += new System.EventHandler(this.FrmSalesOrder_Load);
            this.pnlInfo.ResumeLayout(false);
            this.grpSaleInfo.ResumeLayout(false);
            this.grpSaleInfo.PerformLayout();
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpVehicle.ResumeLayout(false);
            this.grpVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinalPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpVehicle;
        private System.Windows.Forms.Label lblSoldBy;
        private System.Windows.Forms.Label lblHeldFor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCustomerHold;
        private System.Windows.Forms.TextBox tbSalespersonID;
        private System.Windows.Forms.TextBox tbVIN;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSalesperson;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.GroupBox grpSaleInfo;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.DateTimePicker dtpPickUp;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numMileage;
        private System.Windows.Forms.NumericUpDown numFinalPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCustPhone;
        private System.Windows.Forms.TextBox tbCustFirst;
        private System.Windows.Forms.TextBox tbCustLast;
    }
}