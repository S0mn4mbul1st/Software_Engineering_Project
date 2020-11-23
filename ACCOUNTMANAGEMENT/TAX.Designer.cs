namespace ACCOUNTMANAGEMENT
{
    partial class TAX
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblpath = new System.Windows.Forms.Label();
            this.dgwTax = new System.Windows.Forms.DataGridView();
            this.GroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtTaxName = new System.Windows.Forms.TextBox();
            this.lbltaxid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttaxper = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTaxType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTax)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(884, 22);
            this.lblpath.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 20);
            this.lblpath.TabIndex = 243;
            // 
            // dgwTax
            // 
            this.dgwTax.AllowUserToAddRows = false;
            this.dgwTax.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite;
            this.dgwTax.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwTax.BackgroundColor = System.Drawing.Color.White;
            this.dgwTax.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTax.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwTax.ColumnHeadersHeight = 24;
            this.dgwTax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupId,
            this.dataGridViewTextBoxColumn1,
            this.TaxationType,
            this.TaxPercentage});
            this.dgwTax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwTax.EnableHeadersVisualStyles = false;
            this.dgwTax.GridColor = System.Drawing.Color.White;
            this.dgwTax.Location = new System.Drawing.Point(33, 172);
            this.dgwTax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwTax.MultiSelect = false;
            this.dgwTax.Name = "dgwTax";
            this.dgwTax.ReadOnly = true;
            this.dgwTax.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTax.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwTax.RowHeadersWidth = 25;
            this.dgwTax.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgwTax.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwTax.RowTemplate.Height = 18;
            this.dgwTax.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwTax.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwTax.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTax.Size = new System.Drawing.Size(621, 400);
            this.dgwTax.TabIndex = 247;
            this.dgwTax.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgwTax_MouseClick);
            // 
            // GroupId
            // 
            this.GroupId.HeaderText = "Id";
            this.GroupId.MinimumWidth = 8;
            this.GroupId.Name = "GroupId";
            this.GroupId.ReadOnly = true;
            this.GroupId.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tax";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // TaxationType
            // 
            this.TaxationType.HeaderText = "Taxation Type";
            this.TaxationType.MinimumWidth = 8;
            this.TaxationType.Name = "TaxationType";
            this.TaxationType.ReadOnly = true;
            this.TaxationType.Width = 150;
            // 
            // TaxPercentage
            // 
            this.TaxPercentage.HeaderText = "Tax %";
            this.TaxPercentage.MinimumWidth = 8;
            this.TaxPercentage.Name = "TaxPercentage";
            this.TaxPercentage.ReadOnly = true;
            this.TaxPercentage.Width = 50;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnDelete);
            this.GroupBox3.Controls.Add(this.btnUpdate);
            this.GroupBox3.Controls.Add(this.btnNew);
            this.GroupBox3.Controls.Add(this.btnSave);
            this.GroupBox3.Controls.Add(this.btnClose);
            this.GroupBox3.Location = new System.Drawing.Point(693, 172);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox3.Size = new System.Drawing.Size(148, 355);
            this.GroupBox3.TabIndex = 246;
            this.GroupBox3.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(12, 217);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 57);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(12, 151);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 57);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(12, 23);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 57);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 88);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 57);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(12, 283);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 57);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(33, 28);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(90, 20);
            this.Label2.TabIndex = 245;
            this.Label2.Text = "TAX NAME";
            // 
            // txtTaxName
            // 
            this.txtTaxName.BackColor = System.Drawing.Color.White;
            this.txtTaxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxName.Location = new System.Drawing.Point(184, 22);
            this.txtTaxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaxName.Name = "txtTaxName";
            this.txtTaxName.Size = new System.Drawing.Size(306, 28);
            this.txtTaxName.TabIndex = 244;
            // 
            // lbltaxid
            // 
            this.lbltaxid.AutoSize = true;
            this.lbltaxid.Location = new System.Drawing.Point(4, 28);
            this.lbltaxid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltaxid.Name = "lbltaxid";
            this.lbltaxid.Size = new System.Drawing.Size(18, 20);
            this.lbltaxid.TabIndex = 248;
            this.lbltaxid.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 250;
            this.label1.Text = "TAX Percentage %";
            // 
            // txttaxper
            // 
            this.txttaxper.BackColor = System.Drawing.Color.White;
            this.txttaxper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaxper.Location = new System.Drawing.Point(184, 126);
            this.txttaxper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttaxper.Name = "txttaxper";
            this.txttaxper.Size = new System.Drawing.Size(162, 28);
            this.txttaxper.TabIndex = 249;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 252;
            this.label3.Text = "Taxation Type";
            // 
            // cmbTaxType
            // 
            this.cmbTaxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaxType.FormattingEnabled = true;
            this.cmbTaxType.Items.AddRange(new object[] {
            "Taxable",
            "Taxfree"});
            this.cmbTaxType.Location = new System.Drawing.Point(184, 78);
            this.cmbTaxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTaxType.Name = "cmbTaxType";
            this.cmbTaxType.Size = new System.Drawing.Size(306, 28);
            this.cmbTaxType.TabIndex = 253;
            // 
            // TAX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(867, 608);
            this.Controls.Add(this.cmbTaxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttaxper);
            this.Controls.Add(this.lbltaxid);
            this.Controls.Add(this.dgwTax);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtTaxName);
            this.Controls.Add(this.lblpath);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TAX";
            this.Text = "TAX";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TAX_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTax)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblpath;
        internal System.Windows.Forms.DataGridView dgwTax;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtTaxName;
        internal System.Windows.Forms.Label lbltaxid;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txttaxper;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxPercentage;
        internal System.Windows.Forms.ComboBox cmbTaxType;
    }
}