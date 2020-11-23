using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ACCOUNTMANAGEMENT
{
    public partial class RECEIPTIT : Form
    {
        public RECEIPTIT()
        {
            InitializeComponent();
        }
        OleDbDataReader rdr = null;
        DataTable dtable = new DataTable();
        OleDbConnection con = null;
        OleDbCommand cmd = null;

        DataTable dt = new DataTable();
        string PAID = "PAID";
        string a, SDID;
        public void Reset()
        {
            try
            {

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT MAX(VOCHERNO) as  VOUCHERNO FROM LedgerPosting WHERE VOUCHERTYPE='" + "QUICK RECEIPT" + "' ";
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr.IsDBNull(rdr.GetOrdinal("VOUCHERNO")))
                    {
                        txtReceiptNo.Text = Convert.ToString("1");
                    }
                    else
                    {
                        txtReceiptNo.Text = Convert.ToString(Convert.ToInt64(rdr["VOUCHERNO"]) + 1);
                    }
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                con.Close();




                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                String sql = "select ACCOUNTNAME from Account";
                cmd = new OleDbCommand(sql, con);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    cmbCustomer.Items.Add(rdr[0]);
                }
                con.Close();

                cmbCustomer.Text = "";
                cmbpaymentmode.Text = "Cash";
                txtChequeno.Text = "";
                txttotalamount.Text = "";
                txt_extra1.Text = "";
                label1.Hide();
                label4.Hide();
                dtpChequeDate.Hide();
                txtChequeno.Hide();

                txttotalamount.Text = "";
                 
                btn_save.Enabled = true;
                btn_delete.Enabled = false; 
                cmbCustomer.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void print()
        {
            DialogResult result1 = MessageBox.Show("Do you want to print this Receipt?", "Account Management",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                try
                {

                    CrystalReport.QuickReceipt rpt = new CrystalReport.QuickReceipt();
                    //The report you created.
                    cmd = new OleDbCommand();
                    OleDbDataAdapter myDA = new OleDbDataAdapter();
                    DataSet myDS = new DataSet();
                    //The DataSet you created.
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT LEDGERPOSTINGID,LDATE,ACCOUNTID,ACCOUNTNAME,VOUCHERTYPE,VOCHERNO,CREDIT,EXTRA,EXTRA1,EXTRA2,EXTRA3,EXTRA4 FROM  LedgerPosting   WHERE  LEDGERPOSTINGID =" + SDID + "";
                    cmd.CommandType = CommandType.Text;
                    myDA.SelectCommand = cmd;
                    myDA.Fill(myDS, "LedgerPosting");


                    cmd.CommandText = "SELECT Company.COMPANYNAME,Company.ADDRESS,Company.PHONENO,Company.EMAIL,Company.WEB,Company.TINNO,Company.CSTNO,Company.EXTRA1,Company.EXTRA2 FROM Company ";
                    cmd.CommandType = CommandType.Text;
                    myDA.SelectCommand = cmd;
                    myDA.Fill(myDS, "Company");

                    con.Close();
                    rpt.SetDataSource(myDS);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public void LEDGERPOSTINGIDGENERATION()
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT MAX(LEDGERPOSTINGID) as  LEDGERPOSTINGID FROM LedgerPosting";
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr.IsDBNull(rdr.GetOrdinal("LEDGERPOSTINGID")))
                    {

                        SDID = Convert.ToString("1");
                    }
                    else
                    {
                        SDID = Convert.ToString(Convert.ToInt16(rdr["LEDGERPOSTINGID"]) + 1);
                    }
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                con.Close();



            }





            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                LEDGERPOSTINGIDGENERATION();
                if (cmbpaymentmode.Text == "Cash")
                {
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    string cb1 = "insert into LedgerPosting (LEDGERPOSTINGID,LDATE,ACCOUNTID,ACCOUNTNAME,VOUCHERTYPE,VOCHERNO,CREDIT) VALUES ('" + SDID + "','" + dtpReceiptDate.Text + "'," + ",'" + cmbCustomer.Text + "','" + "QUICK RECEIPT" + "'," + txtReceiptNo.Text + "," + txttotalamount.Text + ")";
                    cmd = new OleDbCommand(cb1);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();

                    MessageBox.Show("Successfully saved", "Receipt Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    print();
                    Reset();
                    return;

                }
                if (cmbpaymentmode.Text == "Cheque")
                {
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    string cb1 = "insert into LedgerPosting (LEDGERPOSTINGID,LDATE,ACCOUNTID,ACCOUNTNAME,VOUCHERTYPE,VOCHERNO,CREDIT,EXTRA,EXTRA1) VALUES ('" + SDID + "','" + dtpReceiptDate.Text + "',"  + ",'" + cmbCustomer.Text + "','" + "QUICK RECEIPT" + "'," + txtReceiptNo.Text + "," + txttotalamount.Text + ",'" + txtChequeno.Text + "','" + dtpChequeDate.Text + "')";
                    cmd = new OleDbCommand(cb1);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();

                    MessageBox.Show("Successfully saved", "Receipt Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    print();
                    Reset();
                    return;

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    if (cmbCustomer.Text != null)
                    {
                        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                        con.Open();
                        cmd = con.CreateCommand();

                        cmd.CommandText = "SELECT ACCOUNTID FROM Account WHERE ACCOUNTNAME='" + cmbCustomer.Text + "'";
                        rdr = cmd.ExecuteReader();
         
                        con.Close();

                        cmbpaymentmode.Focus();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void cmbpaymentmode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (cmbpaymentmode.Text == "Cash")
                {
                    txttotalamount.Focus();
                }
                else
                {
                    dtpChequeDate.Focus();
                }
            }
        }

        private void dtpChequeDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtChequeno.Focus();
            }
        }

        private void txtChequeno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txttotalamount.Focus();
            }
        }

        private void txttotalamount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                txt_extra1.Focus();
            }

        }

        private void txt_extra1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                btn_save.Focus();
            }
            
        }
    }
}
