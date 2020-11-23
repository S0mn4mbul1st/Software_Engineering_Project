namespace ACCOUNTMANAGEMENT
{
    partial class LEDGERAM
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblpath = new System.Windows.Forms.Label();
            this.VOUCHERTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvinstallment = new System.Windows.Forms.DataGridView();
            this.VOUCHERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEBIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1434, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 274;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(216, 57);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(464, 28);
            this.cmbCustomer.TabIndex = 264;
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_KeyDown);
            // 
            // DATE
            // 
            this.DATE.HeaderText = "DATE";
            this.DATE.MinimumWidth = 8;
            this.DATE.Name = "DATE";
            this.DATE.Width = 150;
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(1449, 14);
            this.lblpath.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 20);
            this.lblpath.TabIndex = 271;
            // 
            // VOUCHERTYPE
            // 
            this.VOUCHERTYPE.HeaderText = "VOUCHER TYPE";
            this.VOUCHERTYPE.MinimumWidth = 8;
            this.VOUCHERTYPE.Name = "VOUCHERTYPE";
            this.VOUCHERTYPE.Width = 250;
            // 
            // dgvinstallment
            // 
            this.dgvinstallment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvinstallment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinstallment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DATE,
            this.VOUCHERTYPE,
            this.VOUCHERNO,
            this.DEBIT,
            this.CREDIT,
            this.BAL});
            this.dgvinstallment.Location = new System.Drawing.Point(33, 134);
            this.dgvinstallment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvinstallment.Name = "dgvinstallment";
            this.dgvinstallment.RowHeadersWidth = 62;
            this.dgvinstallment.Size = new System.Drawing.Size(1066, 605);
            this.dgvinstallment.TabIndex = 272;
            // 
            // VOUCHERNO
            // 
            this.VOUCHERNO.HeaderText = "VOUCHER NO";
            this.VOUCHERNO.MinimumWidth = 8;
            this.VOUCHERNO.Name = "VOUCHERNO";
            this.VOUCHERNO.Width = 150;
            // 
            // DEBIT
            // 
            this.DEBIT.HeaderText = "DEBIT";
            this.DEBIT.MinimumWidth = 8;
            this.DEBIT.Name = "DEBIT";
            this.DEBIT.Width = 150;
            // 
            // CREDIT
            // 
            this.CREDIT.HeaderText = "CREDIT";
            this.CREDIT.MinimumWidth = 8;
            this.CREDIT.Name = "CREDIT";
            this.CREDIT.Width = 150;
            // 
            // BAL
            // 
            this.BAL.HeaderText = "BALANCE";
            this.BAL.MinimumWidth = 8;
            this.BAL.Name = "BAL";
            this.BAL.Width = 150;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompanyName.Location = new System.Drawing.Point(60, 62);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(124, 20);
            this.lblCompanyName.TabIndex = 270;
            this.lblCompanyName.Text = "Customer Name";
            // 
            // btn_new
            // 
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(708, 42);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(124, 55);
            this.btn_new.TabIndex = 263;
            this.btn_new.Text = "&New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(986, 42);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(124, 55);
            this.btn_close.TabIndex = 269;
            this.btn_close.Text = "&Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(851, 42);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 60);
            this.btnSearch.TabIndex = 268;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LEDGERAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1588, 814);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.dgvinstallment);
            this.Controls.Add(this.lblCompanyName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LEDGERAM";
            this.Text = "LEDGERAM";
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_new;
        internal System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomer;
        internal System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        public System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCHERTYPE;
        private System.Windows.Forms.DataGridView dgvinstallment;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCHERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEBIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAL;
        private System.Windows.Forms.Label lblCompanyName;
    }
}