namespace CustomerResourceManagement
{
    partial class frmInventoryDetail
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
            this.picInventoryImage = new System.Windows.Forms.PictureBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.Vehicle_Information = new System.Windows.Forms.GroupBox();
            this.lblSoldBy = new System.Windows.Forms.Label();
            this.lblHeldFor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCustomerHold = new System.Windows.Forms.TextBox();
            this.tbSalespersonID = new System.Windows.Forms.TextBox();
            this.tbPurchaseOrderID = new System.Windows.Forms.TextBox();
            this.tbVIN = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.lblLotArrival = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTimeOnLot = new System.Windows.Forms.TextBox();
            this.tbDealerCost = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbMileage = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbAvailable = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryImage)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.Vehicle_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // picInventoryImage
            // 
            this.picInventoryImage.Location = new System.Drawing.Point(524, 9);
            this.picInventoryImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picInventoryImage.Name = "picInventoryImage";
            this.picInventoryImage.Size = new System.Drawing.Size(187, 136);
            this.picInventoryImage.TabIndex = 0;
            this.picInventoryImage.TabStop = false;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.Window;
            this.pnlInfo.Controls.Add(this.btnCancel);
            this.pnlInfo.Controls.Add(this.btnHold);
            this.pnlInfo.Controls.Add(this.btnSell);
            this.pnlInfo.Controls.Add(this.Vehicle_Information);
            this.pnlInfo.Controls.Add(this.picInventoryImage);
            this.pnlInfo.Location = new System.Drawing.Point(9, 9);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(722, 326);
            this.pnlInfo.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(611, 279);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnHold
            // 
            this.btnHold.Location = new System.Drawing.Point(491, 279);
            this.btnHold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(99, 23);
            this.btnHold.TabIndex = 12;
            this.btnHold.Text = "Add/Edit Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.BtnHold_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(491, 245);
            this.btnSell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(99, 23);
            this.btnSell.TabIndex = 11;
            this.btnSell.Text = "Begin Sale";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.BtnSell_Click);
            // 
            // Vehicle_Information
            // 
            this.Vehicle_Information.Controls.Add(this.tbAvailable);
            this.Vehicle_Information.Controls.Add(this.lblSoldBy);
            this.Vehicle_Information.Controls.Add(this.lblHeldFor);
            this.Vehicle_Information.Controls.Add(this.label4);
            this.Vehicle_Information.Controls.Add(this.label3);
            this.Vehicle_Information.Controls.Add(this.label2);
            this.Vehicle_Information.Controls.Add(this.tbCustomerHold);
            this.Vehicle_Information.Controls.Add(this.tbSalespersonID);
            this.Vehicle_Information.Controls.Add(this.tbPurchaseOrderID);
            this.Vehicle_Information.Controls.Add(this.tbVIN);
            this.Vehicle_Information.Controls.Add(this.tbColor);
            this.Vehicle_Information.Controls.Add(this.Description);
            this.Vehicle_Information.Controls.Add(this.lblLotArrival);
            this.Vehicle_Information.Controls.Add(this.label10);
            this.Vehicle_Information.Controls.Add(this.label9);
            this.Vehicle_Information.Controls.Add(this.label8);
            this.Vehicle_Information.Controls.Add(this.label7);
            this.Vehicle_Information.Controls.Add(this.label6);
            this.Vehicle_Information.Controls.Add(this.label5);
            this.Vehicle_Information.Controls.Add(this.label1);
            this.Vehicle_Information.Controls.Add(this.tbTimeOnLot);
            this.Vehicle_Information.Controls.Add(this.tbDealerCost);
            this.Vehicle_Information.Controls.Add(this.tbType);
            this.Vehicle_Information.Controls.Add(this.tbMileage);
            this.Vehicle_Information.Controls.Add(this.tbModel);
            this.Vehicle_Information.Controls.Add(this.tbMake);
            this.Vehicle_Information.Controls.Add(this.tbYear);
            this.Vehicle_Information.Controls.Add(this.tbPrice);
            this.Vehicle_Information.Location = new System.Drawing.Point(12, 9);
            this.Vehicle_Information.Name = "Vehicle_Information";
            this.Vehicle_Information.Size = new System.Drawing.Size(468, 314);
            this.Vehicle_Information.TabIndex = 10;
            this.Vehicle_Information.TabStop = false;
            this.Vehicle_Information.Text = "Vehicle Information";
            // 
            // lblSoldBy
            // 
            this.lblSoldBy.AutoSize = true;
            this.lblSoldBy.Location = new System.Drawing.Point(198, 209);
            this.lblSoldBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoldBy.Name = "lblSoldBy";
            this.lblSoldBy.Size = new System.Drawing.Size(42, 13);
            this.lblSoldBy.TabIndex = 26;
            this.lblSoldBy.Text = "Sold by";
            // 
            // lblHeldFor
            // 
            this.lblHeldFor.AutoSize = true;
            this.lblHeldFor.Location = new System.Drawing.Point(198, 244);
            this.lblHeldFor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeldFor.Name = "lblHeldFor";
            this.lblHeldFor.Size = new System.Drawing.Size(44, 13);
            this.lblHeldFor.TabIndex = 25;
            this.lblHeldFor.Text = "Held for";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "PO Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "VIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Color";
            // 
            // tbCustomerHold
            // 
            this.tbCustomerHold.Enabled = false;
            this.tbCustomerHold.Location = new System.Drawing.Point(263, 242);
            this.tbCustomerHold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCustomerHold.Name = "tbCustomerHold";
            this.tbCustomerHold.ReadOnly = true;
            this.tbCustomerHold.Size = new System.Drawing.Size(92, 20);
            this.tbCustomerHold.TabIndex = 21;
            // 
            // tbSalespersonID
            // 
            this.tbSalespersonID.Enabled = false;
            this.tbSalespersonID.Location = new System.Drawing.Point(263, 207);
            this.tbSalespersonID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSalespersonID.Name = "tbSalespersonID";
            this.tbSalespersonID.ReadOnly = true;
            this.tbSalespersonID.Size = new System.Drawing.Size(92, 20);
            this.tbSalespersonID.TabIndex = 20;
            // 
            // tbPurchaseOrderID
            // 
            this.tbPurchaseOrderID.Enabled = false;
            this.tbPurchaseOrderID.Location = new System.Drawing.Point(263, 172);
            this.tbPurchaseOrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPurchaseOrderID.Name = "tbPurchaseOrderID";
            this.tbPurchaseOrderID.ReadOnly = true;
            this.tbPurchaseOrderID.Size = new System.Drawing.Size(91, 20);
            this.tbPurchaseOrderID.TabIndex = 19;
            // 
            // tbVIN
            // 
            this.tbVIN.Enabled = false;
            this.tbVIN.Location = new System.Drawing.Point(263, 137);
            this.tbVIN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbVIN.Name = "tbVIN";
            this.tbVIN.ReadOnly = true;
            this.tbVIN.Size = new System.Drawing.Size(91, 20);
            this.tbVIN.TabIndex = 18;
            // 
            // tbColor
            // 
            this.tbColor.Enabled = false;
            this.tbColor.Location = new System.Drawing.Point(263, 102);
            this.tbColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbColor.Name = "tbColor";
            this.tbColor.ReadOnly = true;
            this.tbColor.Size = new System.Drawing.Size(91, 20);
            this.tbColor.TabIndex = 17;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(189, 13);
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(267, 79);
            this.Description.TabIndex = 11;
            this.Description.Text = "Vehicle Long Text Description Here";
            // 
            // lblLotArrival
            // 
            this.lblLotArrival.AutoSize = true;
            this.lblLotArrival.Location = new System.Drawing.Point(14, 280);
            this.lblLotArrival.Name = "lblLotArrival";
            this.lblLotArrival.Size = new System.Drawing.Size(63, 13);
            this.lblLotArrival.TabIndex = 15;
            this.lblLotArrival.Text = "Time on Lot";
            this.lblLotArrival.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Dealer Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Type";
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
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Price";
            // 
            // tbTimeOnLot
            // 
            this.tbTimeOnLot.Enabled = false;
            this.tbTimeOnLot.Location = new System.Drawing.Point(88, 277);
            this.tbTimeOnLot.Name = "tbTimeOnLot";
            this.tbTimeOnLot.ReadOnly = true;
            this.tbTimeOnLot.Size = new System.Drawing.Size(91, 20);
            this.tbTimeOnLot.TabIndex = 7;
            // 
            // tbDealerCost
            // 
            this.tbDealerCost.Enabled = false;
            this.tbDealerCost.Location = new System.Drawing.Point(88, 242);
            this.tbDealerCost.Name = "tbDealerCost";
            this.tbDealerCost.ReadOnly = true;
            this.tbDealerCost.Size = new System.Drawing.Size(91, 20);
            this.tbDealerCost.TabIndex = 6;
            // 
            // tbType
            // 
            this.tbType.Enabled = false;
            this.tbType.Location = new System.Drawing.Point(88, 207);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(91, 20);
            this.tbType.TabIndex = 5;
            // 
            // tbMileage
            // 
            this.tbMileage.Enabled = false;
            this.tbMileage.Location = new System.Drawing.Point(88, 172);
            this.tbMileage.Name = "tbMileage";
            this.tbMileage.ReadOnly = true;
            this.tbMileage.Size = new System.Drawing.Size(91, 20);
            this.tbMileage.TabIndex = 4;
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
            // tbYear
            // 
            this.tbYear.Enabled = false;
            this.tbYear.Location = new System.Drawing.Point(88, 67);
            this.tbYear.Name = "tbYear";
            this.tbYear.ReadOnly = true;
            this.tbYear.Size = new System.Drawing.Size(91, 20);
            this.tbYear.TabIndex = 1;
            // 
            // tbPrice
            // 
            this.tbPrice.Enabled = false;
            this.tbPrice.Location = new System.Drawing.Point(88, 32);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(91, 20);
            this.tbPrice.TabIndex = 0;
            // 
            // tbAvailable
            // 
            this.tbAvailable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAvailable.Enabled = false;
            this.tbAvailable.Location = new System.Drawing.Point(263, 277);
            this.tbAvailable.Name = "tbAvailable";
            this.tbAvailable.ReadOnly = true;
            this.tbAvailable.Size = new System.Drawing.Size(92, 13);
            this.tbAvailable.TabIndex = 27;
            // 
            // frmInventoryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 324);
            this.Controls.Add(this.pnlInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInventoryDetail";
            this.Text = "Inventory Detail";
            this.Load += new System.EventHandler(this.FrmInventoryDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryImage)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.Vehicle_Information.ResumeLayout(false);
            this.Vehicle_Information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picInventoryImage;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.GroupBox Vehicle_Information;
        private System.Windows.Forms.Label lblSoldBy;
        private System.Windows.Forms.Label lblHeldFor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCustomerHold;
        private System.Windows.Forms.TextBox tbSalespersonID;
        private System.Windows.Forms.TextBox tbPurchaseOrderID;
        private System.Windows.Forms.TextBox tbVIN;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label lblLotArrival;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTimeOnLot;
        private System.Windows.Forms.TextBox tbDealerCost;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbMileage;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbAvailable;
    }
}