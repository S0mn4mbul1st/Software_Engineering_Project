namespace ACCOUNTMANAGEMENT
{
    partial class icommDB
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
            this.dgvinstallment = new System.Windows.Forms.DataGridView();
            this.CALLID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROBLEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLOYEENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VISITDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VISITTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CALLSTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROBLEMFOUND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblpath = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1548, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 283;
            // 
            // dgvinstallment
            // 
            this.dgvinstallment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvinstallment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinstallment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CALLID,
            this.ACCOUNTNAME,
            this.ADDRESS,
            this.PHONE,
            this.ITEMNAME,
            this.PROBLEM,
            this.EMPLOYEENAME,
            this.VISITDATE,
            this.VISITTIME,
            this.CALLSTATUS,
            this.PROBLEMFOUND});
            this.dgvinstallment.Location = new System.Drawing.Point(12, 191);
            this.dgvinstallment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvinstallment.Name = "dgvinstallment";
            this.dgvinstallment.RowHeadersWidth = 62;
            this.dgvinstallment.Size = new System.Drawing.Size(1872, 605);
            this.dgvinstallment.TabIndex = 281;

            this.CALLID.HeaderText = "CALLID";
            this.CALLID.MinimumWidth = 8;
            this.CALLID.Name = "CALLID";
            this.CALLID.Width = 150;

            this.ACCOUNTNAME.HeaderText = "CUSTOMER NAME";
            this.ACCOUNTNAME.MinimumWidth = 8;
            this.ACCOUNTNAME.Name = "ACCOUNTNAME";
            this.ACCOUNTNAME.Width = 150;

            this.ADDRESS.HeaderText = "ADDRESS";
            this.ADDRESS.MinimumWidth = 8;
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Width = 150;
 
            this.PHONE.HeaderText = "PHONE NO";
            this.PHONE.MinimumWidth = 8;
            this.PHONE.Name = "PHONE";
            this.PHONE.Width = 150;
 
            this.ITEMNAME.HeaderText = "ITEM NAME";
            this.ITEMNAME.MinimumWidth = 8;
            this.ITEMNAME.Name = "ITEMNAME";
            this.ITEMNAME.Width = 150;

            this.PROBLEM.HeaderText = "PROBLEM";
            this.PROBLEM.MinimumWidth = 8;
            this.PROBLEM.Name = "PROBLEM";
            this.PROBLEM.Width = 150;
 
            this.EMPLOYEENAME.HeaderText = "EMPLOYEE NAME";
            this.EMPLOYEENAME.MinimumWidth = 8;
            this.EMPLOYEENAME.Name = "EMPLOYEENAME";
            this.EMPLOYEENAME.Width = 150;

            this.VISITDATE.HeaderText = "VISIT DATE";
            this.VISITDATE.MinimumWidth = 8;
            this.VISITDATE.Name = "VISITDATE";
            this.VISITDATE.Width = 150;

            this.VISITTIME.HeaderText = "VISIT TIME";
            this.VISITTIME.MinimumWidth = 8;
            this.VISITTIME.Name = "VISITTIME";
            this.VISITTIME.Width = 150;

            this.CALLSTATUS.HeaderText = "STATUS";
            this.CALLSTATUS.MinimumWidth = 8;
            this.CALLSTATUS.Name = "CALLSTATUS";
            this.CALLSTATUS.Width = 150;
   
            this.PROBLEMFOUND.HeaderText = "DIGNOSYS BY ENGINEER";
            this.PROBLEMFOUND.MinimumWidth = 8;
            this.PROBLEMFOUND.Name = "PROBLEMFOUND";
            this.PROBLEMFOUND.Width = 150;
 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(1563, 48);
            this.lblpath.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 20);
            this.lblpath.TabIndex = 280;

            this.GroupBox2.Controls.Add(this.btnView);
            this.GroupBox2.Controls.Add(this.dtpDateTo);
            this.GroupBox2.Controls.Add(this.dtpDateFrom);
            this.GroupBox2.Controls.Add(this.btnSearch);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Location = new System.Drawing.Point(45, 18);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(600, 147);
            this.GroupBox2.TabIndex = 284;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search By Check IN Date :";

            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(448, 84);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(112, 53);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "&View Report";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);

            this.dtpDateTo.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(213, 65);
            this.dtpDateTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(178, 26);
            this.dtpDateTo.TabIndex = 244;

            this.dtpDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(19, 65);
            this.dtpDateFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(178, 26);
            this.dtpDateFrom.TabIndex = 244;

            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.Location = new System.Drawing.Point(448, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 60);
            this.btnSearch.TabIndex = 108;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
   
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.DimGray;
            this.Label4.Location = new System.Drawing.Point(209, 35);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(38, 20);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "To :";
   
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(15, 35);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 20);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "From :";
    
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1902, 818);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvinstallment);
            this.Controls.Add(this.lblpath);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "icommDB";
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvinstallment;
        public System.Windows.Forms.Label lblpath;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DateTimePicker dtpDateTo;
        internal System.Windows.Forms.DateTimePicker dtpDateFrom;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CALLID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROBLEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn VISITDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VISITTIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CALLSTATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROBLEMFOUND;
        internal System.Windows.Forms.Button btnView;
    }
}