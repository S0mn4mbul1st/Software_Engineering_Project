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
    public partial class Ledger : Form
    {
        public Ledger()
        {
            InitializeComponent();
           
        }

        OleDbDataReader rdr = null;
        DataTable dtable = new DataTable();
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        DataTable dt = new DataTable();


        public void reset()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            String sql = "SELECT CUSTOMERNAME FROM Customer";
            cmd = new OleDbCommand(sql, con);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                cmbCustomer.Items.Add(rdr[0]);
            }
            con.Close();
            cmbCustomer.Focus();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                String sql1 = "SELECT VOUCHERDATE,VOUCHERTYPE,VOUCHERNO,DEBIT,CREDIT,BAL FROM Ledger where PLOTSELLID=" + cmbPlotSellId.Text + " order by ID";
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

        private void cmbCustomer_Leave(object sender, EventArgs e)
        {

            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT CUSTOMERID FROM Customer WHERE CUSTOMERNAME='" + cmbCustomer.Text + "'";
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lblcustid.Text = (rdr["CUSTOMERID"].ToString());
                }
                con.Close();
                cmbPlotNo.Focus();
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                String sql = "SELECT PlOTNO FROM PlotSell where CUSTOMERID=" + lblcustid.Text + " ";
                cmd = new OleDbCommand(sql, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    cmbPlotNo.Items.Add(rdr[0]);


                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }




        private void cmbPlotNo_Leave(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            String sql = "SELECT SURVEYNO FROM PlotSell where CUSTOMERID=" + lblcustid.Text + " and PLOTNO='" + cmbPlotNo.Text + "'";
            cmd = new OleDbCommand(sql, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

                cmbSurveyNo.Items.Add(rdr[0]);


            }
            con.Close();
            cmbSurveyNo.Focus();
        }

        private void cmbSurveyNo_Leave(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            String sql = "SELECT PLOTSELLID FROM PlotSell where CUSTOMERID=" + lblcustid.Text + " and PLOTNO='" + cmbPlotNo.Text + "' AND SURVEYNO='" + cmbSurveyNo.Text + "'";
            cmd = new OleDbCommand(sql, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

                cmbPlotSellId.Items.Add(rdr[0]);


            }
            con.Close();
            cmbPlotSellId.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}