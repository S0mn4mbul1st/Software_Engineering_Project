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
    public partial class RECEIPT : Form
    {
        public RECEIPT()
        {
            InitializeComponent();
        }
        OleDbDataReader rdr = null;
        DataTable dtable = new DataTable();
        OleDbConnection con = null;
        OleDbCommand cmd = null;

        DataTable dt = new DataTable();
             string  PAID = "PAID";
             string a,SDID;
     
        public void Reset()
        {
            try{

            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            cmd = con.CreateCommand();

            cmd.CommandText = "SELECT MAX(RECEIPTID) as  RECEIPTID FROM Receipt";
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (rdr.IsDBNull(rdr.GetOrdinal("RECEIPTID")))
                {
                    txtReceiptNo.Text = Convert.ToString("1");
                }
                else
                {
                    txtReceiptNo.Text = Convert.ToString(Convert.ToInt64(rdr["RECEIPTID"]) + 1);
                }
            }
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
            cmbpaymentmode.Text = "Cash";
            txtChequeno.Text = "";
            txttotalamount.Text = "";
            txt_extra1.Text = "";
            label1.Hide();
            label4.Hide();
            dtpChequeDate.Hide();
            txtChequeno.Hide();
            cmbInstallmentNo.Text = "";
            cmbPlotNo.Text = "";
            txtinstallmentamount.Text = "";
            txttotalamount.Text = "";
            txtRemainingamount.Text = "";
            cmbSurveyNo.Text = "";   
            cmbPlotSellId.Text = "";
            lblcustid.Text = "0";
            btn_save.Enabled = true;
            btn_delete.Enabled = false; 
            cmbCustomer.Focus();

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
        public void print()
        {
            DialogResult result1 = MessageBox.Show("Do you want to print this Receipt?", "Account Management",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                try
                {
                    rptReceipt rpt = new rptReceipt();
                    //The report you created.
                    cmd = new OleDbCommand();
                    OleDbDataAdapter myDA = new OleDbDataAdapter();
                    DataSet myDS = new DataSet();
                    //The DataSet you created.
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT RECEIPTID,RECEIPTDATE,CUSTOMERNAME,PAYMENTMODE,CHEQUEDATE,CHEQUENO,INSTALLMENTNO,AMOUNT,EXTRADETAIL,PLOTSELLID FROM  Receipt   WHERE  RECEIPTID =" + txtReceiptNo.Text + "";
                    cmd.CommandType = CommandType.Text;
                    myDA.SelectCommand = cmd;
                    myDA.Fill(myDS, "Receipt");


                    cmd.CommandText = "SELECT Company.COMPANYNAME,Company.ADDRESS,Company.PHONENO,Company.EMAIL,Company.WEB,Company.TINNO,Company.CSTNO,Company.EXTRA1,Company.EXTRA2 FROM Company ";
                    cmd.CommandType = CommandType.Text;
                    myDA.SelectCommand = cmd;
                    myDA.Fill(myDS, "Company");

                    cmd.CommandText = "SELECT PLOTNO,SURVEYNO FROM  PlotSell   WHERE  PlotSell.PLOTSELLID =" + cmbPlotSellId.Text + "";
                    cmd.CommandType = CommandType.Text;
                    myDA.SelectCommand = cmd;
                    myDA.Fill(myDS, "Plotdetail");
              

                    con.Close();
                    rpt.SetDataSource(myDS);
       
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public void installmentbalamount()
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT SUM(AMOUNT) FROM Receipt WHERE INSTALLMENTNO=" + cmbInstallmentNo.Text + " AND PLOTSELLID=" + cmbPlotSellId.Text + "";

                string y = cmd.ExecuteScalar().ToString();
                if (y == "")
                {
                    txtRemainingamount.Text = txtinstallmentamount.Text;
                }
                else
                {
                    txtRemainingamount.Text = Convert.ToString(Convert.ToInt64(txtinstallmentamount.Text) - Convert.ToInt64(y));

                } con.Close();
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
                if (cmbpaymentmode.Text == "Cash")
                {
                    if (Convert.ToInt64(txtRemainingamount.Text) < Convert.ToInt64(txttotalamount.Text))
                    {
                        MessageBox.Show("Installment amount can not be greater than balance amount");
                        txttotalamount.Text = "";
                        txttotalamount.Focus();

                    }

                    if (txtRemainingamount.Text == txttotalamount.Text)
                    {
                        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                        con.Open();
                        string cb1 = "insert into Receipt (RECEIPTDATE,CUSTOMERID,CUSTOMERNAME,PAYMENTMODE,INSTALLMENTNO,INSTALLMENTDATE,AMOUNT,EXTRADETAIL,PLOTSELLID) VALUES ('" + dtpReceiptDate.Text + "'," + lblcustid.Text + ",'" + cmbCustomer.Text + "','" + cmbpaymentmode.Text + "'," + cmbInstallmentNo.Text + ",'" + dtpinstallmentdate.Text + "'," + txttotalamount.Text + ",'" + txt_extra1.Text + "'," + cmbPlotSellId.Text + ")";
                        cmd = new OleDbCommand(cb1);
                        cmd.Connection = con;
                        cmd.ExecuteReader();
                        con.Close();

                        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                        con.Open();
                        string cb = "UPDATE Installment  SET PAIDSTATUS= '" + PAID + "' WHERE INSTALLMENTNO=" + cmbInstallmentNo.Text + " AND PLOTSELLID =" + cmbPlotSellId.Text + "";
                        cmd = new OleDbCommand(cb);
                        cmd.Connection = con;
                        cmd.ExecuteReader();
                        con.Close();
                   
                        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                        con.Open();
                        cmd = con.CreateCommand();

                        cmd.CommandText = "SELECT MIN(BAL) as  BALANCE FROM Ledger where PLOTSELLID= " + cmbPlotSellId.Text + "";
                        rdr = cmd.ExecuteReader();
                        if (rdr.Read())
                        {
                            if (rdr.IsDBNull(rdr.GetOrdinal("BALANCE")))
                            {
                                MessageBox.Show("OLD BALANCE NOT FOUND");
                               }
                            else
                            {
                                a = Convert.ToString(Convert.ToInt64(rdr["BALANCE"]) - Convert.ToInt64(txttotalamount.Text));
                            
                            }
                         
                        }
                        if ((rdr != null))
                        {
                            rdr.Close();
                        }
                        con.Close();
                        

              
                        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                        con.Open();
                        string cb3 = "insert into Ledger(PLOTSELLID,VOUCHERDATE,VOUCHERTYPE,VOUCHERNO,CREDIT,BAL) VALUES (" + cmbPlotSellId.Text + ",'" + dtpReceiptDate.Text + "','" + "RECEIPT OF INSTALLMENT NO:" + cmbInstallmentNo.Text + " " + "'," + txtReceiptNo.Text + "," + txttotalamount.Text + "," + a.ToString() + ")";

                        cmd = new OleDbCommand(cb3);
                        cmd.Connection = con;
                        cmd.ExecuteReader();
                        con.Close();
                        MessageBox.Show("Successfully saved", "Receipt Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        print();
                        Reset();
                        return;

                    }
                    if (Convert.ToInt64(txtRemainingamount.Text) > Convert.ToInt64(txttotalamount.Text))
                    {
                        Int64 I = Convert.ToInt64(txtRemainingamount.Text) - Convert.ToInt64(txttotalamount.Text);
                        DialogResult result1 = MessageBox.Show("BALANCE AMOUNT OF THIS INSTALLMENT IS='" + Convert.ToString(I) + "'Do you want to save this Receipt?", "Account Management",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result1 == DialogResult.Yes)
                        {
                         
                            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                            con.Open();
                            string cb1 = "insert into Receipt (RECEIPTDATE,CUSTOMERID,CUSTOMERNAME,PAYMENTMODE,INSTALLMENTNO,INSTALLMENTDATE,AMOUNT,EXTRADETAIL,PLOTSELLID) VALUES ('" + dtpReceiptDate.Text + "'," + lblcustid.Text + ",'" + cmbCustomer.Text + "','" + cmbpaymentmode.Text + "'," + cmbInstallmentNo.Text + ",'" + dtpinstallmentdate.Text + "'," + txttotalamount.Text + ",'" + txt_extra1.Text + "'," + cmbPlotSellId.Text + ")";
                            cmd = new OleDbCommand(cb1);
                            cmd.Connection = con;
                            cmd.ExecuteReader();
                            con.Close();

                            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                            con.Open();
                            cmd = con.CreateCommand();
                            cmd.CommandText = "SELECT MIN(BAL) as  BALANCE FROM Ledger where PLOTSELLID=" + cmbPlotSellId.Text + "";
                            rdr = cmd.ExecuteReader();
                            if (rdr.Read())
                            {
                                if (rdr.IsDBNull(rdr.GetOrdinal("BALANCE")))
                                {
                                    MessageBox.Show("OLD BALANCE NOT FOUND");
                                }
                                else
                                {
                                    a = Convert.ToString(Convert.ToInt64(rdr["BALANCE"]) - Convert.ToInt64(txttotalamount.Text));

                                }

                            }
                            if ((rdr != null))
                            {
                                rdr.Close();
                            }
                            con.Close();



                            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                            con.Open();
                            string cb3 = "insert into Ledger(PLOTSELLID,VOUCHERDATE,VOUCHERTYPE,VOUCHERNO,CREDIT,BAL) VALUES (" + cmbPlotSellId.Text + ",'" + dtpReceiptDate.Text + "','" + "RECEIPT OF INSTALLMENT NO:" + cmbInstallmentNo.Text + " " + "'," + txtReceiptNo.Text + "," + txttotalamount.Text + "," + a.ToString() + ")";

                            cmd = new OleDbCommand(cb3);
                            cmd.Connection = con;
                            cmd.ExecuteReader();
                            con.Close();
                            MessageBox.Show("Successfully saved", "Receipt Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            print();
                            Reset();
                            return;
                        }
                    }
                }

                if (cmbpaymentmode.Text == "Cheque")
                {
                    if (txtRemainingamount.Text == txttotalamount.Text)
                    {
                        
                        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                        con.Open();
                        string cb1 = "insert into Receipt(RECEIPTDATE,CUSTOMERID,CUSTOMERNAME,PAYMENTMODE,CHEQUEDATE,CHEQUENO,INSTALLMENTNO,INSTALLMENTDATE,AMOUNT,EXTRADETAIL,PLOTSELLID) VALUES ('" + dtpReceiptDate.Text + "'," + lblcustid.Text + ",'" + cmbCustomer.Text + "','" + cmbpaymentmode.Text + "','" + dtpChequeDate.Text + "','" + txtChequeno.Text + "'," + cmbInstallmentNo.Text + ",'" + dtpinstallmentdate.Text + "'," + txttotalamount.Text + ",'" + txt_extra1.Text + "'," + cmbPlotSellId.Text + ")";
                        cmd = new OleDbCommand(cb1);
                        cmd.Connection = con;
                        cmd.ExecuteReader();
                        con.Close();

                        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                        con.Open();
                        string cb = "UPDATE Installment  SET PAIDSTATUS= '" + PAID + "' WHERE INSTALLMENTNO=" + cmbInstallmentNo.Text + " AND PLOTSELLID =" + cmbPlotSellId.Text + "";
                        cmd = new OleDbCommand(cb);
                        cmd.Connection = con;
                        cmd.ExecuteReader();
                        con.Close();

                        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                        con.Open();
                        cmd = con.CreateCommand();

                        cmd.CommandText = "SELECT MIN(BAL) as  BALANCE FROM Ledger where PLOTSELLID= " + cmbPlotSellId.Text + "";
                        rdr = cmd.ExecuteReader();
                        if (rdr.Read())
                        {
                            if (rdr.IsDBNull(rdr.GetOrdinal("BALANCE")))
                            {
                                MessageBox.Show("OLD BALANCE NOT FOUND");
                            }
                            else
                            {
                                a = Convert.ToString(Convert.ToInt64(rdr["BALANCE"]) - Convert.ToInt64(txttotalamount.Text));

                            }

                        }
                        if ((rdr != null))
                        {
                            rdr.Close();
                        }
                        con.Close();



                        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                        con.Open();
                        string cb3 = "insert into Ledger(PLOTSELLID,VOUCHERDATE,VOUCHERTYPE,VOUCHERNO,CREDIT,BAL) VALUES (" + cmbPlotSellId.Text + ",'" + dtpReceiptDate.Text + "','" + "RECEIPT OF INSTALLMENT NO:" + cmbInstallmentNo.Text + " " + "'," + txtReceiptNo.Text + "," + txttotalamount.Text + "," + a.ToString() + ")";

                        cmd = new OleDbCommand(cb3);
                        cmd.Connection = con;
                        cmd.ExecuteReader();
                        con.Close();
                        MessageBox.Show("Successfully saved", "Receipt Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        print();
                        Reset();
                        return;

                     
                        
                    }
                    if (Convert.ToInt64(txtRemainingamount.Text) < Convert.ToInt64(txttotalamount.Text))
                    {
                        MessageBox.Show("Installment amount can not be greater than balance amount");
                        txttotalamount.Text = "";
                        txttotalamount.Focus();
                    }
                    if (Convert.ToInt64(txtRemainingamount.Text) > Convert.ToInt64(txttotalamount.Text))
                    {
                        Int64 I = Convert.ToInt64(txtRemainingamount.Text) - Convert.ToInt64(txttotalamount.Text);
                        DialogResult result1 = MessageBox.Show("BALANCE AMOUNT OF THIS INSTALLMENT IS='" + Convert.ToString(I) + "'Do you want to save this Receipt?", "Account Management",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result1 == DialogResult.Yes)
                        {
                         
                            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                            con.Open();
                            string cb1 = "insert into Receipt(RECEIPTDATE,CUSTOMERID,CUSTOMERNAME,PAYMENTMODE,CHEQUEDATE,CHEQUENO,INSTALLMENTNO,INSTALLMENTDATE,AMOUNT,EXTRADETAIL,PLOTSELLID) VALUES ('" + dtpReceiptDate.Text + "'," + lblcustid.Text + ",'" + cmbCustomer.Text + "','" + cmbpaymentmode.Text + "','" + dtpChequeDate.Text + "','" + txtChequeno.Text + "'," + cmbInstallmentNo.Text + ",'" + dtpinstallmentdate.Text + "'," + txttotalamount.Text + ",'" + txt_extra1.Text + "'," + cmbPlotSellId.Text + ")";
                            cmd = new OleDbCommand(cb1);
                            cmd.Connection = con;
                            cmd.ExecuteReader();
                            con.Close();

                            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                            con.Open();
                            cmd = con.CreateCommand();
                            cmd.CommandText = "SELECT MIN(BAL) as  BALANCE FROM Ledger where PLOTSELLID= " + cmbPlotSellId.Text + "";
                            rdr = cmd.ExecuteReader();
                            if (rdr.Read())
                            {
                                if (rdr.IsDBNull(rdr.GetOrdinal("BALANCE")))
                                {
                                    MessageBox.Show("OLD BALANCE NOT FOUND");
                                }
                                else
                                {
                                    a = Convert.ToString(Convert.ToInt64(rdr["BALANCE"]) - Convert.ToInt64(txttotalamount.Text));

                                }

                            }
                            if ((rdr != null))
                            {
                                rdr.Close();
                            }
                            con.Close();



                            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                            con.Open();
                            string cb3 = "insert into Ledger(PLOTSELLID,VOUCHERDATE,VOUCHERTYPE,VOUCHERNO,CREDIT,BAL) VALUES (" + cmbPlotSellId.Text + ",'" + dtpReceiptDate.Text + "','" + "RECEIPT OF INSTALLMENT NO:" + cmbInstallmentNo.Text + " " + "'," + txtReceiptNo.Text + "," + txttotalamount.Text + "," + a.ToString() + ")";

                            cmd = new OleDbCommand(cb3);
                            cmd.Connection = con;
                            cmd.ExecuteReader();
                            con.Close();
                            MessageBox.Show("Successfully saved", "Receipt Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            print();
                            Reset();
                            return;
                        


                    }

                    }

                   

                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  
        }
          public void LEDGERPOSTINGIDGENERATION()
        {
            try
            {
                            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            cmd = con.CreateCommand();

            cmd.CommandText = "SELECT MAX(LEDGERPOSTINGID) as  LEDGERPOSTINGID FROM LedgerPosting";
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (rdr.IsDBNull(rdr.GetOrdinal("LEDGERPOSTINGID")))
                {

                    SDID = Convert.ToString("1");
                }
                else
                {
                    SDID = Convert.ToString(Convert.ToInt16(rdr["LEDGERPOSTINGID"]) + 1);
                }
            }
            if ((rdr != null))
            {
                rdr.Close();
            }
            con.Close();
            


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

                string cb = "update Receipt set  CUSTOMERID = " + lblcustid.Text + ", CUSTOMERNAME = '" + cmbCustomer.Text + "',INSTALLMENTNO = " + cmbInstallmentNo.Text + ", INSTALLMENTDATE = '" + dtpinstallmentdate.Text + "',PAYMENTMODE= '" + cmbpaymentmode.Text + "',CHEQUEDATE= '" + dtpChequeDate.Text + "',RECEIPTDATE= '" + dtpReceiptDate.Text + "',AMOUNT= " + txttotalamount.Text + ",EXTRADETAIL= '" + txt_extra1.Text + "' where RECEIPTID= " + txtReceiptNo.Text + "";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                MessageBox.Show("Successfully updated", "Receipt Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
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

        private void cmbCustomer_Leave(object sender, EventArgs e)
        { try{
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            cmd = con.CreateCommand();

            cmd.CommandText = "SELECT CUSTOMERID FROM Customer WHERE CUSTOMERNAME='"+cmbCustomer.Text+"'";
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lblcustid.Text = (rdr["CUSTOMERID"].ToString());
            }        
            con.Close();
            cmbPlotNo.Focus();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            String sql = "SELECT PlOTNO FROM PlotSell where CUSTOMERID="+lblcustid.Text+" ";
            cmd = new OleDbCommand(sql, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                
                cmbPlotNo.Items.Add(rdr[0]);
               

            }
            con.Close();



        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        }

        private void cmbInstallmentNo_Leave(object sender, EventArgs e)
        {
            try{
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            cmd = con.CreateCommand();

            cmd.CommandText = "SELECT INSTALLMENTDATE,INSTALLMENT FROM Installment WHERE INSTALLMENTNO=" + cmbInstallmentNo.Text + " AND PLOTSELLID="+cmbPlotSellId.Text+" AND CUSTOMERID="+lblcustid.Text+" ";
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dtpinstallmentdate.Text = rdr[0].ToString();
                txtinstallmentamount.Text = rdr[1].ToString();
            }
            con.Close();
            installmentbalamount();
            cmbpaymentmode.Focus();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RECEIPT_Load(object sender, EventArgs e)
        {

        }

        private void cmbpaymentmode_Leave(object sender, EventArgs e)
        {try{
            if (cmbpaymentmode.Text == "Cheque")
            {
                label1.Show();
                label4.Show();
                dtpChequeDate.Show();
                txtChequeno.Show();

                dtpChequeDate.Focus();
            }
            else 
            {
                label1.Hide();
                label4.Hide();
                dtpChequeDate.Hide();
                txtChequeno.Hide();
                txttotalamount.Focus();
            }


        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }

        private void txttotalamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPlotSellId_Leave(object sender, EventArgs e)
        {
            try{
            string x = "UNPAID";
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            String sql = "SELECT INSTALLMENTNO  FROM Installment where CUSTOMERID=" + lblcustid.Text + " AND PAIDSTATUS='" + x + "' AND PLOTSELLID="+cmbPlotSellId.Text+"";
            cmd = new OleDbCommand(sql, con);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                cmbInstallmentNo.Items.Add(rdr[0]);

            }
            con.Close();

            cmbInstallmentNo.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCustomer_KeyUp(object sender, KeyEventArgs e)
        {try{
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

        private void btnAd_Click(object sender, EventArgs e)
        {try{

            CUSTOMER frm = new CUSTOMER();
            frm.Show();
            frm.lblpath.Text = lblpath.Text;

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }

        private void cmbPlotNo_Leave(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                String sql = "SELECT SURVEYNO FROM PlotSell where CUSTOMERID=" + lblcustid.Text + " and PLOTNO='" + cmbPlotNo.Text + "'";
                cmd = new OleDbCommand(sql, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    cmbSurveyNo.Items.Add(rdr[0]);


                }
                con.Close();
                cmbSurveyNo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        }

        private void cmbSurveyNo_Leave(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                String sql = "SELECT PLOTSELLID FROM PlotSell where CUSTOMERID=" + lblcustid.Text + " and PLOTNO='" + cmbPlotNo.Text + "' AND SURVEYNO='" + cmbSurveyNo.Text + "'";
                cmd = new OleDbCommand(sql, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    cmbPlotSellId.Items.Add(rdr[0]);


                }
                con.Close();
                cmbPlotSellId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
      }

        private void txttotalamount_Leave(object sender, EventArgs e)
        {
            try
            {
                txt_extra1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
            }

      
    }
}
