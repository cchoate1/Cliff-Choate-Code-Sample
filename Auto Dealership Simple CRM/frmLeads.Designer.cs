namespace CustomerResourceManagement
{
    partial class frmLeads
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.cboLeads = new System.Windows.Forms.ComboBox();
            this.numMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numMinPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbLeadId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.imgLeadsPhoto = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.dtCreateDate = new System.Windows.Forms.DateTimePicker();
            this.pnlMain.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLeadsPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnAction);
            this.pnlMain.Controls.Add(this.imgLeadsPhoto);
            this.pnlMain.Controls.Add(this.pnlInfo);
            this.pnlMain.Controls.Add(this.cboLeads);
            this.pnlMain.Location = new System.Drawing.Point(17, 16);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(750, 350);
            this.pnlMain.TabIndex = 5;
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
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.Window;
            this.pnlInfo.Controls.Add(this.label11);
            this.pnlInfo.Controls.Add(this.label12);
            this.pnlInfo.Controls.Add(this.dtExpirationDate);
            this.pnlInfo.Controls.Add(this.dtCreateDate);
            this.pnlInfo.Controls.Add(this.numMaxPrice);
            this.pnlInfo.Controls.Add(this.label6);
            this.pnlInfo.Controls.Add(this.numMinPrice);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.cboPriority);
            this.pnlInfo.Controls.Add(this.cboCustomer);
            this.pnlInfo.Controls.Add(this.label14);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.label13);
            this.pnlInfo.Controls.Add(this.tbLeadId);
            this.pnlInfo.Location = new System.Drawing.Point(165, 14);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(382, 326);
            this.pnlInfo.TabIndex = 15;
            // 
            // cboLeads
            // 
            this.cboLeads.FormattingEnabled = true;
            this.cboLeads.Location = new System.Drawing.Point(18, 14);
            this.cboLeads.Name = "cboLeads";
            this.cboLeads.Size = new System.Drawing.Size(141, 21);
            this.cboLeads.TabIndex = 1;
            this.cboLeads.SelectedValueChanged += new System.EventHandler(this.cboLeads_SelectedValueChanged);
            // 
            // numMaxPrice
            // 
            this.numMaxPrice.DecimalPlaces = 2;
            this.numMaxPrice.Location = new System.Drawing.Point(139, 163);
            this.numMaxPrice.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numMaxPrice.Name = "numMaxPrice";
            this.numMaxPrice.Size = new System.Drawing.Size(122, 20);
            this.numMaxPrice.TabIndex = 43;
            this.numMaxPrice.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "$";
            // 
            // numMinPrice
            // 
            this.numMinPrice.DecimalPlaces = 2;
            this.numMinPrice.Location = new System.Drawing.Point(139, 125);
            this.numMinPrice.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numMinPrice.Name = "numMinPrice";
            this.numMinPrice.Size = new System.Drawing.Size(122, 20);
            this.numMinPrice.TabIndex = 42;
            this.numMinPrice.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Maximum Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Minium Price";
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(128, 45);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(133, 21);
            this.cboCustomer.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Lead ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Customer";
            // 
            // tbLeadId
            // 
            this.tbLeadId.Location = new System.Drawing.Point(128, 9);
            this.tbLeadId.Name = "tbLeadId";
            this.tbLeadId.ReadOnly = true;
            this.tbLeadId.Size = new System.Drawing.Size(133, 20);
            this.tbLeadId.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Priority";
            // 
            // cboPriority
            // 
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Location = new System.Drawing.Point(128, 83);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(133, 21);
            this.cboPriority.TabIndex = 30;
            // 
            // imgLeadsPhoto
            // 
            this.imgLeadsPhoto.Location = new System.Drawing.Point(553, 14);
            this.imgLeadsPhoto.Name = "imgLeadsPhoto";
            this.imgLeadsPhoto.Size = new System.Drawing.Size(157, 175);
            this.imgLeadsPhoto.TabIndex = 23;
            this.imgLeadsPhoto.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Creation Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Expiration Date";
            // 
            // dtExpirationDate
            // 
            this.dtExpirationDate.CustomFormat = "MM/dd/yyyy";
            this.dtExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExpirationDate.Location = new System.Drawing.Point(128, 245);
            this.dtExpirationDate.Name = "dtExpirationDate";
            this.dtExpirationDate.Size = new System.Drawing.Size(133, 20);
            this.dtExpirationDate.TabIndex = 51;
            // 
            // dtCreateDate
            // 
            this.dtCreateDate.CustomFormat = "";
            this.dtCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCreateDate.Location = new System.Drawing.Point(128, 201);
            this.dtCreateDate.Name = "dtCreateDate";
            this.dtCreateDate.Size = new System.Drawing.Size(133, 20);
            this.dtCreateDate.TabIndex = 50;
            // 
            // frmLeads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 382);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmLeads";
            this.Text = "frmLeads";
            this.Activated += new System.EventHandler(this.frmLeads_Activated);
            this.pnlMain.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLeadsPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.ComboBox cboLeads;
        private System.Windows.Forms.NumericUpDown numMaxPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numMinPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbLeadId;
        private System.Windows.Forms.PictureBox imgLeadsPhoto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtExpirationDate;
        private System.Windows.Forms.DateTimePicker dtCreateDate;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.Label label14;
    }
}