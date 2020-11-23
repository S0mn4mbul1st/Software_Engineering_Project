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
    public partial class STOCKcs : Form
    {
        public STOCKcs()
        {
            InitializeComponent();
        }
        OleDbDataReader rdr = null;
        DataTable dtable = new DataTable();
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        DataTable dt = new DataTable();

        public void loadgrid()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            String sql1 = "SELECT (ITEMID) as[ITEMID],(ITEMNAME) AS [ITEMNAME] ,SUM(INQTY) AS [TOTALINQTY],SUM(OUTQTY) AS [TOTALOUTQTY] ,(SUM(INQTY)- SUM(OUTQTY)) AS [CURRENTSTOCK] FROM INVENTORY GROUP BY ITEMID , ITEMNAME";
            cmd = new OleDbCommand(sql1, con);
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dgvinstallment.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgvinstallment.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4]);
            }
            con.Close();
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void STOCKcs_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
