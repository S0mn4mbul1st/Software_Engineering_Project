namespace ACCOUNTMANAGEMENT
{
    partial class STOCKcs
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
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblpath = new System.Windows.Forms.Label();
            this.dgvinstallment = new System.Windows.Forms.DataGridView();
            this.ITEMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALINQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALOUTQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURRENTSTOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(213, 65);
            this.dtpDateTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(178, 26);
            this.dtpDateTo.TabIndex = 244;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(9, 65);
            this.dtpDateFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(178, 26);
            this.dtpDateFrom.TabIndex = 244;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.dtpDateTo);
            this.GroupBox2.Controls.Add(this.dtpDateFrom);
            this.GroupBox2.Controls.Add(this.btnSearch);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Location = new System.Drawing.Point(30, 26);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(524, 138);
            this.GroupBox2.TabIndex = 246;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search By Check IN Date :";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(400, 46);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 60);
            this.btnSearch.TabIndex = 108;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(214, 35);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(38, 20);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "To :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(15, 35);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 20);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "From :";
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(1695, 23);
            this.lblpath.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 20);
            this.lblpath.TabIndex = 245;
            // 
            // dgvinstallment
            // 
            this.dgvinstallment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvinstallment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinstallment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEMID,
            this.ITEMNAME,
            this.TOTALINQTY,
            this.TOTALOUTQTY,
            this.CURRENTSTOCK});
            this.dgvinstallment.Location = new System.Drawing.Point(18, 194);
            this.dgvinstallment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvinstallment.Name = "dgvinstallment";
            this.dgvinstallment.RowHeadersWidth = 62;
            this.dgvinstallment.Size = new System.Drawing.Size(1844, 660);
            this.dgvinstallment.TabIndex = 244;
            // 
            // ITEMID
            // 
            this.ITEMID.HeaderText = "ITEM ID";
            this.ITEMID.MinimumWidth = 8;
            this.ITEMID.Name = "ITEMID";
            this.ITEMID.Width = 150;
            // 
            // ITEMNAME
            // 
            this.ITEMNAME.HeaderText = "ITEM NAME";
            this.ITEMNAME.MinimumWidth = 8;
            this.ITEMNAME.Name = "ITEMNAME";
            this.ITEMNAME.Width = 150;
            // 
            // TOTALINQTY
            // 
            this.TOTALINQTY.HeaderText = "TOTAL IN QTY";
            this.TOTALINQTY.MinimumWidth = 8;
            this.TOTALINQTY.Name = "TOTALINQTY";
            this.TOTALINQTY.Width = 150;
            // 
            // TOTALOUTQTY
            // 
            this.TOTALOUTQTY.HeaderText = "TOTAL OUT QTY";
            this.TOTALOUTQTY.MinimumWidth = 8;
            this.TOTALOUTQTY.Name = "TOTALOUTQTY";
            this.TOTALOUTQTY.Width = 150;
            // 
            // CURRENTSTOCK
            // 
            this.CURRENTSTOCK.HeaderText = "CURRENT STOCK";
            this.CURRENTSTOCK.MinimumWidth = 8;
            this.CURRENTSTOCK.Name = "CURRENTSTOCK";
            this.CURRENTSTOCK.Width = 150;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btn_close);
            this.GroupBox1.Controls.Add(this.btnView);
            this.GroupBox1.Controls.Add(this.btnReset);
            this.GroupBox1.Controls.Add(this.btnExportExcel);
            this.GroupBox1.Location = new System.Drawing.Point(1227, 23);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Size = new System.Drawing.Size(634, 138);
            this.GroupBox1.TabIndex = 247;
            this.GroupBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(482, 42);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(124, 55);
            this.btn_close.TabIndex = 270;
            this.btn_close.Text = "&Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btnView
            // 
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(24, 43);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(150, 60);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "&View Report";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(318, 42);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(156, 60);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.Text = "&Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(182, 42);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 60);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // STOCKcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1900, 912);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.dgvinstallment);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "STOCKcs";
            this.Text = "STOCKcs";
            this.Load += new System.EventHandler(this.STOCKcs_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker dtpDateTo;
        internal System.Windows.Forms.DateTimePicker dtpDateFrom;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.DataGridView dgvinstallment;
        internal System.Windows.Forms.Button btnView;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALINQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALOUTQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURRENTSTOCK;
        internal System.Windows.Forms.Button btn_close;
        internal System.Windows.Forms.Button btnReset;
    }
}