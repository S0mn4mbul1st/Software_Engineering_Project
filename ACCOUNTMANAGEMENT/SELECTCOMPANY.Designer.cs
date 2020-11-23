namespace ACCOUNTMANAGEMENT
{
    partial class SELECTCOMPANY
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
            this.dgvselectcompany = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.btn_fyear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvselectcompany)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvselectcompany
            // 
            this.dgvselectcompany.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvselectcompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvselectcompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.PATH});
            this.dgvselectcompany.Location = new System.Drawing.Point(39, 31);
            this.dgvselectcompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvselectcompany.Name = "dgvselectcompany";
            this.dgvselectcompany.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvselectcompany.RowHeadersWidth = 62;
            this.dgvselectcompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvselectcompany.Size = new System.Drawing.Size(1583, 607);
            this.dgvselectcompany.TabIndex = 0;
            this.dgvselectcompany.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvselectcompany_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "COMPANYNAME";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 500;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FINANCIALYEARFROM";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // PATH
            // 
            this.PATH.HeaderText = "PATH";
            this.PATH.MinimumWidth = 8;
            this.PATH.Name = "PATH";
            this.PATH.Width = 250;
            // 
            // btn_new
            // 
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(165, 666);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(398, 112);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "Add a company";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_Backup
            // 
            this.btn_Backup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Backup.Location = new System.Drawing.Point(588, 666);
            this.btn_Backup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(356, 112);
            this.btn_Backup.TabIndex = 2;
            this.btn_Backup.Text = "Save the data";
            this.btn_Backup.UseVisualStyleBackColor = true;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // btn_fyear
            // 
            this.btn_fyear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fyear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fyear.Location = new System.Drawing.Point(974, 666);
            this.btn_fyear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_fyear.Name = "btn_fyear";
            this.btn_fyear.Size = new System.Drawing.Size(369, 112);
            this.btn_fyear.TabIndex = 3;
            this.btn_fyear.Text = "Time Shifter";
            this.btn_fyear.UseVisualStyleBackColor = true;
            // 
            // SELECTCOMPANY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1653, 783);
            this.Controls.Add(this.btn_fyear);
            this.Controls.Add(this.btn_Backup);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.dgvselectcompany);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SELECTCOMPANY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SELECTCOMPANY";
            ((System.ComponentModel.ISupportInitialize)(this.dgvselectcompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvselectcompany;
        internal System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATH;
        internal System.Windows.Forms.Button btn_Backup;
        internal System.Windows.Forms.Button btn_fyear;
    }
}