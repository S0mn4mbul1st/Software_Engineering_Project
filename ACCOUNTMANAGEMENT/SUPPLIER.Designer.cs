namespace ACCOUNTMANAGEMENT
{
    partial class SUPPLIER
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
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.cmbcrdr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpbal = new System.Windows.Forms.TextBox();
            this.lblpath = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.txtSupplierid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_extra1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_delete.Location = new System.Drawing.Point(12, 146);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(124, 55);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(330, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 267;
            this.label6.Text = "Cr./Dr.";
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
            // cmbcrdr
            // 
            this.cmbcrdr.FormattingEnabled = true;
            this.cmbcrdr.Items.AddRange(new object[] {
            "Cr",
            "Dr"});
            this.cmbcrdr.Location = new System.Drawing.Point(396, 340);
            this.cmbcrdr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbcrdr.Name = "cmbcrdr";
            this.cmbcrdr.Size = new System.Drawing.Size(106, 28);
            this.cmbcrdr.TabIndex = 265;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(30, 343);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 264;
            this.label3.Text = "OP BALANCE";
            // 
            // txtOpbal
            // 
            this.txtOpbal.Location = new System.Drawing.Point(184, 342);
            this.txtOpbal.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtOpbal.Name = "txtOpbal";
            this.txtOpbal.Size = new System.Drawing.Size(136, 26);
            this.txtOpbal.TabIndex = 263;
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(1068, 138);
            this.lblpath.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 20);
            this.lblpath.TabIndex = 262;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(12, 211);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(124, 55);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "&Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txtSupplierid
            // 
            this.txtSupplierid.Location = new System.Drawing.Point(186, 28);
            this.txtSupplierid.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtSupplierid.Name = "txtSupplierid";
            this.txtSupplierid.Size = new System.Drawing.Size(157, 26);
            this.txtSupplierid.TabIndex = 261;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(30, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 260;
            this.label4.Text = "Supplier NO";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btn_new);
            this.GroupBox2.Controls.Add(this.btn_delete);
            this.GroupBox2.Controls.Add(this.btn_save);
            this.GroupBox2.Controls.Add(this.btn_close);
            this.GroupBox2.Location = new System.Drawing.Point(867, 312);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(152, 274);
            this.GroupBox2.TabIndex = 257;
            this.GroupBox2.TabStop = false;
            // 
            // txt_extra1
            // 
            this.txt_extra1.Location = new System.Drawing.Point(186, 391);
            this.txt_extra1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txt_extra1.MaxLength = 25;
            this.txt_extra1.Name = "txt_extra1";
            this.txt_extra1.Size = new System.Drawing.Size(298, 26);
            this.txt_extra1.TabIndex = 255;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(30, 396);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 256;
            this.label2.Text = "EXTRA DETAIL ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(30, 294);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 254;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(186, 292);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(298, 26);
            this.txtEmail.TabIndex = 250;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(186, 234);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(298, 26);
            this.txtPhoneNo.TabIndex = 249;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPhoneNo.Location = new System.Drawing.Point(30, 238);
            this.lblPhoneNo.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(83, 20);
            this.lblPhoneNo.TabIndex = 253;
            this.lblPhoneNo.Text = "Phone No.";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(186, 134);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(811, 75);
            this.txtAddress.TabIndex = 248;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(186, 72);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(811, 26);
            this.txtSupplierName.TabIndex = 247;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddress.Location = new System.Drawing.Point(30, 132);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 252;
            this.lblAddress.Text = "Address";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompanyName.Location = new System.Drawing.Point(30, 75);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(113, 20);
            this.lblCompanyName.TabIndex = 251;
            this.lblCompanyName.Text = "Supplier Name";
            // 
            // SUPPLIER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 600);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbcrdr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOpbal);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.txtSupplierid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.txt_extra1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCompanyName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SUPPLIER";
            this.Text = "SUPPLIER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SUPPLIER_FormClosed);
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_new;
        internal System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cmbcrdr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpbal;
        public System.Windows.Forms.Label lblpath;
        internal System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txtSupplierid;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.TextBox txt_extra1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCompanyName;

    }
}