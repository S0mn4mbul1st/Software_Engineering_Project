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
    public partial class RECEIPTDETAIL : Form
    {
        public RECEIPTDETAIL()
        {
            InitializeComponent();
        }
        OleDbDataReader rdr = null;
        DataTable dtable = new DataTable();
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        DataTable dt = new DataTable();


        private void btnView_Click(object sender, EventArgs e)
        {

            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            String sql1 = "SELECT RECEIPTID,RECEIPTDATE,CUSTOMERNAME,PAYMENTMODE,CHEQUEDATE,CHEQUENO,INSTALLMENTNO,INSTALLMENTDATE,AMOUNT FROM Receipt";
            cmd = new OleDbCommand(sql1, con);
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dgvinstallment.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgvinstallment.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8]);
            }
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            String sql1 = "SELECT RECEIPTID,RECEIPTDATE,CUSTOMERNAME,PAYMENTMODE,CHEQUEDATE,CHEQUENO,INSTALLMENTNO,INSTALLMENTDATE,AMOUNT FROM Receipt where RECEIPTDATE between # " + dtpDateFrom.Text + "#  and # " + dtpDateTo.Text + "#  Order by RECEIPTDATE ";
            cmd = new OleDbCommand(sql1, con);
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dgvinstallment.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgvinstallment.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8]);
            }
            con.Close();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
