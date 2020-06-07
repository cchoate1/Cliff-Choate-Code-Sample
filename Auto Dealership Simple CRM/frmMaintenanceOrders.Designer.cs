namespace CustomerResourceManagement
{
    partial class frmMaintenanceOrders
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
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdByWorkOrderNo = new System.Windows.Forms.RadioButton();
            this.btnAction = new System.Windows.Forms.Button();
            this.rdByVehicle = new System.Windows.Forms.RadioButton();
            this.rdByCustomer = new System.Windows.Forms.RadioButton();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.dtActualCompletionDate = new System.Windows.Forms.DateTimePicker();
            this.dtEstCompletionDate = new System.Windows.Forms.DateTimePicker();
            this.dtArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.numActualLaborCost = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numEstLaborCost = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numActualPartCost = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numEstPartCost = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboVehicle = new System.Windows.Forms.ComboBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.taWorkDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbCompletionStatus = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbWorkOrderNum = new System.Windows.Forms.TextBox();
            this.cboMaintenanceOrders = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numActualLaborCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstLaborCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numActualPartCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstPartCost)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblSearchBy);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.rdByWorkOrderNo);
            this.pnlMain.Controls.Add(this.btnAction);
            this.pnlMain.Controls.Add(this.rdByVehicle);
            this.pnlMain.Controls.Add(this.rdByCustomer);
            this.pnlMain.Controls.Add(this.pnlInfo);
            this.pnlMain.Controls.Add(this.cboMaintenanceOrders);
            this.pnlMain.Location = new System.Drawing.Point(17, 16);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(750, 350);
            this.pnlMain.TabIndex = 6;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(15, 45);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(58, 13);
            this.lblSearchBy.TabIndex = 17;
            this.lblSearchBy.Text = "Search by:";
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(650, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdByWorkOrderNo
            // 
            this.rdByWorkOrderNo.AutoSize = true;
            this.rdByWorkOrderNo.Checked = true;
            this.rdByWorkOrderNo.Location = new System.Drawing.Point(18, 107);
            this.rdByWorkOrderNo.Name = "rdByWorkOrderNo";
            this.rdByWorkOrderNo.Size = new System.Drawing.Size(120, 17);
            this.rdByWorkOrderNo.TabIndex = 16;
            this.rdByWorkOrderNo.TabStop = true;
            this.rdByWorkOrderNo.Text = "Work Order Number";
            this.rdByWorkOrderNo.UseVisualStyleBackColor = true;
            this.rdByWorkOrderNo.CheckedChanged += new System.EventHandler(this.radioButton_checkedChanged);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(553, 295);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(81, 34);
            this.btnAction.TabIndex = 9;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // rdByVehicle
            // 
            this.rdByVehicle.AutoSize = true;
            this.rdByVehicle.Location = new System.Drawing.Point(18, 84);
            this.rdByVehicle.Name = "rdByVehicle";
            this.rdByVehicle.Size = new System.Drawing.Size(60, 17);
            this.rdByVehicle.TabIndex = 15;
            this.rdByVehicle.TabStop = true;
            this.rdByVehicle.Text = "Vehicle";
            this.rdByVehicle.UseVisualStyleBackColor = true;
            this.rdByVehicle.CheckedChanged += new System.EventHandler(this.radioButton_checkedChanged);
            // 
            // rdByCustomer
            // 
            this.rdByCustomer.AutoSize = true;
            this.rdByCustomer.Location = new System.Drawing.Point(18, 61);
            this.rdByCustomer.Name = "rdByCustomer";
            this.rdByCustomer.Size = new System.Drawing.Size(69, 17);
            this.rdByCustomer.TabIndex = 14;
            this.rdByCustomer.TabStop = true;
            this.rdByCustomer.Text = "Customer";
            this.rdByCustomer.UseVisualStyleBackColor = true;
            this.rdByCustomer.CheckedChanged += new System.EventHandler(this.radioButton_checkedChanged);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.Window;
            this.pnlInfo.Controls.Add(this.dtActualCompletionDate);
            this.pnlInfo.Controls.Add(this.dtEstCompletionDate);
            this.pnlInfo.Controls.Add(this.dtArrivalDate);
            this.pnlInfo.Controls.Add(this.numActualLaborCost);
            this.pnlInfo.Controls.Add(this.label10);
            this.pnlInfo.Controls.Add(this.numEstLaborCost);
            this.pnlInfo.Controls.Add(this.label16);
            this.pnlInfo.Controls.Add(this.label8);
            this.pnlInfo.Controls.Add(this.label12);
            this.pnlInfo.Controls.Add(this.numActualPartCost);
            this.pnlInfo.Controls.Add(this.label11);
            this.pnlInfo.Controls.Add(this.label9);
            this.pnlInfo.Controls.Add(this.label6);
            this.pnlInfo.Controls.Add(this.label7);
            this.pnlInfo.Controls.Add(this.numEstPartCost);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.cboVehicle);
            this.pnlInfo.Controls.Add(this.cboCustomer);
            this.pnlInfo.Controls.Add(this.taWorkDescription);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.label15);
            this.pnlInfo.Controls.Add(this.tbCompletionStatus);
            this.pnlInfo.Controls.Add(this.label14);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.label13);
            this.pnlInfo.Controls.Add(this.tbWorkOrderNum);
            this.pnlInfo.Location = new System.Drawing.Point(165, 14);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(576, 326);
            this.pnlInfo.TabIndex = 15;
            // 
            // dtActualCompletionDate
            // 
            this.dtActualCompletionDate.CustomFormat = "MM/dd/yyyy";
            this.dtActualCompletionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtActualCompletionDate.Location = new System.Drawing.Point(392, 255);
            this.dtActualCompletionDate.Name = "dtActualCompletionDate";
            this.dtActualCompletionDate.Size = new System.Drawing.Size(120, 20);
            this.dtActualCompletionDate.TabIndex = 20;
            // 
            // dtEstCompletionDate
            // 
            this.dtEstCompletionDate.CustomFormat = "MM/dd/yyyy";
            this.dtEstCompletionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEstCompletionDate.Location = new System.Drawing.Point(392, 209);
            this.dtEstCompletionDate.Name = "dtEstCompletionDate";
            this.dtEstCompletionDate.Size = new System.Drawing.Size(120, 20);
            this.dtEstCompletionDate.TabIndex = 20;
            // 
            // dtArrivalDate
            // 
            this.dtArrivalDate.CustomFormat = "";
            this.dtArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtArrivalDate.Location = new System.Drawing.Point(392, 165);
            this.dtArrivalDate.Name = "dtArrivalDate";
            this.dtArrivalDate.Size = new System.Drawing.Size(120, 20);
            this.dtArrivalDate.TabIndex = 20;
            // 
            // numActualLaborCost
            // 
            this.numActualLaborCost.DecimalPlaces = 2;
            this.numActualLaborCost.Location = new System.Drawing.Point(392, 131);
            this.numActualLaborCost.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numActualLaborCost.Name = "numActualLaborCost";
            this.numActualLaborCost.Size = new System.Drawing.Size(120, 20);
            this.numActualLaborCost.TabIndex = 19;
            this.numActualLaborCost.ThousandsSeparator = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "$";
            // 
            // numEstLaborCost
            // 
            this.numEstLaborCost.DecimalPlaces = 2;
            this.numEstLaborCost.Location = new System.Drawing.Point(392, 90);
            this.numEstLaborCost.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numEstLaborCost.Name = "numEstLaborCost";
            this.numEstLaborCost.Size = new System.Drawing.Size(120, 20);
            this.numEstLaborCost.TabIndex = 19;
            this.numEstLaborCost.ThousandsSeparator = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(264, 261);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Actual Completion Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Est. Completion Date";
            // 
            // numActualPartCost
            // 
            this.numActualPartCost.DecimalPlaces = 2;
            this.numActualPartCost.Location = new System.Drawing.Point(392, 54);
            this.numActualPartCost.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numActualPartCost.Name = "numActualPartCost";
            this.numActualPartCost.Size = new System.Drawing.Size(120, 20);
            this.numActualPartCost.TabIndex = 19;
            this.numActualPartCost.ThousandsSeparator = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Arrival Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Actual Labor Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Estimated Labor Cost";
            // 
            // numEstPartCost
            // 
            this.numEstPartCost.DecimalPlaces = 2;
            this.numEstPartCost.Location = new System.Drawing.Point(392, 16);
            this.numEstPartCost.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numEstPartCost.Name = "numEstPartCost";
            this.numEstPartCost.Size = new System.Drawing.Size(120, 20);
            this.numEstPartCost.TabIndex = 19;
            this.numEstPartCost.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Actual Parts Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Estimated Parts Cost";
            // 
            // cboVehicle
            // 
            this.cboVehicle.FormattingEnabled = true;
            this.cboVehicle.Location = new System.Drawing.Point(113, 89);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(104, 21);
            this.cboVehicle.TabIndex = 16;
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(112, 51);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(104, 21);
            this.cboCustomer.TabIndex = 16;
            // 
            // taWorkDescription
            // 
            this.taWorkDescription.Location = new System.Drawing.Point(11, 180);
            this.taWorkDescription.Name = "taWorkDescription";
            this.taWorkDescription.Size = new System.Drawing.Size(206, 105);
            this.taWorkDescription.TabIndex = 15;
            this.taWorkDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Work Description";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Completion Status";
            // 
            // tbCompletionStatus
            // 
            this.tbCompletionStatus.Location = new System.Drawing.Point(113, 130);
            this.tbCompletionStatus.Name = "tbCompletionStatus";
            this.tbCompletionStatus.Size = new System.Drawing.Size(104, 20);
            this.tbCompletionStatus.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Vehicle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Work Order Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Customer";
            // 
            // tbWorkOrderNum
            // 
            this.tbWorkOrderNum.Location = new System.Drawing.Point(113, 18);
            this.tbWorkOrderNum.Name = "tbWorkOrderNum";
            this.tbWorkOrderNum.ReadOnly = true;
            this.tbWorkOrderNum.Size = new System.Drawing.Size(104, 20);
            this.tbWorkOrderNum.TabIndex = 9;
            // 
            // cboMaintenanceOrders
            // 
            this.cboMaintenanceOrders.FormattingEnabled = true;
            this.cboMaintenanceOrders.Location = new System.Drawing.Point(18, 14);
            this.cboMaintenanceOrders.Name = "cboMaintenanceOrders";
            this.cboMaintenanceOrders.Size = new System.Drawing.Size(141, 21);
            this.cboMaintenanceOrders.TabIndex = 1;
            this.cboMaintenanceOrders.SelectedValueChanged += new System.EventHandler(this.cboMaintenanceOrders_SelectedValueChanged);
            // 
            // frmMaintenanceOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 382);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMaintenanceOrders";
            this.Text = "frmManitenanceOrders";
            this.Activated += new System.EventHandler(this.frmServiceRequests_Activated);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numActualLaborCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstLaborCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numActualPartCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstPartCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.ComboBox cboMaintenanceOrders;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.RadioButton rdByWorkOrderNo;
        private System.Windows.Forms.RadioButton rdByVehicle;
        private System.Windows.Forms.RadioButton rdByCustomer;
        private System.Windows.Forms.RichTextBox taWorkDescription;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbCompletionStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbWorkOrderNum;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.ComboBox cboVehicle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numEstPartCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numActualPartCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numActualLaborCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numEstLaborCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtActualCompletionDate;
        private System.Windows.Forms.DateTimePicker dtEstCompletionDate;
        private System.Windows.Forms.DateTimePicker dtArrivalDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}