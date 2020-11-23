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
    public partial class SELECTCOMPANY : Form
    {
        public SELECTCOMPANY()
        {
            InitializeComponent();
            load();
        }
        OleDbDataReader rdr = null;
        DataTable dtable = new DataTable();
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        DataTable dt = new DataTable();
        String cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\ACCOUNTMANAGEMENT\\ACCOUNTMANAGEMENT\\Data\\accountmanagement.accdb;";

        public void load()
        {
            try
            {
                con = new OleDbConnection(cs);
                con.Open();
                String sql = "SELECT COMPANYID,COMPANYNAME,FINANCIALYEARFROM,PATH FROM Company";
                cmd = new OleDbCommand(sql, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dgvselectcompany.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dgvselectcompany.Rows.Add(rdr[0], rdr[1], rdr[2],rdr[3]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try{
            
            COMPANY FRM = new COMPANY();
            FRM.Show();
            this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void dgvselectcompany_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                Login frm = new Login();
                frm.lblpath.Text = dgvselectcompany.SelectedRows[0].Cells[3].Value.ToString();
                frm.lblcompanyname.Text = dgvselectcompany.SelectedRows[0].Cells[1].Value.ToString();
                frm.Show();
                this.Hide();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {

            try
            {
                Login frm = new Login();
                frm.lblpath.Text = dgvselectcompany.SelectedRows[0].Cells[3].Value.ToString();
                frm.lblcompanyname.Text = dgvselectcompany.SelectedRows[0].Cells[1].Value.ToString();
                frm.Show();
                this.Hide();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
