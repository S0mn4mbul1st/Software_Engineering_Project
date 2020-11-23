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
    public partial class CUSTOMER : Form
    {
        public CUSTOMER()
        {
            InitializeComponent();
        }
        OleDbDataReader rdr = null;
        DataTable dtable = new DataTable();
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        DataTable dt = new DataTable();
       
        
        
        private void CUSTOMER_Load(object sender, EventArgs e)
        {
           
        }

        public void Reset()
        { try{
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            cmd = con.CreateCommand();

            cmd.CommandText = "SELECT MAX(CUSTOMERID) as  CUSTOMERID FROM Customer";
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (rdr.IsDBNull(rdr.GetOrdinal("CUSTOMERID")))
                {
                    txtcustid.Text = Convert.ToString("1");
                }
                else
                {
                    txtcustid.Text = Convert.ToString(Convert.ToInt16(rdr["CUSTOMERID"]) + 1);
                }
            }
            if ((rdr != null))
            {
                rdr.Close();
            }
            con.Close();
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtPhoneNo.Text = "";
            txt_Mobile.Text = "";
            txtEmail.Text = "";
            txt_extra1.Text = "";
            btn_save.Enabled = true;
            btn_delete.Enabled = false;
            txtCustomerName.Focus();

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
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                string ct = "select CUSTOMERNAME from Customer where CUSTOMERNAME='" + txtCustomerName.Text + "'";

                cmd = new OleDbCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Customer Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerName.Text = "";
                    txtCustomerName.Focus();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                string cb = "insert into Customer(CUSTOMERNAME,ADDRESS,PHONENO,MOBILENO,EMAIL,EXTRADETAIL,EXTRADETAIL1) VALUES ('" + txtCustomerName.Text + "','" + txtAddress.Text + "','" + txtPhoneNo.Text + "','" + txt_Mobile.Text + "','" +txtEmail.Text +"','" + txt_extra1.Text + "')";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully saved", "Company", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                btn_save.Enabled = false;

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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();

                string cb = "update Customer set CUSTOMERNAME = '" + txtCustomerName.Text + "',ADDRESS= '" + txtAddress.Text + "',PHONENO= '" + txtPhoneNo.Text + "',EMAIL= '" + txtEmail.Text + "',MOBILENO= '" + txt_Mobile.Text + "',EXTRADETAIL= '" + txt_extra1.Text + "',EXTRADETAIL1= '" + "' where CUSTOMERID= '" + txtcustid.Text + "'";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                MessageBox.Show("Successfully updated", "Company Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
