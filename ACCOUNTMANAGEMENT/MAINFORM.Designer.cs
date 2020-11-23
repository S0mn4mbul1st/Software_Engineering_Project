namespace ACCOUNTMANAGEMENT
{
    partial class MAINFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAINFORM));
            this.lblcompanypath = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotSellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotSellDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblcompanyname = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcompanypath
            // 
            this.lblcompanypath.AutoSize = true;
            this.lblcompanypath.Location = new System.Drawing.Point(830, 9);
            this.lblcompanypath.Name = "lblcompanypath";
            this.lblcompanypath.Size = new System.Drawing.Size(92, 13);
            this.lblcompanypath.TabIndex = 0;
            this.lblcompanypath.Text = "COMPANY PATH";
            this.lblcompanypath.TextChanged += new System.EventHandler(this.lblcompanypath_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.itemMasterToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.companyToolStripMenuItem.Text = "Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // itemMasterToolStripMenuItem
            // 
            this.itemMasterToolStripMenuItem.Name = "itemMasterToolStripMenuItem";
            this.itemMasterToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.itemMasterToolStripMenuItem.Text = "Item Master";
            this.itemMasterToolStripMenuItem.Visible = false; 
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plotSellToolStripMenuItem,
            this.receiptToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // plotSellToolStripMenuItem
            // 
            this.plotSellToolStripMenuItem.Name = "plotSellToolStripMenuItem";
            this.plotSellToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.plotSellToolStripMenuItem.Text = "Plot Sell";
            this.plotSellToolStripMenuItem.Click += new System.EventHandler(this.plotSellToolStripMenuItem_Click);
            // 
            // receiptToolStripMenuItem
            // 
            this.receiptToolStripMenuItem.Name = "receiptToolStripMenuItem";
            this.receiptToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.receiptToolStripMenuItem.Text = "Receipt";
            this.receiptToolStripMenuItem.Click += new System.EventHandler(this.receiptToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plotSellDetailToolStripMenuItem,
            this.receiptDetailToolStripMenuItem});
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.registerToolStripMenuItem.Text = "Register";
            // 
            // plotSellDetailToolStripMenuItem
            // 
            this.plotSellDetailToolStripMenuItem.Name = "plotSellDetailToolStripMenuItem";
            this.plotSellDetailToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.plotSellDetailToolStripMenuItem.Text = "Plot Sell Detail";
            this.plotSellDetailToolStripMenuItem.Click += new System.EventHandler(this.plotSellDetailToolStripMenuItem_Click);
            // 
            // receiptDetailToolStripMenuItem
            // 
            this.receiptDetailToolStripMenuItem.Name = "receiptDetailToolStripMenuItem";
            this.receiptDetailToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.receiptDetailToolStripMenuItem.Text = "Receipt Detail";
            this.receiptDetailToolStripMenuItem.Click += new System.EventHandler(this.receiptDetailToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ledgerToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // ledgerToolStripMenuItem
            // 
            this.ledgerToolStripMenuItem.Name = "ledgerToolStripMenuItem";
            this.ledgerToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.ledgerToolStripMenuItem.Text = "Ledger";
            this.ledgerToolStripMenuItem.Click += new System.EventHandler(this.ledgerToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.eXITToolStripMenuItem.Text = "E&XIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // lblcompanyname
            // 
            this.lblcompanyname.AutoSize = true;
            this.lblcompanyname.Location = new System.Drawing.Point(421, 7);
            this.lblcompanyname.Name = "lblcompanyname";
            this.lblcompanyname.Size = new System.Drawing.Size(94, 13);
            this.lblcompanyname.TabIndex = 3;
            this.lblcompanyname.Text = "COMPANY NAME";
            // 
            // MAINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 518);
            this.Controls.Add(this.lblcompanyname);
            this.Controls.Add(this.lblcompanypath);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MAINFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblcompanypath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotSellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotSellDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiptDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledgerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        public System.Windows.Forms.Label lblcompanyname;
        private System.Windows.Forms.ToolStripMenuItem itemMasterToolStripMenuItem;
    }
}