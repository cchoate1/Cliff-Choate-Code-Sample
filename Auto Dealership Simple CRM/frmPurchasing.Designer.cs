namespace CustomerResourceManagement
{
    partial class frmPurchasing
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnInventoryDetail = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.numMileage = new System.Windows.Forms.NumericUpDown();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.tbAuthorizedBy = new System.Windows.Forms.TextBox();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.lblExpected = new System.Windows.Forms.Label();
            this.lblVIN = new System.Windows.Forms.Label();
            this.dtpLotArrival = new System.Windows.Forms.DateTimePicker();
            this.tbVIN = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.cboPurchaseOrder = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnInventoryDetail);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnAction);
            this.pnlMain.Controls.Add(this.pnlInfo);
            this.pnlMain.Controls.Add(this.cboPurchaseOrder);
            this.pnlMain.Location = new System.Drawing.Point(17, 16);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(750, 350);
            this.pnlMain.TabIndex = 7;
            // 
            // btnInventoryDetail
            // 
            this.btnInventoryDetail.CausesValidation = false;
            this.btnInventoryDetail.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInventoryDetail.Location = new System.Drawing.Point(650, 248);
            this.btnInventoryDetail.Name = "btnInventoryDetail";
            this.btnInventoryDetail.Size = new System.Drawing.Size(81, 34);
            this.btnInventoryDetail.TabIndex = 12;
            this.btnInventoryDetail.Text = "Vehicle Detail";
            this.btnInventoryDetail.UseVisualStyleBackColor = true;
            this.btnInventoryDetail.Click += new System.EventHandler(this.BtnInventoryDetail_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(650, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(553, 295);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(81, 34);
            this.btnAction.TabIndex = 13;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.Window;
            this.pnlInfo.Controls.Add(this.numMileage);
            this.pnlInfo.Controls.Add(this.numYear);
            this.pnlInfo.Controls.Add(this.numCost);
            this.pnlInfo.Controls.Add(this.tbAuthorizedBy);
            this.pnlInfo.Controls.Add(this.tbSource);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.lblColor);
            this.pnlInfo.Controls.Add(this.tbColor);
            this.pnlInfo.Controls.Add(this.lblType);
            this.pnlInfo.Controls.Add(this.lblMileage);
            this.pnlInfo.Controls.Add(this.label7);
            this.pnlInfo.Controls.Add(this.label6);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.tbType);
            this.pnlInfo.Controls.Add(this.tbModel);
            this.pnlInfo.Controls.Add(this.tbMake);
            this.pnlInfo.Controls.Add(this.lblExpected);
            this.pnlInfo.Controls.Add(this.lblVIN);
            this.pnlInfo.Controls.Add(this.dtpLotArrival);
            this.pnlInfo.Controls.Add(this.tbVIN);
            this.pnlInfo.Controls.Add(this.lblCost);
            this.pnlInfo.Location = new System.Drawing.Point(165, 14);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(382, 326);
            this.pnlInfo.TabIndex = 15;
            // 
            // numMileage
            // 
            this.numMileage.Enabled = false;
            this.numMileage.Location = new System.Drawing.Point(90, 113);
            this.numMileage.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMileage.Name = "numMileage";
            this.numMileage.ReadOnly = true;
            this.numMileage.Size = new System.Drawing.Size(91, 20);
            this.numMileage.TabIndex = 4;
            this.numMileage.Visible = false;
            // 
            // numYear
            // 
            this.numYear.Enabled = false;
            this.numYear.Location = new System.Drawing.Point(90, 21);
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
            this.numYear.TabIndex = 1;
            this.numYear.Value = new decimal(new int[] {
            1890,
            0,
            0,
            0});
            // 
            // numCost
            // 
            this.numCost.DecimalPlaces = 2;
            this.numCost.Location = new System.Drawing.Point(276, 85);
            this.numCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(91, 20);
            this.numCost.TabIndex = 9;
            this.numCost.Visible = false;
            // 
            // tbAuthorizedBy
            // 
            this.tbAuthorizedBy.Location = new System.Drawing.Point(276, 53);
            this.tbAuthorizedBy.Name = "tbAuthorizedBy";
            this.tbAuthorizedBy.Size = new System.Drawing.Size(91, 20);
            this.tbAuthorizedBy.TabIndex = 8;
            // 
            // tbSource
            // 
            this.tbSource.Location = new System.Drawing.Point(276, 21);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(91, 20);
            this.tbSource.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Authorized by";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Source";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(16, 185);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 45;
            this.lblColor.Text = "Color";
            this.lblColor.Visible = false;
            // 
            // tbColor
            // 
            this.tbColor.Enabled = false;
            this.tbColor.Location = new System.Drawing.Point(90, 181);
            this.tbColor.Margin = new System.Windows.Forms.Padding(2);
            this.tbColor.Name = "tbColor";
            this.tbColor.ReadOnly = true;
            this.tbColor.Size = new System.Drawing.Size(91, 20);
            this.tbColor.TabIndex = 6;
            this.tbColor.Visible = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(16, 153);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 43;
            this.lblType.Text = "Type";
            this.lblType.Visible = false;
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(16, 121);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(44, 13);
            this.lblMileage.TabIndex = 42;
            this.lblMileage.Text = "Mileage";
            this.lblMileage.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Make";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Year";
            // 
            // tbType
            // 
            this.tbType.Enabled = false;
            this.tbType.Location = new System.Drawing.Point(90, 149);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(91, 20);
            this.tbType.TabIndex = 5;
            this.tbType.Visible = false;
            // 
            // tbModel
            // 
            this.tbModel.Enabled = false;
            this.tbModel.Location = new System.Drawing.Point(90, 85);
            this.tbModel.Name = "tbModel";
            this.tbModel.ReadOnly = true;
            this.tbModel.Size = new System.Drawing.Size(91, 20);
            this.tbModel.TabIndex = 3;
            // 
            // tbMake
            // 
            this.tbMake.Enabled = false;
            this.tbMake.Location = new System.Drawing.Point(90, 53);
            this.tbMake.Name = "tbMake";
            this.tbMake.ReadOnly = true;
            this.tbMake.Size = new System.Drawing.Size(91, 20);
            this.tbMake.TabIndex = 2;
            // 
            // lblExpected
            // 
            this.lblExpected.AutoSize = true;
            this.lblExpected.Location = new System.Drawing.Point(199, 153);
            this.lblExpected.Name = "lblExpected";
            this.lblExpected.Size = new System.Drawing.Size(52, 13);
            this.lblExpected.TabIndex = 33;
            this.lblExpected.Text = "Expected";
            this.lblExpected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblExpected.Visible = false;
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Location = new System.Drawing.Point(199, 121);
            this.lblVIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(25, 13);
            this.lblVIN.TabIndex = 32;
            this.lblVIN.Text = "VIN";
            this.lblVIN.Visible = false;
            // 
            // dtpLotArrival
            // 
            this.dtpLotArrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLotArrival.Location = new System.Drawing.Point(276, 149);
            this.dtpLotArrival.Margin = new System.Windows.Forms.Padding(2);
            this.dtpLotArrival.MinDate = new System.DateTime(2020, 5, 7, 13, 33, 51, 0);
            this.dtpLotArrival.Name = "dtpLotArrival";
            this.dtpLotArrival.Size = new System.Drawing.Size(91, 20);
            this.dtpLotArrival.TabIndex = 11;
            this.dtpLotArrival.Value = new System.DateTime(2020, 5, 7, 13, 33, 51, 0);
            this.dtpLotArrival.Visible = false;
            // 
            // tbVIN
            // 
            this.tbVIN.Enabled = false;
            this.tbVIN.Location = new System.Drawing.Point(276, 117);
            this.tbVIN.Margin = new System.Windows.Forms.Padding(2);
            this.tbVIN.Name = "tbVIN";
            this.tbVIN.ReadOnly = true;
            this.tbVIN.Size = new System.Drawing.Size(91, 20);
            this.tbVIN.TabIndex = 10;
            this.tbVIN.Visible = false;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(199, 89);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 29;
            this.lblCost.Text = "Cost";
            this.lblCost.Visible = false;
            // 
            // cboPurchaseOrder
            // 
            this.cboPurchaseOrder.FormattingEnabled = true;
            this.cboPurchaseOrder.Location = new System.Drawing.Point(18, 14);
            this.cboPurchaseOrder.Name = "cboPurchaseOrder";
            this.cboPurchaseOrder.Size = new System.Drawing.Size(141, 21);
            this.cboPurchaseOrder.TabIndex = 0;
            this.cboPurchaseOrder.SelectedIndexChanged += new System.EventHandler(this.CboPurchaseOrder_SelectedIndexChanged);
            // 
            // frmPurchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 411);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmPurchasing";
            this.Text = "frmPurchasing";
            this.Activated += new System.EventHandler(this.frmPurchasing_Activated);
            this.pnlMain.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.ComboBox cboPurchaseOrder;
        private System.Windows.Forms.Button btnInventoryDetail;
        private System.Windows.Forms.Label lblExpected;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.DateTimePicker dtpLotArrival;
        private System.Windows.Forms.TextBox tbVIN;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAuthorizedBy;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numMileage;
    }
}