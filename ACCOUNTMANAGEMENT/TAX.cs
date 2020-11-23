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
    public partial class TAX : Form
    {
        PRODUCTCREATION ths;
        public TAX(PRODUCTCREATION frm)
        {
            InitializeComponent();
             ths = frm;
            lblpath.Text = ths.lblpath.Text;
        }
        OleDbDataReader rdr = null;
        DataTable dtable = new DataTable();
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        DataTable dt = new DataTable();


        public void Reset()
        {
            try
            {

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT MAX(TAXID) as TAXID FROM Tax";
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr.IsDBNull(rdr.GetOrdinal("TAXID")))
                    {

                        lbltaxid.Text = Convert.ToString("1");
                    }
                    else
                    {
                        lbltaxid.Text = Convert.ToString(Convert.ToInt16(rdr["TAXID"]) + 1);
                    }
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                con.Close();

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                String sql = "SELECT TAXID,TAXNAME,TAXATIONTYPE,TAXPER FROM Tax";
                cmd = new OleDbCommand(sql, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                dgwTax.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dgwTax.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);
                }
                con.Close();

                txtTaxName.Text = "";
                cmbTaxType.Text = "";
                txttaxper.Text = "";
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;

                txtTaxName.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                string cb = "insert into Tax(TAXID,TAXNAME,TAXATIONTYPE,TAXPER) VALUES (" + lbltaxid.Text + ",'" + txtTaxName.Text + "','" +cmbTaxType.Text + "'," + txttaxper.Text + ")";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully saved", "Tax", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();

                string cb = "update Tax set  TAXNAME = '" + txtTaxName.Text + "', TAXATIONTYPE ='" + cmbTaxType.Text + "' , TAXPER= " + txttaxper.Text + " where  TAXID = " + lbltaxid.Text + "";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                MessageBox.Show("Successfully updated", "Tax", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                string cb = "DELETE FROM Tax WHERE TAXID=" + lbltaxid.Text + "";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully Deleted", "Tax", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgwTax_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                lbltaxid.Text = dgwTax.SelectedRows[0].Cells[0].Value.ToString();
                txtTaxName.Text = dgwTax.SelectedRows[0].Cells[1].Value.ToString();
                cmbTaxType.Text = dgwTax.SelectedRows[0].Cells[2].Value.ToString();
                txttaxper.Text = dgwTax.SelectedRows[0].Cells[3].Value.ToString();
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnSave.Enabled = false;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TAX_FormClosed(object sender, FormClosedEventArgs e)
        {
             
                  Form fc = Application.OpenForms["PRODUCTCREATION"];

                  if (fc != null)
                  {
                      ths.taxresete();
                      ths.cmbTax.Focus();
                  }
                 
          
        }

      

    }
}
