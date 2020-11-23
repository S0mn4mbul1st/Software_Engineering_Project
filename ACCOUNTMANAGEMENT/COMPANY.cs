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
    public partial class COMPANY : Form
    {
        public COMPANY()
        {
            InitializeComponent();
        }
        OleDbDataReader rdr = null;
        DataTable dtable = new DataTable();
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        DataTable dt = new DataTable();
        String cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\ACCOUNTMANAGEMENT\\ACCOUNTMANAGEMENT\\Data\\accountmanagement.accdb;";

        private void Reset()
        {
            try{
            txtCompanyName.Text = "";
            txtAddress.Text = "";
            txtPhoneNo.Text = "";
            txtEmail.Text = "";
            txtCstNo.Text = "";
            txtTinNo.Text = "";
            txtWeb.Text = "";
            txt_extra1.Text = ""; 
            btn_save.Enabled = true;
            btn_delete.Enabled = false; 

            con = new OleDbConnection(cs);
            con.Open();
            cmd = con.CreateCommand();

            cmd.CommandText = "SELECT MAX(COMPANYID) as  COMPANYID FROM Company";
            rdr = cmd.ExecuteReader();
 
            if ((rdr != null))
            {
                rdr.Close();
            }
            con.Close();


            txtCompanyName.Focus();

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
                con = new OleDbConnection(cs);
                con.Open();
                string ct = "select COMPANYNAME from Company where COMPANYNAME='" + txtCompanyName.Text + "'";

                cmd = new OleDbCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Company Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCompanyName.Text = "";
                    txtCompanyName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

               
               
                System.IO.Directory.CreateDirectory(@"C:\\ACCOUNTMANAGEMENT\\ACCOUNTMANAGEMENT\\Data" + "\\" + txtCompanyName.Text);
                System.IO.File.Copy(@"C:\\ACCOUNTMANAGEMENT\\ACCOUNTMANAGEMENT\\Data\\accountmanagement.accdb", @"C:\\ACCOUNTMANAGEMENT\\ACCOUNTMANAGEMENT\\Data" + "\\" + txtCompanyName.Text + "\\accountmanagement.accdb");

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\ACCOUNTMANAGEMENT\\ACCOUNTMANAGEMENT\\Data" + "\\" + txtCompanyName.Text + "\\accountmanagement.accdb;");
                con.Open();

                string cb2 = "DELETE * FROM Company ";
                cmd = new OleDbCommand(cb2);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();


                con = new OleDbConnection(cs);
                con.Open();
                string PATH = @"C:\\ACCOUNTMANAGEMENT\\ACCOUNTMANAGEMENT\\Data" + "\\" + txtCompanyName.Text + "\\accountmanagement.accdb";
                string cb = "insert into Company(COMPANYNAME,ADDRESS,PHONENO,EMAIL,WEB,FINANCIALYEARFROM,FINANCIALYEAREND,TINNO,CSTNO,EXTRA1,EXTRA2,PATH) VALUES ('" + txtCompanyName.Text + "','" + txtAddress.Text + "','" + txtPhoneNo.Text + "','" + txtEmail.Text + "','" + txtWeb.Text + "','" + dtpfromDate.Text + "','" + dtpclosingdate.Text + "','" + txtTinNo.Text + "','" + txtCstNo.Text + "','" + txt_extra1.Text + "','"   + "','" + PATH + "')";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\ACCOUNTMANAGEMENT\\ACCOUNTMANAGEMENT\\Data" + "\\" + txtCompanyName.Text + "\\accountmanagement.accdb;");
                con.Open();
            
                string cb1 = "insert into Company(COMPANYNAME,ADDRESS,PHONENO,EMAIL,WEB,FINANCIALYEARFROM,FINANCIALYEAREND,TINNO,CSTNO,EXTRA1,EXTRA2,PATH) VALUES ('" + txtCompanyName.Text + "','" + txtAddress.Text + "','" + txtPhoneNo.Text + "','" + txtEmail.Text + "','" + txtWeb.Text + "','" + dtpfromDate.Text + "','" + dtpclosingdate.Text + "','" + txtTinNo.Text + "','" + txtCstNo.Text + "','" + txt_extra1.Text + "','"  + PATH + "')";
                cmd = new OleDbCommand(cb1);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Successfully saved", "Company", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                btn_save.Enabled = false;
                SELECTCOMPANY frm = new SELECTCOMPANY();
                frm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            SELECTCOMPANY FRM = new SELECTCOMPANY();
            FRM.Show();

            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection(cs);
                con.Open();

                string cb = "update Company set COMPANYNAME = '" + txtCompanyName.Text + "',ADDRESS= '" + txtAddress.Text + "',PHONENO= '" + txtPhoneNo.Text + "',EMAIL= '" + txtEmail.Text + "',WEB= '" + txtWeb.Text + "',FINANCIALYEARFROM= '" + dtpfromDate.Text + "',FINANCIALYEAREND='"+dtpclosingdate.Text+"', TINNO= '" + txtTinNo.Text + "',CSTNO= '" + txtCstNo.Text + "',EXTRA1= '" + txt_extra1.Text + "',EXTRA2= '" + "'";
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

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
