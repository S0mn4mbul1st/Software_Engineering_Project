namespace ACCOUNTMANAGEMENT
{
    partial class Login
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
            this.LinkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.lblpath = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblcompanyname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkLabel2
            // 
            this.LinkLabel2.AutoSize = true;
            this.LinkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LinkLabel2.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel2.Location = new System.Drawing.Point(284, 289);
            this.LinkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLabel2.Name = "LinkLabel2";
            this.LinkLabel2.Size = new System.Drawing.Size(219, 33);
            this.LinkLabel2.TabIndex = 20;
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.Text = "Forgot Password";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(438, 225);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(141, 35);
            this.Cancel.TabIndex = 18;
            this.Cancel.Text = "&Cancel";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(288, 225);
            this.OK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(141, 35);
            this.OK.TabIndex = 17;
            this.OK.Text = "&OK";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(288, 166);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '♠';
            this.Password.Size = new System.Drawing.Size(289, 26);
            this.Password.TabIndex = 16;
            // 
            // UserID
            // 
            this.UserID.Location = new System.Drawing.Point(286, 100);
            this.UserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(290, 26);
            this.UserID.TabIndex = 14;
            this.UserID.Text = "admin";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(284, 135);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(330, 35);
            this.PasswordLabel.TabIndex = 15;
            this.PasswordLabel.Text = "&Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Location = new System.Drawing.Point(284, 69);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(330, 35);
            this.UsernameLabel.TabIndex = 12;
            this.UsernameLabel.Text = "&User ID";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(615, 22);
            this.lblpath.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 20);
            this.lblpath.TabIndex = 241;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Location = new System.Drawing.Point(26, 32);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(248, 297);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 13;
            this.LogoPictureBox.TabStop = false;
            // 
            // lblcompanyname
            // 
            this.lblcompanyname.AutoSize = true;
            this.lblcompanyname.Location = new System.Drawing.Point(60, 8);
            this.lblcompanyname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcompanyname.Name = "lblcompanyname";
            this.lblcompanyname.Size = new System.Drawing.Size(138, 20);
            this.lblcompanyname.TabIndex = 242;
            this.lblcompanyname.Text = "COMPANY NAME";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 348);
            this.Controls.Add(this.lblcompanyname);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.LinkLabel2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.LinkLabel LinkLabel2;
        internal System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.Button OK;
        internal System.Windows.Forms.TextBox Password;
        internal System.Windows.Forms.TextBox UserID;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UsernameLabel;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
        public System.Windows.Forms.Label lblpath;
        public System.Windows.Forms.Label lblcompanyname;
    }
}

