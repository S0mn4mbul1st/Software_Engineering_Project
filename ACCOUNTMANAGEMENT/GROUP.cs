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
    public partial class GROUP : Form
    {
        PRODUCTCREATION ths;
        public GROUP(PRODUCTCREATION frm)
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
        public static string SetValueForText1 = "";

      
     
        public void Reset()
        {
            try
            {

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                cmd = con.CreateCommand();
                                  
                cmd.CommandText = "SELECT MAX(GROUPID) as GROUPID FROM ProductGroup";
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr.IsDBNull(rdr.GetOrdinal("GROUPID")))
                    {

                        lblgroupid.Text = Convert.ToString("1");
                    }
                    else
                    {
                        lblgroupid.Text = Convert.ToString(Convert.ToInt16(rdr["GROUPID"]) + 1);
                    }
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                con.Close();

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                String sql = "SELECT GROUPID,GROUPNAME FROM ProductGroup";
                cmd = new OleDbCommand(sql, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                dgwGroup.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dgwGroup.Rows.Add(rdr[0], rdr[1]);
                }
                con.Close();

                txtGroupName.Text = "";

                btnSave.Enabled = true;
                btnDelete.Enabled = false; 

                txtGroupName.Focus();
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
                string cb = "insert into ProductGroup(GROUPID,GROUPNAME) VALUES (" + lblgroupid.Text + ",'" + txtGroupName.Text + "')";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully saved", "GROUP", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                string cb = "update ProductGroup set  GROUPNAME = '" + txtGroupName.Text + "' where  GROUPID = " + lblgroupid.Text + "";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                MessageBox.Show("Successfully updated", "GROUP", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string cb = "DELETE FROM ProductGroup WHERE GROUPID=" + lblgroupid.Text + "";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully Deleted", "Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
       
        private void dgwGroup_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                lblgroupid.Text = dgwGroup.SelectedRows[0].Cells[0].Value.ToString();
                txtGroupName.Text = dgwGroup.SelectedRows[0].Cells[1].Value.ToString();
                btnDelete.Enabled = true; 
                btnSave.Enabled = false;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void GROUP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form fc = Application.OpenForms["PRODUCTCREATION"];

            if (fc != null)
           {

                 ths.group();
                 ths.cmbGroup.Focus();
            }
            
        }
    }
}
