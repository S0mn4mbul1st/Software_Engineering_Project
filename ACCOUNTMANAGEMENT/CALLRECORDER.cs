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
    public partial class CALLRECORDER : Form
    {
        public CALLRECORDER()
        {
            InitializeComponent();
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
                cmd.CommandText = "SELECT MAX(CALLID) as CALLID FROM CallRecorder ";
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr.IsDBNull(rdr.GetOrdinal("CALLID")))
                    {
                        txtCallId.Text = Convert.ToString("1");
                    }
                    else
                    {
                        txtCallId.Text = Convert.ToString(Convert.ToInt16(rdr["CALLID"]) + 1);
                    }
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                con.Close();

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

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                String sql6 = "select ACCOUNTNAME from Account where ACCOUNTGROUPNAME='"+"EMPLOYEE"+"'";
                cmd = new OleDbCommand(sql6, con);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {


                    cmbEmployeeName.Items.Add(rdr[0]);

                }
                con.Close();


                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                String sql4 = "SELECT ITEMNAME FROM ItemMaster";
                cmd = new OleDbCommand(sql4, con);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    cmbItemName.Items.Add(rdr[0]);
                }
                con.Close();

                cmbcalltype.Text = "";
                cmbWarantyStatus.Text = "";
                cmbCallOf.Text = "";
                cmbCustomer.Text = "";
                txtAddress.Text = "";
                txtMobileNo.Text = "";
                txtConcernPerson.Text = "";
                txtSite.Text = "";
                txtMobileNo1.Text = "";
                txtitemno.Text = "0";
                cmbItemName.Text = "";
                txtSerialNo.Text = "";
                txtModelNo.Text = "";
                txtOtherDetail.Text = "";
                txtProblem.Text = "";
                cmbEmployeeName.Text = ""; 
                cmbCallStatus.Text = "";
                txtProblemFound.Text = "";
                txtCharges.Text = "0";
                txtAgainstBillNo.Text = "0";
                txtBillAmount.Text = "0";
                txtApproExpences.Text = "0";
                txtRepairDetail.Text = "";
                txtRemarks.Text = ""; 
                txtPaidAmount.Text = "0";

                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                cmbcalltype.Focus();

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

        private void CALLRECORDER_Load(object sender, EventArgs e)
        {
        
        }

        private void cmbcalltype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    cmbWarantyStatus.Focus();   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void cmbWarantyStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    cmbCallOf.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void cmbCallOf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    cmbCustomer.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
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

                        cmd.CommandText = "SELECT ACCOUNTID,ADDRESS,PHONE FROM Account WHERE ACCOUNTNAME='" + cmbCustomer.Text + "'";
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        { 
                          txtAddress.Text = (rdr["ADDRESS"].ToString());
                          txtMobileNo.Text = (rdr["PHONE"].ToString());
                        }
                        con.Close();
                     txtConcernPerson.Focus();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtConcernPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                   txtSite.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            
        }

        private void txtSite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    txtMobileNo1.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtMobileNo1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    txtitemno.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtitemno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    cmbItemName.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void cmbItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    if (cmbItemName.Text != null)
                    {
                        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                        con.Open();
                        cmd = con.CreateCommand();

                        cmd.CommandText = "SELECT ITEMID FROM ItemMaster WHERE ITEMNAME='" + cmbItemName.Text + "'";
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            txtitemno.Text = (rdr["ITEMID"].ToString());
                          
                        }
                        rdr.Close();
                        con.Close();
                        txtSerialNo.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void txtSerialNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    txtModelNo.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
           
        }

        private void txtModelNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    txtOtherDetail.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtOtherDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    txtProblem.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtProblem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    cmbEmployeeName.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void cmbEmployeeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    if (cmbEmployeeName.Text != null)
                    {
                        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                        con.Open();
                        cmd = con.CreateCommand();

                        cmd.CommandText = "SELECT ACCOUNTID FROM Account WHERE ACCOUNTNAME='" + cmbEmployeeName.Text + "'";
                        rdr = cmd.ExecuteReader();
     
                        con.Close();

                        dtpVisitDate.Focus();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void dtpVisitDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    dtpVisitTime.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void dtpVisitTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    cmbCallStatus.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void cmbCallStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    txtProblemFound.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtProblemFound_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    txtCharges.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtCharges_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    txtAgainstBillNo.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtAgainstBillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    txtBillAmount.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtBillAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    txtPaidAmount.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtApproExpences_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    txtRepairDetail.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtRepairDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    txtRemarks.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtRemarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    btnSave.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                string cb = "insert into CallRecorder(CALLID,CALLDATE,CALLTYPE,WARANTYSTATUS,CALLOF,ACCOUNTID,ACCOUNTNAME,ADDRESS,PHONE,CONTACTPERSON,SITE,MOBILENO,ITEMID,ITEMNAME,SERIALNO,MODELNO,OTHERDETAIL,PROBLEM,EMPLOYEEID,EMPLOYEENAME,VISITDATE,VISITTIME,CALLSTATUS,PROBLEMFOUND,CHARGES,PAIDAMOUNT,REPAIRDETAILS,REMARKS,APPROEXPENCES,AGAINSTBILLNO,BILLTOTALAMOUNT) VALUES (" + txtCallId.Text + ",'" + dtpDate.Text + "','" + cmbcalltype.Text + "','" + cmbWarantyStatus.Text + "','" + cmbCallOf.Text  + ",'" + cmbCustomer.Text + "','" + txtAddress.Text + "','" + txtMobileNo.Text + "','" + txtConcernPerson.Text + "','" + txtSite.Text + "','" + txtMobileNo1.Text + "'," + txtitemno.Text + ",'" + cmbItemName.Text + "','" + txtSerialNo.Text + "','" + txtModelNo.Text + "','" + txtOtherDetail.Text + "','" + txtProblem.Text + "'," + ",'" + cmbEmployeeName.Text + "','" + dtpVisitDate.Text + "','" + dtpVisitTime.Text + "','" + cmbCallStatus.Text + "','" + txtProblemFound.Text + "'," + txtCharges.Text + "," + txtPaidAmount.Text + ",'" + txtRepairDetail.Text + "','" + txtRemarks.Text + "'," + txtApproExpences.Text + "," + txtAgainstBillNo.Text + "," + txtBillAmount.Text + ")";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("1234");              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtPaidAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    txtApproExpences.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();

                string cb = "update CallRecorder set  CALLID = " + txtCallId.Text + ", CALLDATE ='" + dtpDate.Text + "', CALLTYPE= '" + cmbcalltype.Text + "', WARANTYSTATUS ='" + cmbWarantyStatus.Text + "', CALLOF ='" + cmbCallOf.Text + "', ACCOUNTID= " + ",ACCOUNTNAME = '" + cmbCustomer.Text + "', ADDRESS ='" + txtAddress.Text + "', PHONE= '" + txtMobileNo.Text + "', CONTACTPERSON = '" + txtConcernPerson.Text + "', SITE ='" + txtSite.Text + "', MOBILENO= '" + txtMobileNo1.Text + "',ITEMID = " + txtitemno.Text + ", ITEMNAME ='" + cmbItemName.Text + "', SERIALNO= '" + txtSerialNo.Text + "', MODELNO ='" + txtModelNo.Text + "', OTHERDETAIL ='" + txtOtherDetail.Text + "', PROBLEM= '" + txtProblem.Text + "',EMPLOYEEID = " + ", EMPLOYEENAME ='" + cmbEmployeeName.Text + "', VISITDATE= '" + dtpVisitDate.Text + "', VISITTIME = '" + dtpVisitTime.Text + "', CALLSTATUS ='" + cmbCallStatus.Text + "', PROBLEMFOUND= '" + txtProblemFound.Text + "', CHARGES = " + txtCharges.Text + ", PAIDAMOUNT =" + txtPaidAmount.Text + ", REPAIRDETAILS= '" + txtRepairDetail.Text + "', REMARKS ='" + txtRemarks.Text + "', APPROEXPENCES =" + txtApproExpences.Text + ", AGAINSTBILLNO= " + txtAgainstBillNo.Text + ",BILLTOTALAMOUNT = " + txtBillAmount.Text + " where  CALLID = " + txtCallId.Text + "";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                MessageBox.Show("Successfully updated", "CallRecorder", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string cb = "DELETE FROM CallRecorder WHERE CALLID="+txtCallId.Text + "";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully Deleted", "CallRecorder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
