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
    public partial class PAYMENT : Form
    {
        public PAYMENT()
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

                cmd.CommandText = "SELECT MAX(VOCHERNO) as  VOUCHERNO FROM LedgerPosting WHERE VOUCHERTYPE='" + "QUICK PAYMENT" + "' ";
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

                    cmbSupplier.Items.Add(rdr[0]);
                }
                con.Close();

                cmbSupplier.Text = "";
                cmbpaymentmode.Text = "Cash";
                txtChequeno.Text = "";
                txttotalamount.Text = "";
                txt_extra1.Text = "";
                label1.Hide();
                label4.Hide();
                dtpChequeDate.Hide();
                txtChequeno.Hide();

                txttotalamount.Text = "";

                lblSupplierid.Text = "0";
                btn_save.Enabled = true;
                btn_delete.Enabled = false; 
                cmbSupplier.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void dtpReceiptDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Reset();
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
                    string cb1 = "insert into LedgerPosting (LEDGERPOSTINGID,LDATE,ACCOUNTID,ACCOUNTNAME,VOUCHERTYPE,VOCHERNO,DEBIT) VALUES ('" + SDID + "','" + dtpReceiptDate.Text + "'," + lblSupplierid.Text + ",'" + cmbSupplier.Text + "','" + "QUICK PAYMENT" + "'," + txtReceiptNo.Text + "," + txttotalamount.Text + ")";
                    cmd = new OleDbCommand(cb1);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();

                    MessageBox.Show("Successfully saved", "Receipt Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Reset();
                    return;

                }
                if (cmbpaymentmode.Text == "Cheque")
                {
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    string cb1 = "insert into LedgerPosting (LEDGERPOSTINGID,LDATE,ACCOUNTID,ACCOUNTNAME,VOUCHERTYPE,VOCHERNO,DEBIT,EXTRA,EXTRA1) VALUES ('" + SDID + "','" + dtpReceiptDate.Text + "'," + lblSupplierid.Text + ",'" + cmbSupplier.Text + "','" + "QUICK PAYMENT" + "'," + txtReceiptNo.Text + "," + txttotalamount.Text + ",'" + txtChequeno.Text + "','" + dtpChequeDate.Text + "')";
                    cmd = new OleDbCommand(cb1);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();

                    MessageBox.Show("Successfully saved", "Receipt Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void cmbSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    if (cmbSupplier.Text != null)
                    {
                        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                        con.Open();
                        cmd = con.CreateCommand();
                        cmd.CommandText = "SELECT ACCOUNTID FROM Account WHERE ACCOUNTNAME='" + cmbSupplier.Text + "'";
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            lblSupplierid.Text = (rdr["ACCOUNTID"].ToString());
                        }
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
