namespace CustomerResourceManagement
{
    partial class frmCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.imgCustomerPhoto = new System.Windows.Forms.PictureBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.nudMinPrice = new System.Windows.Forms.NumericUpDown();
            this.nudMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.cboPreferredContact = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.tblZipCode = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.MaskedTextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.rtfInterests = new System.Windows.Forms.RichTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCustomerPhoto)).BeginInit();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.imgCustomerPhoto);
            this.pnlMain.Controls.Add(this.pnlInfo);
            this.pnlMain.Controls.Add(this.cboCustomer);
            this.pnlMain.Location = new System.Drawing.Point(9, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(760, 498);
            this.pnlMain.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAction);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(590, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 249);
            this.panel1.TabIndex = 25;
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(36, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(36, 197);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(81, 34);
            this.btnAction.TabIndex = 16;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(36, 33);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 34);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // imgCustomerPhoto
            // 
            this.imgCustomerPhoto.Location = new System.Drawing.Point(587, 14);
            this.imgCustomerPhoto.Name = "imgCustomerPhoto";
            this.imgCustomerPhoto.Size = new System.Drawing.Size(157, 175);
            this.imgCustomerPhoto.TabIndex = 23;
            this.imgCustomerPhoto.TabStop = false;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.Window;
            this.pnlInfo.Controls.Add(this.nudMinPrice);
            this.pnlInfo.Controls.Add(this.nudMaxPrice);
            this.pnlInfo.Controls.Add(this.cboPreferredContact);
            this.pnlInfo.Controls.Add(this.txtPhone);
            this.pnlInfo.Controls.Add(this.txtEmail);
            this.pnlInfo.Controls.Add(this.tblZipCode);
            this.pnlInfo.Controls.Add(this.txtZipCode);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.txtState);
            this.pnlInfo.Controls.Add(this.txtAddress2);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.txtAddress1);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.txtCity);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.txtLastName);
            this.pnlInfo.Controls.Add(this.label44);
            this.pnlInfo.Controls.Add(this.txtFirstName);
            this.pnlInfo.Controls.Add(this.rtfInterests);
            this.pnlInfo.Controls.Add(this.label23);
            this.pnlInfo.Controls.Add(this.label22);
            this.pnlInfo.Controls.Add(this.label21);
            this.pnlInfo.Controls.Add(this.label20);
            this.pnlInfo.Controls.Add(this.label17);
            this.pnlInfo.Controls.Add(this.label27);
            this.pnlInfo.Location = new System.Drawing.Point(165, 14);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(409, 481);
            this.pnlInfo.TabIndex = 15;
            // 
            // nudMinPrice
            // 
            this.nudMinPrice.DecimalPlaces = 2;
            this.nudMinPrice.Location = new System.Drawing.Point(245, 301);
            this.nudMinPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            131072});
            this.nudMinPrice.Name = "nudMinPrice";
            this.nudMinPrice.Size = new System.Drawing.Size(120, 26);
            this.nudMinPrice.TabIndex = 13;
            this.nudMinPrice.ThousandsSeparator = true;
            this.nudMinPrice.Leave += new System.EventHandler(this.nudMinPrice_Leave);
            // 
            // nudMaxPrice
            // 
            this.nudMaxPrice.DecimalPlaces = 2;
            this.nudMaxPrice.Location = new System.Drawing.Point(245, 333);
            this.nudMaxPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            131072});
            this.nudMaxPrice.Name = "nudMaxPrice";
            this.nudMaxPrice.Size = new System.Drawing.Size(120, 26);
            this.nudMaxPrice.TabIndex = 14;
            this.nudMaxPrice.ThousandsSeparator = true;
            this.nudMaxPrice.ValueChanged += new System.EventHandler(this.nudMaxPrice_ValueChanged);
            // 
            // cboPreferredContact
            // 
            this.cboPreferredContact.Enabled = false;
            this.cboPreferredContact.FormattingEnabled = true;
            this.cboPreferredContact.Location = new System.Drawing.Point(129, 267);
            this.cboPreferredContact.Name = "cboPreferredContact";
            this.cboPreferredContact.Size = new System.Drawing.Size(239, 28);
            this.cboPreferredContact.TabIndex = 12;
            this.cboPreferredContact.SelectedValueChanged += new System.EventHandler(this.cboPreferredContact_SelectedValueChanged);
            this.cboPreferredContact.Leave += new System.EventHandler(this.cboPreferredContact_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(213, 234);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(155, 26);
            this.txtPhone.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 204);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(239, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // tblZipCode
            // 
            this.tblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblZipCode.Location = new System.Drawing.Point(188, 175);
            this.tblZipCode.Name = "tblZipCode";
            this.tblZipCode.Size = new System.Drawing.Size(80, 20);
            this.tblZipCode.TabIndex = 33;
            this.tblZipCode.Text = "Zip Code:";
            this.tblZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(268, 172);
            this.txtZipCode.Mask = "00000-9999";
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.ReadOnly = true;
            this.txtZipCode.Size = new System.Drawing.Size(100, 26);
            this.txtZipCode.TabIndex = 8;
            this.txtZipCode.Leave += new System.EventHandler(this.txtZipCode_Leave);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "State:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(129, 173);
            this.txtState.Mask = ">LL";
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(53, 26);
            this.txtState.TabIndex = 7;
            this.txtState.Leave += new System.EventHandler(this.txtState_Leave);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(128, 107);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.ReadOnly = true;
            this.txtAddress2.Size = new System.Drawing.Size(240, 26);
            this.txtAddress2.TabIndex = 5;
            this.txtAddress2.WordWrap = false;
            this.txtAddress2.Leave += new System.EventHandler(this.txtAddress2_Leave);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Address2:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(128, 75);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.ReadOnly = true;
            this.txtAddress1.Size = new System.Drawing.Size(240, 26);
            this.txtAddress1.TabIndex = 4;
            this.txtAddress1.WordWrap = false;
            this.txtAddress1.Leave += new System.EventHandler(this.txtAddress1_Leave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Address1:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(128, 139);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(240, 26);
            this.txtCity.TabIndex = 6;
            this.txtCity.WordWrap = false;
            this.txtCity.Leave += new System.EventHandler(this.txtCity_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "City:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Min price:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(128, 43);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(240, 26);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.WordWrap = false;
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // label44
            // 
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(52, 47);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(80, 20);
            this.label44.TabIndex = 21;
            this.label44.Text = "Last Name:";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(128, 11);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(240, 26);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.WordWrap = false;
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // rtfInterests
            // 
            this.rtfInterests.Location = new System.Drawing.Point(74, 366);
            this.rtfInterests.Name = "rtfInterests";
            this.rtfInterests.ReadOnly = true;
            this.rtfInterests.Size = new System.Drawing.Size(291, 106);
            this.rtfInterests.TabIndex = 15;
            this.rtfInterests.Text = "";
            this.rtfInterests.Leave += new System.EventHandler(this.rtfInterests_Leave);
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(164, 336);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 20);
            this.label23.TabIndex = 14;
            this.label23.Text = "Max price:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 366);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 20);
            this.label22.TabIndex = 13;
            this.label22.Text = "Interests:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(126, 238);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 20);
            this.label21.TabIndex = 12;
            this.label21.Text = "Phone:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(52, 205);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 20);
            this.label20.TabIndex = 11;
            this.label20.Text = "E-mail:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 20);
            this.label17.TabIndex = 10;
            this.label17.Text = "Preferred Contact:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(52, 15);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 20);
            this.label27.TabIndex = 9;
            this.label27.Text = "First Name:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCustomer
            // 
            this.cboCustomer.DisplayMember = "customer name";
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(18, 14);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(141, 28);
            this.cboCustomer.TabIndex = 1;
            this.cboCustomer.ValueMember = "customer_id";
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.CboCustomer_SelectedIndexChanged);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 522);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(10, 50);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCustomer";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomers";
            this.Activated += new System.EventHandler(this.frmCustomer_Activated);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.pnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCustomerPhoto)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox imgCustomerPhoto;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.RichTextBox rtfInterests;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label tblZipCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtZipCode;
        private System.Windows.Forms.MaskedTextBox txtState;
        private System.Windows.Forms.ComboBox cboPreferredContact;
        private System.Windows.Forms.NumericUpDown nudMinPrice;
        private System.Windows.Forms.NumericUpDown nudMaxPrice;
    }
}