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
    public partial class LEDGERAM : Form
    {
        public LEDGERAM()
        {
            InitializeComponent();
        }
        OleDbDataReader rdr = null, rdr1 = null;
        DataTable dtable = new DataTable();
        OleDbConnection con = null, con1 = null, con2 = null;
        OleDbCommand cmd = null,cmd1 = null;
        DataTable dt = new DataTable();

        private void btn_new_Click(object sender, EventArgs e)
        {
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
            cmbCustomer.Focus();
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
                        btnSearch.Focus();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = "";
                double BAL = 0;

                //con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                //con.Open();
                //cmd = con.CreateCommand();
                //cmd.CommandText = "SELECT CUSTOMERID FROM Customer WHERE CUSTOMERNAME='" + cmbCustomer.Text + "'";
                //rdr = cmd.ExecuteReader();
                //while (rdr.Read())
                //{
                //    lblcustid.Text = (rdr["CUSTOMERID"].ToString());
                //}
                //con.Close();

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT LedgerPosting.LEDGERPOSTINGID FROM LedgerPosting where ACCOUNTID="  + " ";
                rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    ID = Convert.ToString(rdr["LEDGERPOSTINGID"]);
                    con1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con1.Open();
                    cmd1 = con1.CreateCommand();
                    cmd1.CommandText = "SELECT DEBIT,CREDIT FROM LedgerPosting where LEDGERPOSTINGID=" + ID + "";
                    rdr1 = cmd1.ExecuteReader();
                    double DR = 0;
                    double CR = 0;
                    while (rdr1.Read())
                    {
                        //    lblcustid.Text = (rdr["CUSTOMERID"].ToString());

                      
                        double.TryParse(rdr1["DEBIT"].ToString(), out DR);
                        double.TryParse(rdr1["CREDIT"].ToString(), out CR);
                        //Convert.ToDouble(rdr1[0]);
                        //Convert.ToDouble(rdr1[1]);
                    }
                    rdr1.Close();
                    BAL = BAL + DR - CR;
                    con1.Close();
                    con2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con2.Open();
                    String cb = "UPDATE  LedgerPosting set EXTRA = '" + BAL.ToString() + "'where LEDGERPOSTINGID=" + ID + "";
                    cmd = new OleDbCommand(cb);
                    cmd.Connection = con2;
                    cmd.ExecuteReader();
                    con2.Close();


                }
                rdr.Close();
                con.Close();
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                String sql1 = "SELECT LDATE,VOUCHERTYPE,VOCHERNO,DEBIT,CREDIT,EXTRA FROM LedgerPosting where LedgerPosting.ACCOUNTID="   + "";
                cmd = new OleDbCommand(sql1, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dgvinstallment.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dgvinstallment.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5]);
                }
                con.Close();




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
    }
}
