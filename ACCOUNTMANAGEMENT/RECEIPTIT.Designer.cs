namespace ACCOUNTMANAGEMENT
{
    partial class RECEIPTIT
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
            this.btnAd = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblpath = new System.Windows.Forms.Label();
            this.txtReceiptNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbpaymentmode = new System.Windows.Forms.ComboBox();
            this.txttotalamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChequeno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_extra1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpChequeDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAd
            // 
            this.btnAd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAd.ForeColor = System.Drawing.Color.Green;
            this.btnAd.Location = new System.Drawing.Point(867, 135);
            this.btnAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAd.Name = "btnAd";
            this.btnAd.Size = new System.Drawing.Size(40, 42);
            this.btnAd.TabIndex = 292;
            this.btnAd.Text = "+";
            this.btnAd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAd.UseVisualStyleBackColor = true;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(220, 135);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(619, 28);
            this.cmbCustomer.TabIndex = 263;
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_KeyDown);
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(1194, 32);
            this.lblpath.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 20);
            this.lblpath.TabIndex = 281;
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Location = new System.Drawing.Point(220, 28);
            this.txtReceiptNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.ReadOnly = true;
            this.txtReceiptNo.Size = new System.Drawing.Size(148, 26);
            this.txtReceiptNo.TabIndex = 280;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(52, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 279;
            this.label6.Text = "Recipt No";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btn_new);
            this.GroupBox2.Controls.Add(this.btn_delete);
            this.GroupBox2.Controls.Add(this.btn_save);
            this.GroupBox2.Controls.Add(this.btn_close);
            this.GroupBox2.Location = new System.Drawing.Point(216, 415);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(566, 91);
            this.GroupBox2.TabIndex = 275;
            this.GroupBox2.TabStop = false;
            // 
            // btn_new
            // 
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(0, 18);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(124, 55);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "&New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(287, 18);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(124, 55);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(146, 18);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(124, 55);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(421, 18);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(124, 55);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "&Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(79, 373);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 274;
            this.label1.Text = "Cheque No";
            this.label1.Visible = false;
            // 
            // cmbpaymentmode
            // 
            this.cmbpaymentmode.FormattingEnabled = true;
            this.cmbpaymentmode.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.cmbpaymentmode.Location = new System.Drawing.Point(219, 191);
            this.cmbpaymentmode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbpaymentmode.Name = "cmbpaymentmode";
            this.cmbpaymentmode.Size = new System.Drawing.Size(180, 28);
            this.cmbpaymentmode.TabIndex = 264;
            this.cmbpaymentmode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbpaymentmode_KeyDown);
            // 
            // txttotalamount
            // 
            this.txttotalamount.Location = new System.Drawing.Point(216, 258);
            this.txttotalamount.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.Size = new System.Drawing.Size(224, 26);
            this.txttotalamount.TabIndex = 267;
            this.txttotalamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttotalamount_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(51, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 273;
            this.label5.Text = " Amount";
            // 
            // txtChequeno
            // 
            this.txtChequeno.Location = new System.Drawing.Point(219, 371);
            this.txtChequeno.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtChequeno.Name = "txtChequeno";
            this.txtChequeno.Size = new System.Drawing.Size(224, 26);
            this.txtChequeno.TabIndex = 266;
            this.txtChequeno.Visible = false;
            this.txtChequeno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChequeno_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(48, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 272;
            this.label2.Text = "Paymetnt Mode";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompanyName.Location = new System.Drawing.Point(54, 140);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(124, 20);
            this.lblCompanyName.TabIndex = 271;
            this.lblCompanyName.Text = "Customer Name";
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceiptDate.Location = new System.Drawing.Point(220, 78);
            this.dtpReceiptDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(178, 26);
            this.dtpReceiptDate.TabIndex = 262;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(460, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 277;
            this.label4.Text = "Cheque Date";
            this.label4.Visible = false;
            // 
            // txt_extra1
            // 
            this.txt_extra1.Location = new System.Drawing.Point(216, 320);
            this.txt_extra1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txt_extra1.MaxLength = 25;
            this.txt_extra1.Name = "txt_extra1";
            this.txt_extra1.Size = new System.Drawing.Size(580, 26);
            this.txt_extra1.TabIndex = 269;
            this.txt_extra1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_extra1_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(45, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 276;
            this.label3.Text = "EXTRA DETAIL";
            // 
            // dtpChequeDate
            // 
            this.dtpChequeDate.CustomFormat = "dd/MM/yyyy";
            this.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChequeDate.Location = new System.Drawing.Point(650, 186);
            this.dtpChequeDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpChequeDate.Name = "dtpChequeDate";
            this.dtpChequeDate.Size = new System.Drawing.Size(178, 26);
            this.dtpChequeDate.TabIndex = 265;
            this.dtpChequeDate.Visible = false;
            this.dtpChequeDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpChequeDate_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(51, 83);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 270;
            this.label11.Text = "Date";
            // 
            // RECEIPTIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1388, 520);
            this.Controls.Add(this.btnAd);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.txtReceiptNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbpaymentmode);
            this.Controls.Add(this.txttotalamount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChequeno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.dtpReceiptDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_extra1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpChequeDate);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RECEIPTIT";
            this.Text = "RECEIPTIT";
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAd;
        private System.Windows.Forms.ComboBox cmbCustomer;
        public System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.TextBox txtReceiptNo;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btn_new;
        internal System.Windows.Forms.Button btn_delete;
        internal System.Windows.Forms.Button btn_save;
        internal System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbpaymentmode;
        private System.Windows.Forms.TextBox txttotalamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChequeno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCompanyName;
        internal System.Windows.Forms.DateTimePicker dtpReceiptDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_extra1;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DateTimePicker dtpChequeDate;
        private System.Windows.Forms.Label label11;
    }
}