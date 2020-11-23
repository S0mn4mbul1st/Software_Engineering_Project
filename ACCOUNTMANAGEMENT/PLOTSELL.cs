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
    public partial class PLOTSELL : Form
    {
        public PLOTSELL()
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

                cmd.CommandText = "SELECT MAX(PLOTSELLID) as  PLOTSELLID FROM PlotSell";
                rdr = cmd.ExecuteReader();

                if ((rdr != null))
                {
                    rdr.Close();
                }
                con.Close();

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

                cmbCustomer.Text = "";
                txtplotno.Text = "";
                txtsurveyno.Text = "";
                txtplotsize.Text = "";
                txtrate.Text = "";
                txttotalamount.Text = "";
              
                txtagreementamount.Text = "";
                txttotalpaidamount.Text = "";
                txtbalanceamount.Text = "";
                txtextradetail.Text = "";
                txtbookingamout.Text = "";
                txttotalinstallmentamount.Text = "0";
                btn_save.Enabled = true;
                btn_delete.Enabled = false;
                dgvinstallment.DataSource = null;
                cmbCustomer.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try{
                
            if(txtinstallment.Text!="")
            {

                txttotalinstallmentamount.Text = Convert.ToString(Convert.ToInt64(txttotalinstallmentamount.Text) + (Convert.ToInt64(txtinstallment.Text)));
                txtremainingamount.Text = Convert.ToString(Convert.ToInt64(txtbalanceamount.Text) - (Convert.ToInt64(txttotalinstallmentamount.Text)));
                if (txttotalinstallmentamount.Text == txtbalanceamount.Text)
                {
                    string x = "UNPAID";
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    string cb = "insert into Installment(INSTALLMENTNO,INSTALLMENTDATE,INSTALLMENT,PLOTSELLID,CUSTOMERID,PAIDSTATUS) VALUES (" + txtinstallmentno.Text + ",'" + dtpInvoiceDate.Text + "'," + txtinstallment.Text + "," + ",'" + x + "')";
                    cmd = new OleDbCommand(cb);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();

                    txtinstallmentno.Text = Convert.ToString(Convert.ToInt64(txtinstallmentno.Text) + 1);
                    txtinstallment.Text = "";
                    dtpInvoiceDate.Focus();
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    String sql = "SELECT INSTALLMENTNO,INSTALLMENTDATE,INSTALLMENT FROM Installment WHERE PLOTSELLID=" + "";
                    cmd = new OleDbCommand(sql, con);
                    rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    dgvinstallment.Rows.Clear();
                    while (rdr.Read() == true)
                    {
                        dgvinstallment.Rows.Add(rdr[0], rdr[1], rdr[2]);
                    }
                    con.Close();

                    MessageBox.Show("Installment Complete Please Save ");
                }
                if (Convert.ToInt64(txttotalinstallmentamount.Text) < Convert.ToInt64(txtbalanceamount.Text))
                {
                    string x = "UNPAID";
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    string cb = "insert into Installment(INSTALLMENTNO,INSTALLMENTDATE,INSTALLMENT,PLOTSELLID,CUSTOMERID,PAIDSTATUS) VALUES (" + txtinstallmentno.Text + ",'" + dtpInvoiceDate.Text + "'," + txtinstallment.Text + "," + ",'" + x + "')";
                    cmd = new OleDbCommand(cb);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();

                    txtinstallmentno.Text = Convert.ToString(Convert.ToInt16(txtinstallmentno.Text) + 1);
                    txtinstallment.Text = "";
                    dtpInvoiceDate.Focus();
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    String sql = "SELECT INSTALLMENTNO,INSTALLMENTDATE,INSTALLMENT FROM Installment WHERE PLOTSELLID=" + "";
                    cmd = new OleDbCommand(sql, con);
                    rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    dgvinstallment.Rows.Clear();
                    while (rdr.Read() == true)
                    {
                        dgvinstallment.Rows.Add(rdr[0], rdr[1], rdr[2]);


                    }
                    con.Close();

                }
            }
                if (Convert.ToInt64(txttotalinstallmentamount.Text) > Convert.ToInt64(txtbalanceamount.Text))
                {
                    txttotalinstallmentamount.Text = Convert.ToString(Convert.ToInt64(txttotalinstallmentamount.Text) - (Convert.ToInt64(txtinstallment.Text)));
                    txtremainingamount.Text = Convert.ToString(Convert.ToInt64(txtbalanceamount.Text) - (Convert.ToInt64(txttotalinstallmentamount.Text)));
                    txtinstallment.Text = "";
                    txtinstallment.Focus();
                    MessageBox.Show("Installment amount can't greater than balance amount ");
                }
             

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
                string cb = "insert into PlotSell(CUSTOMERID,CUSTOMERNAME,PLOTNO,SURVEYNO,PLOTSIZE,RATE,TOTALAMOUNT,BOOKINGAMOUNT,AGREEMENTAMOUNT,TOTALPAIDAMOUNT,BALANCEAMOUNT,EXTRADETAIL,PLOTSELLDATE) VALUES (" + ",'" + cmbCustomer.Text + "','" + txtplotno.Text + "','" + txtsurveyno.Text + "'," + txtplotsize.Text + "," + txtrate.Text + "," + txttotalamount.Text + "," + txtbookingamout.Text + "," + txtagreementamount.Text + "," + txttotalpaidamount.Text + "," + txtbalanceamount.Text + ",'" + txtextradetail.Text + "','" +dtpDate.Text + "')";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully saved", "PLOT SELL DETAIL", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                string cb1 = "insert into Ledger(PLOTSELLID,VOUCHERDATE,VOUCHERTYPE,VOUCHERNO,DEBIT,BAL) VALUES (" + ",'" + dtpDate.Text + "','" + "TOTAL PLOT SELL AMOUNT" + "'," + "," + txttotalamount.Text + "," + txttotalamount.Text + ")";

                cmd = new OleDbCommand(cb1);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();

                string a = Convert.ToString(Convert.ToInt64(txttotalamount.Text) - Convert.ToInt64(txtbookingamout.Text));
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                string cb2 = "insert into Ledger(PLOTSELLID,VOUCHERDATE,VOUCHERTYPE,VOUCHERNO,CREDIT,BAL) VALUES (" + ",'" + dtpDate.Text + "','" + "Booking AMOUNT" + "'," + "," + txtbookingamout.Text + "," + a.ToString() + ")";

                cmd = new OleDbCommand(cb2);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();

                a = Convert.ToString(Convert.ToInt64(a) - Convert.ToInt64(txtagreementamount.Text));
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                string cb3 = "insert into Ledger(PLOTSELLID,VOUCHERDATE,VOUCHERTYPE,VOUCHERNO,CREDIT,BAL) VALUES ("  + ",'" + dtpDate.Text + "','" + "AGREEMENT AMOUNT" + "'," + "," + txtagreementamount.Text + "," + a.ToString() + ")";

                cmd = new OleDbCommand(cb3);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();

                    DialogResult result1 = MessageBox.Show("Do you want to print this plot sell detail?", "Account Management",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                        try
                        {
                            rptInvoice rpt = new rptInvoice();
                       
                            cmd = new OleDbCommand();
                            OleDbDataAdapter myDA = new OleDbDataAdapter();
                            DataSet myDS = new DataSet();
                           
                            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                            cmd.Connection = con;
                        
                            cmd.CommandText = "SELECT PlotSell.CUSTOMERID,PlotSell.CUSTOMERNAME,PlotSell.PLOTNO,PlotSell.SURVEYNO,PlotSell.PLOTSIZE,PlotSell.RATE,PlotSell.TOTALAMOUNT,PlotSell.BOOKINGAMOUNT,PlotSell.AGREEMENTAMOUNT,PlotSell.TOTALPAIDAMOUNT,PlotSell.BALANCEAMOUNT,PlotSell.EXTRADETAIL,PlotSell.PLOTSELLDATE,PlotSell.PLOTSELLID FROM  PlotSell   WHERE  PlotSell.PLOTSELLID =" + "";
                            cmd.CommandType = CommandType.Text;
                            myDA.SelectCommand = cmd;
                            myDA.Fill(myDS, "PlotSell");
                            

                            cmd.CommandText = "SELECT Company.COMPANYNAME,Company.ADDRESS,Company.PHONENO,Company.EMAIL,Company.WEB,Company.TINNO,Company.CSTNO,Company.EXTRA1,Company.EXTRA2 FROM Company ";
                            cmd.CommandType = CommandType.Text;
                            myDA.SelectCommand = cmd;
                            myDA.Fill(myDS, "Company");

                            cmd.CommandText = "SELECT Installment.INSTALLMENTNO,Installment.INSTALLMENTDATE,Installment.INSTALLMENT FROM Installment WHERE  Installment.PLOTSELLID =" + " ";
                            cmd.CommandType = CommandType.Text;
                            myDA.SelectCommand = cmd;
                            myDA.Fill(myDS, "Installment");
                            con.Close();
                            rpt.SetDataSource(myDS);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }
                    btn_save.Enabled = false;
                    Reset();




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

                string cb = "update PlotSell set  CUSTOMERID = " + ", CUSTOMERNAME = '" + cmbCustomer.Text + "',PLOTNO= '" + txtplotno.Text + "',SURVEYNO= '" + txtsurveyno.Text + "',PLOTSIZE= " + txtplotsize.Text + ",RATE= " + txtrate.Text + ",TOTALAMOUNT= " + txttotalamount.Text + ",BOOKINGAMOUNT= " + txtbookingamout.Text + ",AGRIMENTAMOUNT= " + txtagreementamount.Text + ",TOTALPAIDAMOUNT= " + txttotalpaidamount.Text + ",BALANCEAMOUNT= " + txtbalanceamount.Text + ",EXTRADETAIL= '" + txtextradetail.Text + "',PLOTSELLDATE= '" + dtpDate.Text + "' where PLOTSELLID= " + "";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                MessageBox.Show("Successfully updated", "PLOT SELL Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtrate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtrate.Text != "")
                {
                    txttotalamount.Text = Convert.ToString(Convert.ToInt64(txtplotsize.Text) * Convert.ToInt64(txtrate.Text));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtagreementamount_TextChanged(object sender, EventArgs e)
        {
            try{
                if (txtagreementamount.Text != "")
                {
                    if (Convert.ToInt64(txtagreementamount.Text) > Convert.ToInt64(txttotalamount.Text))
                    {
                        MessageBox.Show("Agreement amount can not be greater than Total amount");

                    }
                    else
                    {
                        if (txtbookingamout.Text != "" || txttotalpaidamount.Text != "" || txttotalpaidamount.Text !="")
                        txttotalpaidamount.Text = Convert.ToString(Convert.ToInt64(txtbookingamout.Text) + Convert.ToInt64(txtagreementamount.Text));
                        txtbalanceamount.Text = Convert.ToString(Convert.ToInt64(txttotalamount.Text) - Convert.ToInt64(txttotalpaidamount.Text));
                                      }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        

        }

    
        private void cmbCustomer_Leave(object sender, EventArgs e)
        {
            try{
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT CUSTOMERID FROM Customer WHERE CUSTOMERNAME='" + cmbCustomer.Text + "'";
            rdr = cmd.ExecuteReader();
            con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CUSTOMER frm = new CUSTOMER();
                frm.Show();
                frm.lblpath.Text = lblpath.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCustomer_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
            if (e.KeyCode == Keys.F3)
            {
                CUSTOMER frm = new CUSTOMER();
                frm.Show();
                frm.lblpath.Text = lblpath.Text;
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpInvoiceDate_Leave(object sender, EventArgs e)
        {
            txtinstallment.Focus();
        }

        private void txtbookingamout_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtagreementamount.Text != "")
                {
                    if (Convert.ToInt64(txtbookingamout.Text) > Convert.ToInt64(txttotalamount.Text))
                    {
                        MessageBox.Show("Booking amount can not be greater than Total amount");

                    }
                    else { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PLOTSELL_Load(object sender, EventArgs e)
        {

        }

      
      

     
    }
}
