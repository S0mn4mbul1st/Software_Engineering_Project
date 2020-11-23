namespace ACCOUNTMANAGEMENT
{
    partial class Ledger
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblpath = new System.Windows.Forms.Label();
            this.dgvinstallment = new System.Windows.Forms.DataGridView();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VOUCHERTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VOUCHERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEBIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblcustid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlotSellId = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbSurveyNo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbPlotNo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompanyName.Location = new System.Drawing.Point(52, 66);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(124, 20);
            this.lblCompanyName.TabIndex = 208;
            this.lblCompanyName.Text = "Customer Name";
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(1442, 18);
            this.lblpath.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 20);
            this.lblpath.TabIndex = 241;
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
            this.dgvinstallment.Location = new System.Drawing.Point(26, 162);
            this.dgvinstallment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvinstallment.Name = "dgvinstallment";
            this.dgvinstallment.RowHeadersWidth = 62;
            this.dgvinstallment.Size = new System.Drawing.Size(1372, 605);
            this.dgvinstallment.TabIndex = 245;
            // 
            // DATE
            // 
            this.DATE.HeaderText = "DATE";
            this.DATE.MinimumWidth = 8;
            this.DATE.Name = "DATE";
            this.DATE.Width = 150;
            // 
            // VOUCHERTYPE
            // 
            this.VOUCHERTYPE.HeaderText = "VOUCHER TYPE";
            this.VOUCHERTYPE.MinimumWidth = 8;
            this.VOUCHERTYPE.Name = "VOUCHERTYPE";
            this.VOUCHERTYPE.Width = 250;
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
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(208, 62);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(464, 28);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.Leave += new System.EventHandler(this.cmbCustomer_Leave);
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcustid.Location = new System.Drawing.Point(21, 66);
            this.lblcustid.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(18, 20);
            this.lblcustid.TabIndex = 248;
            this.lblcustid.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1426, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 249;
            // 
            // cmbPlotSellId
            // 
            this.cmbPlotSellId.FormattingEnabled = true;
            this.cmbPlotSellId.Location = new System.Drawing.Point(945, 115);
            this.cmbPlotSellId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPlotSellId.Name = "cmbPlotSellId";
            this.cmbPlotSellId.Size = new System.Drawing.Size(184, 28);
            this.cmbPlotSellId.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(790, 123);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 20);
            this.label13.TabIndex = 262;
            this.label13.Text = "Against Plot Sell Id";
            // 
            // cmbSurveyNo
            // 
            this.cmbSurveyNo.FormattingEnabled = true;
            this.cmbSurveyNo.Location = new System.Drawing.Point(568, 109);
            this.cmbSurveyNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSurveyNo.Name = "cmbSurveyNo";
            this.cmbSurveyNo.Size = new System.Drawing.Size(184, 28);
            this.cmbSurveyNo.TabIndex = 3;
            this.cmbSurveyNo.Leave += new System.EventHandler(this.cmbSurveyNo_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(414, 112);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 20);
            this.label12.TabIndex = 260;
            this.label12.Text = "Against Survey No";
            // 
            // cmbPlotNo
            // 
            this.cmbPlotNo.FormattingEnabled = true;
            this.cmbPlotNo.Location = new System.Drawing.Point(207, 106);
            this.cmbPlotNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPlotNo.Name = "cmbPlotNo";
            this.cmbPlotNo.Size = new System.Drawing.Size(184, 28);
            this.cmbPlotNo.TabIndex = 2;
            this.cmbPlotNo.Leave += new System.EventHandler(this.cmbPlotNo_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(42, 114);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 258;
            this.label10.Text = "Against Plot No";
            // 
            // btn_new
            // 
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(840, 34);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(124, 55);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "&New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(1149, 34);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(124, 55);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "&Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1000, 34);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 60);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Ledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1460, 748);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.cmbPlotSellId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbSurveyNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbPlotNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcustid);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvinstallment);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.lblCompanyName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ledger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledger";
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        public System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.DataGridView dgvinstallment;
        internal System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblcustid;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPlotSellId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSurveyNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbPlotNo;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Button btn_new;
        internal System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCHERTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCHERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEBIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAL;
    }
}