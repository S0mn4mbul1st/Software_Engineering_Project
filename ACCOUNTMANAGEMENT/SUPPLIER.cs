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
    public partial class SUPPLIER : Form
    {
        Purchase ths;
        public SUPPLIER(Purchase frm)
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

                cmd.CommandText = "SELECT MAX(ACCOUNTID) as  ACCOUNTID FROM Account";
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr.IsDBNull(rdr.GetOrdinal("ACCOUNTID")))
                    {
                        txtSupplierid.Text = Convert.ToString("1");
                    }
                    else
                    {
                        txtSupplierid.Text = Convert.ToString(Convert.ToInt16(rdr["ACCOUNTID"]) + 1);
                    }
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                con.Close();
                txtSupplierName.Text = "";
                txtAddress.Text = "";
                txtPhoneNo.Text = "";
                cmbcrdr.Text = "";
                txtOpbal.Text = "";
                txtEmail.Text = "";
                txt_extra1.Text = ""; 
                btn_save.Enabled = true;
                btn_delete.Enabled = false; 
                txtSupplierName.Focus();

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

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                string ct = "select ACCOUNTNAME from Account where ACCOUNTNAME='" + txtSupplierName.Text + "'";

                cmd = new OleDbCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Supplier Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSupplierName.Text = "";
                    txtSupplierName.Focus();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                string cb = "insert into Account(ACCOUNTID,ACCOUNTNAME,ADDRESS,PHONE,EMAIL,EXTRA,EXTRA1,ACCOUNTGROUPID,ACCOUNTGROUPNAME,OPBAL,DC) VALUES (" + txtSupplierid.Text + ",'" + txtSupplierName.Text + "','" + txtAddress.Text + "','" + txtPhoneNo.Text + "','" + txtEmail.Text + "','" + txt_extra1.Text + "','" + "33" + ",'" + "SUPPLIERS" + "'," + txtOpbal.Text + ",'" + cmbcrdr.Text + "')";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully saved", "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                btn_save.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();

                string cb = "update Account set ACCOUNTNAME = '" + txtSupplierName.Text + "',ADDRESS= '" + txtAddress.Text + "',PHONENO= '" + txtPhoneNo.Text + "',EMAIL= '" + txtEmail.Text + "',EMAIL= '" + txtEmail.Text + "',DC= " + cmbcrdr.Text + ",EXTRADETAIL= '" + txt_extra1.Text + "',EXTRADETAIL1= '"  + "' where ACCOUNTID= " + txtSupplierid.Text + "";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                MessageBox.Show("Successfully updated", "Supplier Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                string cb = "DELETE FROM Account WHERE ACCOUNTID= '" + txtSupplierid.Text + "'";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully Deleted", "SUPPLIER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
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

        private void SUPPLIER_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form fc = Application.OpenForms["Purchase"];

            if (fc != null)
            {
                ths.supplierresete();
                ths.cmbSupplier.Focus();
            }
        }
   

    }
}
