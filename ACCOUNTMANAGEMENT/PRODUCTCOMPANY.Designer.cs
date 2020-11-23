namespace ACCOUNTMANAGEMENT
{
    partial class PRODUCTCOMPANY
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
            this.dgwCompany = new System.Windows.Forms.DataGridView();
            this.GroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblpath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompany)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCompany
            // 
            this.dgwCompany.AllowUserToAddRows = false;
            this.dgwCompany.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite;
            this.dgwCompany.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwCompany.BackgroundColor = System.Drawing.Color.White;
            this.dgwCompany.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwCompany.ColumnHeadersHeight = 24;
            this.dgwCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupId,
            this.dataGridViewTextBoxColumn1});
            this.dgwCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwCompany.EnableHeadersVisualStyles = false;
            this.dgwCompany.GridColor = System.Drawing.Color.White;
            this.dgwCompany.Location = new System.Drawing.Point(116, 85);
            this.dgwCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwCompany.MultiSelect = false;
            this.dgwCompany.Name = "dgwCompany";
            this.dgwCompany.ReadOnly = true;
            this.dgwCompany.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwCompany.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwCompany.RowHeadersWidth = 25;
            this.dgwCompany.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgwCompany.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwCompany.RowTemplate.Height = 18;
            this.dgwCompany.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwCompany.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCompany.Size = new System.Drawing.Size(404, 400);
            this.dgwCompany.TabIndex = 13;
            this.dgwCompany.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgwCompany_MouseClick);
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
            this.dataGridViewTextBoxColumn1.HeaderText = "Company";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(30, 28);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 20);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Company :";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnDelete);
            this.GroupBox3.Controls.Add(this.btnNew);
            this.GroupBox3.Controls.Add(this.btnSave);
            this.GroupBox3.Controls.Add(this.btnClose);
            this.GroupBox3.Location = new System.Drawing.Point(549, 25);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox3.Size = new System.Drawing.Size(148, 292);
            this.GroupBox3.TabIndex = 12;
            this.GroupBox3.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(12, 153);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 57);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnClose.Location = new System.Drawing.Point(12, 219);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 57);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(126, 25);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(396, 28);
            this.txtCompanyName.TabIndex = 10;
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(710, 22);
            this.lblpath.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 20);
            this.lblpath.TabIndex = 242;
            // 
            // PRODUCTCOMPANY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(723, 528);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.dgwCompany);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.txtCompanyName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PRODUCTCOMPANY";
            this.Text = "PRODUCTCOMPANY";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PRODUCTCOMPANY_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompany)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.DataGridView dgwCompany;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public System.Windows.Forms.Label lblpath;
    }
}