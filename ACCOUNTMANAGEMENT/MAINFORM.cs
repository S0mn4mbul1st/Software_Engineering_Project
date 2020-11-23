using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACCOUNTMANAGEMENT
{
    public partial class MAINFORM : Form
    {
        public MAINFORM()
        {
            InitializeComponent();
     
        }

        private void Login()
        {
            Login frm = new Login();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CUSTOMER frm = new CUSTOMER();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COMPANY frm = new COMPANY();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;
        }

        private void plotSellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PLOTSELL frm = new PLOTSELL();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RECEIPT frm = new RECEIPT();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;
        }

        private void plotSellDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PLOTSELLDETAIL frm = new PLOTSELLDETAIL();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;
        }

        private void receiptDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RECEIPTDETAIL frm = new RECEIPTDETAIL();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;
        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ledger frm = new Ledger();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;
        }

        private void lblcompanypath_TextChanged(object sender, EventArgs e)
        {
           
            

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                        DialogResult result1 = MessageBox.Show("DO YOU WANT TO TAKE BACKUP?", "Account Management",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result1 != DialogResult.Yes)
                         
                            this.Close();
        }

        private void salesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SALESINVOICEcs frm = new SALESINVOICEcs();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;
        }

        private void quickReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RECEIPTIT frm = new RECEIPTIT();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;
        }

        private void purchaseInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase frm = new Purchase();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;
        
        }

        private void quickPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PAYMENT frm = new PAYMENT();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            STOCKcs frm = new STOCKcs();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;
        }

        private void customerLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LEDGERAM frm = new LEDGERAM();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;
        }

        private void callRecorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CALLRECORDER frm = new CALLRECORDER();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;
        }

        private void callRecorderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            icommDB frm = new icommDB();
            frm.MdiParent = this;
            frm.Show();
            frm.lblpath.Text = lblcompanypath.Text;
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
