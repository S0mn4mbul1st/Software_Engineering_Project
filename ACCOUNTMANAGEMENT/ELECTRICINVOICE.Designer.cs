namespace ACCOUNTMANAGEMENT
{
    partial class ELECTRICINVOICE
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
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvinstallment = new System.Windows.Forms.DataGridView();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChequeno = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(238, 97);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(464, 28);
            this.cmbCustomer.TabIndex = 249;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompanyName.Location = new System.Drawing.Point(86, 102);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(124, 20);
            this.lblCompanyName.TabIndex = 248;
            this.lblCompanyName.Text = "Customer Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(1356, 208);
            this.label17.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 20);
            this.label17.TabIndex = 251;
            this.label17.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(1443, 199);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(146, 26);
            this.dtpDate.TabIndex = 250;
            // 
            // dgvinstallment
            // 
            this.dgvinstallment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvinstallment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinstallment.Location = new System.Drawing.Point(74, 269);
            this.dgvinstallment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvinstallment.Name = "dgvinstallment";
            this.dgvinstallment.RowHeadersWidth = 62;
            this.dgvinstallment.Size = new System.Drawing.Size(1252, 382);
            this.dgvinstallment.TabIndex = 252;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(238, 35);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(148, 26);
            this.txtInvoiceNo.TabIndex = 254;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(70, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 253;
            this.label6.Text = "Bill No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(99, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 255;
            this.label1.Text = "No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(840, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 256;
            this.label2.Text = "Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(676, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 257;
            this.label3.Text = "Pcs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(356, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 258;
            this.label4.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1052, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 259;
            this.label5.Text = "Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(1212, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 260;
            this.label7.Text = "Amount";
            // 
            // txtChequeno
            // 
            this.txtChequeno.Location = new System.Drawing.Point(74, 208);
            this.txtChequeno.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtChequeno.Name = "txtChequeno";
            this.txtChequeno.Size = new System.Drawing.Size(82, 26);
            this.txtChequeno.TabIndex = 261;
            this.txtChequeno.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 208);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 26);
            this.textBox1.TabIndex = 262;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(624, 208);
            this.textBox2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 26);
            this.textBox2.TabIndex = 263;
            this.textBox2.Visible = false;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(993, 208);
            this.txtRate.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(152, 26);
            this.txtRate.TabIndex = 265;
            this.txtRate.Visible = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(1162, 208);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(162, 26);
            this.txtAmount.TabIndex = 266;
            this.txtAmount.Visible = false;
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "L.S.",
            "Kg",
            "Gram",
            "1Job",
            "Pcs"});
            this.cmbUnit.Location = new System.Drawing.Point(778, 208);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(184, 28);
            this.cmbUnit.TabIndex = 267;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btn_new);
            this.GroupBox2.Controls.Add(this.btn_delete);
            this.GroupBox2.Controls.Add(this.btn_save);
            this.GroupBox2.Controls.Add(this.btn_close);
            this.GroupBox2.Location = new System.Drawing.Point(1378, 295);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(152, 290);
            this.GroupBox2.TabIndex = 268;
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
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(12, 149);
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
            this.btn_save.Location = new System.Drawing.Point(12, 83);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(124, 55);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(12, 214);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(124, 55);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "&Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // ELECTRICINVOICE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1650, 863);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtChequeno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvinstallment);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.lblCompanyName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ELECTRICINVOICE";
            this.Text = "ELECTRICINVOICE";
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label label17;
        internal System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvinstallment;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChequeno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbUnit;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btn_new;
        internal System.Windows.Forms.Button btn_delete;
        internal System.Windows.Forms.Button btn_save;
        internal System.Windows.Forms.Button btn_close;
    }
}