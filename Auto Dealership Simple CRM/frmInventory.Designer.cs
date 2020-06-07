namespace CustomerResourceManagement
{
    partial class frmInventory
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
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.Vehicle_Information = new System.Windows.Forms.GroupBox();
            this.lblReceived = new System.Windows.Forms.Label();
            this.lblPO = new System.Windows.Forms.Label();
            this.imgInventoryPhoto = new System.Windows.Forms.PictureBox();
            this.lblVIN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpLotArrival = new System.Windows.Forms.DateTimePicker();
            this.tbPurchaseOrderID = new System.Windows.Forms.TextBox();
            this.tbVIN = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.lblLotArrival = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTimeOnLot = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.cboInventory = new System.Windows.Forms.ComboBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numDealerCost = new System.Windows.Forms.NumericUpDown();
            this.numMileage = new System.Windows.Forms.NumericUpDown();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.clsInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.Vehicle_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInventoryPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDealerCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsInventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnAction);
            this.pnlMain.Controls.Add(this.pnlInfo);
            this.pnlMain.Controls.Add(this.cboInventory);
            this.pnlMain.Location = new System.Drawing.Point(6, 6);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 372);
            this.pnlMain.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(650, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(553, 295);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(81, 34);
            this.btnAction.TabIndex = 14;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.Window;
            this.pnlInfo.Controls.Add(this.Vehicle_Information);
            this.pnlInfo.Location = new System.Drawing.Point(165, 6);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(632, 363);
            this.pnlInfo.TabIndex = 15;
            // 
            // Vehicle_Information
            // 
            this.Vehicle_Information.Controls.Add(this.numYear);
            this.Vehicle_Information.Controls.Add(this.numMileage);
            this.Vehicle_Information.Controls.Add(this.lblReceived);
            this.Vehicle_Information.Controls.Add(this.numDealerCost);
            this.Vehicle_Information.Controls.Add(this.lblPO);
            this.Vehicle_Information.Controls.Add(this.imgInventoryPhoto);
            this.Vehicle_Information.Controls.Add(this.numPrice);
            this.Vehicle_Information.Controls.Add(this.lblVIN);
            this.Vehicle_Information.Controls.Add(this.label2);
            this.Vehicle_Information.Controls.Add(this.dtpLotArrival);
            this.Vehicle_Information.Controls.Add(this.tbPurchaseOrderID);
            this.Vehicle_Information.Controls.Add(this.tbVIN);
            this.Vehicle_Information.Controls.Add(this.tbColor);
            this.Vehicle_Information.Controls.Add(this.lblLotArrival);
            this.Vehicle_Information.Controls.Add(this.lblCost);
            this.Vehicle_Information.Controls.Add(this.label9);
            this.Vehicle_Information.Controls.Add(this.label8);
            this.Vehicle_Information.Controls.Add(this.label7);
            this.Vehicle_Information.Controls.Add(this.label6);
            this.Vehicle_Information.Controls.Add(this.label5);
            this.Vehicle_Information.Controls.Add(this.label1);
            this.Vehicle_Information.Controls.Add(this.tbTimeOnLot);
            this.Vehicle_Information.Controls.Add(this.tbType);
            this.Vehicle_Information.Controls.Add(this.tbModel);
            this.Vehicle_Information.Controls.Add(this.tbMake);
            this.Vehicle_Information.Location = new System.Drawing.Point(12, 9);
            this.Vehicle_Information.Name = "Vehicle_Information";
            this.Vehicle_Information.Size = new System.Drawing.Size(367, 314);
            this.Vehicle_Information.TabIndex = 10;
            this.Vehicle_Information.TabStop = false;
            this.Vehicle_Information.Text = "Vehicle Information";
            this.Vehicle_Information.Enter += new System.EventHandler(this.Vehicle_Information_Enter);
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Location = new System.Drawing.Point(193, 173);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(53, 13);
            this.lblReceived.TabIndex = 27;
            this.lblReceived.Text = "Received";
            this.lblReceived.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblReceived.Visible = false;
            this.lblReceived.Click += new System.EventHandler(this.LblLotArrive_Click);
            // 
            // lblPO
            // 
            this.lblPO.AutoSize = true;
            this.lblPO.Location = new System.Drawing.Point(192, 271);
            this.lblPO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPO.Name = "lblPO";
            this.lblPO.Size = new System.Drawing.Size(62, 13);
            this.lblPO.TabIndex = 24;
            this.lblPO.Text = "PO Number";
            this.lblPO.Visible = false;
            // 
            // imgInventoryPhoto
            // 
            this.imgInventoryPhoto.Location = new System.Drawing.Point(198, 38);
            this.imgInventoryPhoto.Name = "imgInventoryPhoto";
            this.imgInventoryPhoto.Size = new System.Drawing.Size(157, 114);
            this.imgInventoryPhoto.TabIndex = 23;
            this.imgInventoryPhoto.TabStop = false;
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Location = new System.Drawing.Point(192, 238);
            this.lblVIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(25, 13);
            this.lblVIN.TabIndex = 23;
            this.lblVIN.Text = "VIN";
            this.lblVIN.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Color";
            // 
            // dtpLotArrival
            // 
            this.dtpLotArrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLotArrival.Location = new System.Drawing.Point(266, 170);
            this.dtpLotArrival.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpLotArrival.MinDate = new System.DateTime(2020, 5, 7, 13, 33, 51, 0);
            this.dtpLotArrival.Name = "dtpLotArrival";
            this.dtpLotArrival.Size = new System.Drawing.Size(91, 20);
            this.dtpLotArrival.TabIndex = 10;
            this.dtpLotArrival.Value = new System.DateTime(2020, 5, 7, 13, 33, 51, 0);
            this.dtpLotArrival.Visible = false;
            this.dtpLotArrival.ValueChanged += new System.EventHandler(this.DtpLotArrival_ValueChanged);
            // 
            // tbPurchaseOrderID
            // 
            this.tbPurchaseOrderID.Enabled = false;
            this.tbPurchaseOrderID.Location = new System.Drawing.Point(266, 269);
            this.tbPurchaseOrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPurchaseOrderID.Name = "tbPurchaseOrderID";
            this.tbPurchaseOrderID.ReadOnly = true;
            this.tbPurchaseOrderID.Size = new System.Drawing.Size(91, 20);
            this.tbPurchaseOrderID.TabIndex = 13;
            this.tbPurchaseOrderID.Visible = false;
            this.tbPurchaseOrderID.TextChanged += new System.EventHandler(this.TbPurchaseOrderID_TextChanged);
            // 
            // tbVIN
            // 
            this.tbVIN.Enabled = false;
            this.tbVIN.Location = new System.Drawing.Point(266, 236);
            this.tbVIN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbVIN.Name = "tbVIN";
            this.tbVIN.ReadOnly = true;
            this.tbVIN.Size = new System.Drawing.Size(91, 20);
            this.tbVIN.TabIndex = 12;
            this.tbVIN.Visible = false;
            this.tbVIN.TextChanged += new System.EventHandler(this.TbVIN_TextChanged);
            // 
            // tbColor
            // 
            this.tbColor.Enabled = false;
            this.tbColor.Location = new System.Drawing.Point(88, 237);
            this.tbColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbColor.Name = "tbColor";
            this.tbColor.ReadOnly = true;
            this.tbColor.Size = new System.Drawing.Size(91, 20);
            this.tbColor.TabIndex = 8;
            this.tbColor.TextChanged += new System.EventHandler(this.TbColor_TextChanged);
            // 
            // lblLotArrival
            // 
            this.lblLotArrival.AutoSize = true;
            this.lblLotArrival.Location = new System.Drawing.Point(14, 272);
            this.lblLotArrival.Name = "lblLotArrival";
            this.lblLotArrival.Size = new System.Drawing.Size(63, 13);
            this.lblLotArrival.TabIndex = 15;
            this.lblLotArrival.Text = "Time on Lot";
            this.lblLotArrival.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(192, 205);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(62, 13);
            this.lblCost.TabIndex = 14;
            this.lblCost.Text = "Dealer Cost";
            this.lblCost.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 173);
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
            this.label6.Location = new System.Drawing.Point(14, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Make";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Price";
            // 
            // tbTimeOnLot
            // 
            this.tbTimeOnLot.Enabled = false;
            this.tbTimeOnLot.Location = new System.Drawing.Point(88, 270);
            this.tbTimeOnLot.Name = "tbTimeOnLot";
            this.tbTimeOnLot.ReadOnly = true;
            this.tbTimeOnLot.Size = new System.Drawing.Size(91, 20);
            this.tbTimeOnLot.TabIndex = 9;
            this.tbTimeOnLot.TextChanged += new System.EventHandler(this.TbTimeOnLot_TextChanged);
            // 
            // tbType
            // 
            this.tbType.Enabled = false;
            this.tbType.Location = new System.Drawing.Point(88, 204);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(91, 20);
            this.tbType.TabIndex = 7;
            this.tbType.TextChanged += new System.EventHandler(this.TbType_TextChanged);
            // 
            // tbModel
            // 
            this.tbModel.Enabled = false;
            this.tbModel.Location = new System.Drawing.Point(88, 138);
            this.tbModel.Name = "tbModel";
            this.tbModel.ReadOnly = true;
            this.tbModel.Size = new System.Drawing.Size(91, 20);
            this.tbModel.TabIndex = 5;
            this.tbModel.TextChanged += new System.EventHandler(this.TbModel_TextChanged);
            // 
            // tbMake
            // 
            this.tbMake.Enabled = false;
            this.tbMake.Location = new System.Drawing.Point(88, 105);
            this.tbMake.Name = "tbMake";
            this.tbMake.ReadOnly = true;
            this.tbMake.Size = new System.Drawing.Size(91, 20);
            this.tbMake.TabIndex = 4;
            this.tbMake.TextChanged += new System.EventHandler(this.TbMake_TextChanged);
            // 
            // cboInventory
            // 
            this.cboInventory.FormattingEnabled = true;
            this.cboInventory.Location = new System.Drawing.Point(16, 18);
            this.cboInventory.Name = "cboInventory";
            this.cboInventory.Size = new System.Drawing.Size(141, 21);
            this.cboInventory.TabIndex = 1;
            this.cboInventory.SelectedIndexChanged += new System.EventHandler(this.CboInventory_SelectedIndexChanged);
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Enabled = false;
            this.numPrice.Location = new System.Drawing.Point(88, 38);
            this.numPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.ReadOnly = true;
            this.numPrice.Size = new System.Drawing.Size(91, 20);
            this.numPrice.TabIndex = 2;
            this.numPrice.ValueChanged += new System.EventHandler(this.NumPrice_ValueChanged);
            // 
            // numDealerCost
            // 
            this.numDealerCost.DecimalPlaces = 2;
            this.numDealerCost.Enabled = false;
            this.numDealerCost.Location = new System.Drawing.Point(266, 203);
            this.numDealerCost.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numDealerCost.Name = "numDealerCost";
            this.numDealerCost.ReadOnly = true;
            this.numDealerCost.Size = new System.Drawing.Size(91, 20);
            this.numDealerCost.TabIndex = 11;
            this.numDealerCost.Visible = false;
            this.numDealerCost.ValueChanged += new System.EventHandler(this.NumDealerCost_ValueChanged);
            // 
            // numMileage
            // 
            this.numMileage.Enabled = false;
            this.numMileage.Location = new System.Drawing.Point(88, 171);
            this.numMileage.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMileage.Name = "numMileage";
            this.numMileage.ReadOnly = true;
            this.numMileage.Size = new System.Drawing.Size(91, 20);
            this.numMileage.TabIndex = 6;
            this.numMileage.ValueChanged += new System.EventHandler(this.NumMileage_ValueChanged);
            // 
            // numYear
            // 
            this.numYear.Enabled = false;
            this.numYear.Location = new System.Drawing.Point(88, 71);
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
            this.numYear.TabIndex = 3;
            this.numYear.Value = new decimal(new int[] {
            1890,
            0,
            0,
            0});
            this.numYear.ValueChanged += new System.EventHandler(this.NumYear_ValueChanged);
            // 
            // clsInventoryBindingSource
            // 
            this.clsInventoryBindingSource.DataSource = typeof(CustomerResourceManagement.clsInventory);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 382);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmInventory";
            this.Text = "frmInventory";
            this.Activated += new System.EventHandler(this.frmInvoices_Activated);
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.Vehicle_Information.ResumeLayout(false);
            this.Vehicle_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInventoryPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDealerCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsInventoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.PictureBox imgInventoryPhoto;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.ComboBox cboInventory;
        private System.Windows.Forms.GroupBox Vehicle_Information;
        private System.Windows.Forms.Label lblLotArrival;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTimeOnLot;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.BindingSource clsInventoryBindingSource;
        private System.Windows.Forms.DateTimePicker dtpLotArrival;
        private System.Windows.Forms.TextBox tbVIN;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.Label lblPO;
        private System.Windows.Forms.TextBox tbPurchaseOrderID;
        private System.Windows.Forms.NumericUpDown numMileage;
        private System.Windows.Forms.NumericUpDown numDealerCost;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numYear;
    }
}