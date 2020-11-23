namespace ACCOUNTMANAGEMENT
{
    partial class COMPANY
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ofdCompany = new System.Windows.Forms.OpenFileDialog();
            this.txtCstNo = new System.Windows.Forms.TextBox();
            this.txtTinNo = new System.Windows.Forms.TextBox();
            this.lblCstNo = new System.Windows.Forms.Label();
            this.lblTinNo = new System.Windows.Forms.Label();
            this.lblFinancialYearFrom = new System.Windows.Forms.Label();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.lblWeb = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.dtpfromDate = new System.Windows.Forms.DateTimePicker();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_extra1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpclosingdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblpath = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdCompany
            // 
            this.ofdCompany.FileName = "ofdCompany";
            // 
            // txtCstNo
            // 
            this.txtCstNo.Location = new System.Drawing.Point(728, 220);
            this.txtCstNo.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtCstNo.MaxLength = 25;
            this.txtCstNo.Name = "txtCstNo";
            this.txtCstNo.Size = new System.Drawing.Size(298, 26);
            this.txtCstNo.TabIndex = 138;
            // 
            // txtTinNo
            // 
            this.txtTinNo.Location = new System.Drawing.Point(728, 178);
            this.txtTinNo.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtTinNo.MaxLength = 20;
            this.txtTinNo.Name = "txtTinNo";
            this.txtTinNo.Size = new System.Drawing.Size(298, 26);
            this.txtTinNo.TabIndex = 136;
            // 
            // lblCstNo
            // 
            this.lblCstNo.AutoSize = true;
            this.lblCstNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCstNo.Location = new System.Drawing.Point(582, 228);
            this.lblCstNo.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblCstNo.Name = "lblCstNo";
            this.lblCstNo.Size = new System.Drawing.Size(68, 20);
            this.lblCstNo.TabIndex = 161;
            this.lblCstNo.Text = "CST No.";
            // 
            // lblTinNo
            // 
            this.lblTinNo.AutoSize = true;
            this.lblTinNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTinNo.Location = new System.Drawing.Point(582, 186);
            this.lblTinNo.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblTinNo.Name = "lblTinNo";
            this.lblTinNo.Size = new System.Drawing.Size(62, 20);
            this.lblTinNo.TabIndex = 160;
            this.lblTinNo.Text = "TIN No.";
            // 
            // lblFinancialYearFrom
            // 
            this.lblFinancialYearFrom.AutoSize = true;
            this.lblFinancialYearFrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFinancialYearFrom.Location = new System.Drawing.Point(58, 309);
            this.lblFinancialYearFrom.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblFinancialYearFrom.Name = "lblFinancialYearFrom";
            this.lblFinancialYearFrom.Size = new System.Drawing.Size(188, 20);
            this.lblFinancialYearFrom.TabIndex = 158;
            this.lblFinancialYearFrom.Text = "Financial Year Start Date";
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(268, 263);
            this.txtWeb.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(298, 26);
            this.txtWeb.TabIndex = 127;
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWeb.Location = new System.Drawing.Point(58, 268);
            this.lblWeb.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(42, 20);
            this.lblWeb.TabIndex = 153;
            this.lblWeb.Text = "Web";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(58, 223);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 152;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(268, 218);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(298, 26);
            this.txtEmail.TabIndex = 125;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(268, 180);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(298, 26);
            this.txtPhoneNo.TabIndex = 124;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPhoneNo.Location = new System.Drawing.Point(58, 185);
            this.lblPhoneNo.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(83, 20);
            this.lblPhoneNo.TabIndex = 150;
            this.lblPhoneNo.Text = "Phone No.";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(214, 80);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(811, 75);
            this.txtAddress.TabIndex = 123;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(214, 18);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(811, 26);
            this.txtCompanyName.TabIndex = 121;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddress.Location = new System.Drawing.Point(58, 78);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 149;
            this.lblAddress.Text = "Address";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompanyName.Location = new System.Drawing.Point(58, 22);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(122, 20);
            this.lblCompanyName.TabIndex = 147;
            this.lblCompanyName.Text = "Company Name";
            // 
            // dtpfromDate
            // 
            this.dtpfromDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpfromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfromDate.Location = new System.Drawing.Point(268, 305);
            this.dtpfromDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpfromDate.Name = "dtpfromDate";
            this.dtpfromDate.Size = new System.Drawing.Size(298, 26);
            this.dtpfromDate.TabIndex = 167;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btn_new);
            this.GroupBox2.Controls.Add(this.btn_delete);
            this.GroupBox2.Controls.Add(this.btn_save);
            this.GroupBox2.Controls.Add(this.btn_close);
            this.GroupBox2.Location = new System.Drawing.Point(1070, 22);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(152, 288);
            this.GroupBox2.TabIndex = 173;
            this.GroupBox2.TabStop = false;
            // 
            // btn_new
            // 
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(12, 18);
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
            this.btn_delete.Location = new System.Drawing.Point(12, 147);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(124, 55);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(12, 83);
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
            this.btn_close.Location = new System.Drawing.Point(12, 212);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(124, 55);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "&Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_extra1
            // 
            this.txt_extra1.Location = new System.Drawing.Point(728, 262);
            this.txt_extra1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txt_extra1.MaxLength = 25;
            this.txt_extra1.Name = "txt_extra1";
            this.txt_extra1.Size = new System.Drawing.Size(298, 26);
            this.txt_extra1.TabIndex = 174;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(582, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 175;
            this.label2.Text = "EXTRA DETAIL 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpclosingdate
            // 
            this.dtpclosingdate.CustomFormat = "dd/MMM/yyyy";
            this.dtpclosingdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpclosingdate.Location = new System.Drawing.Point(268, 352);
            this.dtpclosingdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpclosingdate.Name = "dtpclosingdate";
            this.dtpclosingdate.Size = new System.Drawing.Size(298, 26);
            this.dtpclosingdate.TabIndex = 179;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(58, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 20);
            this.label4.TabIndex = 178;
            this.label4.Text = "Financial Year Closing date";
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(1226, 3);
            this.lblpath.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 20);
            this.lblpath.TabIndex = 205;
            // 
            // COMPANY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1239, 414);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.dtpclosingdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_extra1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.dtpfromDate);
            this.Controls.Add(this.txtCstNo);
            this.Controls.Add(this.txtTinNo);
            this.Controls.Add(this.lblCstNo);
            this.Controls.Add(this.lblTinNo);
            this.Controls.Add(this.lblFinancialYearFrom);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.lblWeb);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCompanyName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "COMPANY";
            this.Text = "COMPANY";
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog ofdCompany;
        private System.Windows.Forms.TextBox txtCstNo;
        private System.Windows.Forms.TextBox txtTinNo;
        private System.Windows.Forms.Label lblCstNo;
        private System.Windows.Forms.Label lblTinNo;
        private System.Windows.Forms.Label lblFinancialYearFrom;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCompanyName;
        internal System.Windows.Forms.DateTimePicker dtpfromDate;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btn_delete;
        internal System.Windows.Forms.Button btn_save;
        internal System.Windows.Forms.Button btn_close;
        internal System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.TextBox txt_extra1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtpclosingdate;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblpath;
    }
}