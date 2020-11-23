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
    public partial class SALESINVOICEcs : Form
    {
        public SALESINVOICEcs()
        {
            InitializeComponent();
        }
        OleDbDataReader rdr = null;
        DataTable dtable = new DataTable();
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        DataTable dt = new DataTable();
        string TAXPER,SDID;

        private void btnAd_Click(object sender, EventArgs e)
        {
            CUSTOMERENTRY frm = new CUSTOMERENTRY();
            frm.Show();
            frm.lblpath.Text = lblpath.Text;
        }
        public void itemresete()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            String sql4 = "SELECT ITEMNAME FROM ItemMaster";
            cmd = new OleDbCommand(sql4, con);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                cmbitemname.Items.Add(rdr[0]);
            }
            con.Close();


        }
        public void Reset()
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT MAX(SALEMASTERID) as  SALEMASTERID FROM SaleMaster ";
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr.IsDBNull(rdr.GetOrdinal("SALEMASTERID")))
                    {
                        txtinvoiceno.Text = Convert.ToString("1");
                    }
                    else
                    {
                        txtinvoiceno.Text = Convert.ToString(Convert.ToInt16(rdr["SALEMASTERID"]) + 1);
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

                itemresete();
                txtTotqty.Text = "";
                txtunit.Text = "";
                txtprice.Text = "";
                txtPaymentDue.Text = "";
                txtGrandTotal.Text = "";
                txtdiscper.Text = "0";
                txtdiscount.Text = "0";
                
                txtmrp.Text = "";
                txttotdiscount.Text = "";
                cmbitemname.Text = "";
                cmbCustomer.Text = "";
                txtitemno.Text = "";
                txtqty.Text = "1";
                txttax.Text = "";
                txttaxname.Text = "";
                txttotaltax.Text = "";
                txtTotalPayment.Text = "";
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                cmbCustomer.Focus();

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

        private void dgwCompany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




     
        public void GetData()
        {
            try
            {

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                String sql = "SELECT SLNO,ITEMID,ITEMNAME,SERIALNO,MODELNO,QTY,RATE,BASICAMOUNT,TAXAMOUNT,NETAMOUNT,DISCOUNT,AMOUNT FROM SaleDetail WHERE SALEMASTERID=" + txtinvoiceno.Text + " order by SLNO";
                cmd = new OleDbCommand(sql, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dgwSales.Rows.Clear();
                while (rdr.Read() == true)
                {
                  
                    dgwSales.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11]);
                    int val1 = 0;
                    double val2 = 0;
                    double val3 = 0;
                    double val4 = 0;
                    int.TryParse(txtTotqty.Text, out val1);
                    double.TryParse(txtGrandTotal.Text, out val2);
                    double.TryParse(txttotaltax.Text, out val3);
                    double.TryParse(txttotdiscount.Text, out val4);
                    txtTotqty.Text = Convert.ToString(val1 + Convert.ToInt64(rdr[5].ToString()));
                    txtGrandTotal.Text = Convert.ToString(val2+ Convert.ToDouble(rdr[11].ToString()));
                    txttotaltax.Text = Convert.ToString(val3 + Convert.ToDouble(rdr[8].ToString()));
                    txttotdiscount.Text = Convert.ToString(val4 + Convert.ToDouble(rdr[10].ToString()));
                }
                con.Close();
                
               
          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void INSERTINVENTORY()
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT MAX(INVENTORYID) as  INVENTORYID FROM INVENTORY";
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr.IsDBNull(rdr.GetOrdinal("INVENTORYID")))
                    {

                        SDID = Convert.ToString("1");
                    }
                    else
                    {
                        SDID = Convert.ToString(Convert.ToInt16(rdr["INVENTORYID"]) + 1);
                    }
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                con.Close();
            

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                string cb = "insert into INVENTORY(INVENTORYID,INVENTORYDATE,VOUCHERTYPE,VOUCHERNO,ITEMID,ITEMNAME,OUTQTY) VALUES (" + SDID + ",'" + dtpDate.Text+ "','" + "VAT INVOICE" + "'," + txtinvoiceno.Text + "," + txtitemno.Text + ",'" + cmbitemname.Text + "'," + txtqty.Text + ")";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
  
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            string cb = "insert into SaleMaster(SALEMASTERID,SALEDATE,SALETYPE,CREDITDATE,ACCOUNTID,ACCOUNTNAME,GRANDTOTAL,TAX,DISCOUNT,PAID,PAYMENTDUE,LRNO,TRANSPORTCOMPANY) VALUES (" + txtinvoiceno.Text + ",'" + dtpDate.Text + "','" + "VAT INVOICE" + "','" + dtpCreditDate.Text + "'," + lblcustid.Text + ",'" + cmbCustomer.Text + "'," + txtGrandTotal.Text + "," + txttotaltax.Text + "," + txttotdiscount.Text + "," + txtTotalPayment.Text + "," + txtPaymentDue.Text + ",'" + txtlrno.Text + "','" + txttransport.Text + "')";
            cmd = new OleDbCommand(cb);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();

            LEDGERPOSTINGIDGENERATION();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            string cb1 = "insert into LedgerPosting(LEDGERPOSTINGID,LDATE,ACCOUNTID,ACCOUNTNAME,VOUCHERTYPE,VOCHERNO,DEBIT) VALUES (" + SDID + ",'" + dtpDate.Text + "'," + lblcustid.Text + ",'" + cmbCustomer.Text + "','" + "VAT INVOICE" + "'," + txtinvoiceno.Text + "," + txtGrandTotal.Text + ")";
            cmd = new OleDbCommand(cb1);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();

            LEDGERPOSTINGIDGENERATION();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            string cb2 = "insert into LedgerPosting(LEDGERPOSTINGID,LDATE,ACCOUNTID,ACCOUNTNAME,VOUCHERTYPE,VOCHERNO,CREDIT) VALUES (" + SDID + ",'" + dtpDate.Text + "'," + lblcustid.Text + ",'" + cmbCustomer.Text + "','" + "VATINVOICE INSTANT PAYMENT" + "'," + txtinvoiceno.Text + "," +txtTotalPayment.Text  + ")";
            cmd = new OleDbCommand(cb2);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            print();
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

                        cmd.CommandText = "SELECT ACCOUNTID FROM Account WHERE ACCOUNTNAME='" + cmbCustomer.Text + "'";
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            lblcustid.Text = (rdr["ACCOUNTID"].ToString());
                        }
                        con.Close();
                        txtitemno.Focus();

                    }
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
                cmbitemname.Focus();
            }
        }

        private void cmbitemname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    if (cmbitemname.Text != null)
                    {
                        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                        con.Open();
                        cmd = con.CreateCommand();

                        cmd.CommandText = "SELECT ITEMID,UNITID,UNITNAME,SALERATE,MRP,TAXID,TAXNAME FROM ItemMaster WHERE ITEMNAME='" + cmbitemname.Text + "'";
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            txtitemno.Text = (rdr["ITEMID"].ToString());
                            lblunitid.Text = (rdr["UNITID"].ToString());
                            txtunit.Text = (rdr["UNITNAME"].ToString());
                            txtprice.Text = (rdr["SALERATE"].ToString());
                            txtmrp.Text = (rdr["MRP"].ToString());
                            lblTaxid.Text = (rdr["TAXID"].ToString());
                            txttaxname.Text = (rdr["TAXNAME"].ToString());

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
                txtModelNo.Focus();
            }
        }

        private void txtModelNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtqty.Focus();
            }
        }

        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtprice.Focus();
            }
        }

        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {

                    double val1 = 0;
                    double val2 = 0;
                    double.TryParse(txtqty.Text, out val1);
                    double.TryParse(txtprice.Text, out val2);
                    double I = (val1 * val2);
                    txtBasicAmount.Text = I.ToString();

                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    cmd = con.CreateCommand();

                    cmd.CommandText = "SELECT TAXPER FROM Tax WHERE TAXNAME='" + txttaxname.Text + "'";
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        TAXPER = (rdr["TAXPER"].ToString());
                    }
                    con.Close();
                    txttax.Text = Convert.ToInt32((Convert.ToInt32(txtBasicAmount.Text) * Convert.ToDouble(TAXPER) / 100)).ToString();
                    txtNetAmount.Text = Convert.ToInt32((Convert.ToInt32(txtBasicAmount.Text) + Convert.ToDouble(txttax.Text))).ToString();
                    txtdiscper.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                try
                {

                    double val1 = 0;
                    double val2 = 0;
                    double.TryParse(txtqty.Text, out val1);
                    double.TryParse(txtprice.Text, out val2);
                    double I = (val1 * val2);
                    txtBasicAmount.Text = I.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      

        private void txtdiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    INSERTINVENTORY();
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    cmd = con.CreateCommand();

                    cmd.CommandText = "SELECT MAX(SALEDETAILID) as  SALEDETAILID FROM SaleDetail";
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        if (rdr.IsDBNull(rdr.GetOrdinal("SALEDETAILID")))
                        {

                            SDID = Convert.ToString("1");
                        }
                        else
                        {
                            SDID = Convert.ToString(Convert.ToInt16(rdr["SALEDETAILID"]) + 1);
                        }
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    con.Close();

                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    string cb = "insert into SaleDetail(SALEDETAILID,SALEMASTERID,ITEMID,ITEMNAME,SERIALNO,MODELNO,QTY,RATE,BASICAMOUNT,NETAMOUNT,UNITID,UNITNAME,TAXID,TAXNAME,TAXAMOUNT,DISCOUNT,AMOUNT,SLNO,DISCOUNTPER) VALUES (" + SDID + "," + txtinvoiceno.Text + "," + txtitemno.Text + ",'" + cmbitemname.Text + "','" + txtSerialNo.Text + "','" + txtModelNo.Text + "'," + txtqty.Text + "," + txtprice.Text + "," + txtBasicAmount.Text + "," + txtNetAmount.Text + "," + lblunitid.Text + ",'" + txtunit.Text + "'," + lblTaxid.Text + ",'" + txttaxname.Text + "'," + txttax.Text + "," + txtdiscount.Text + "," + txtamount.Text + "," + lblSlNo.Text + "," + txtdiscper.Text + ")";
                    cmd = new OleDbCommand(cb);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();

                    GetData();


                    txtunit.Text = "";
                    txtprice.Text = "";
                    txtdiscper.Text = "0";
                    txtdiscount.Text = "0";
                    txtmrp.Text = "";
                    cmbitemname.Text = "";
                    txtitemno.Text = "";
                    txtqty.Text = "1";
                    txttax.Text = "";
                    txttaxname.Text = "";
                    txtamount.Text = "";
                    txtNetAmount.Text = "";
                    txtBasicAmount.Text = "";

                    txtitemno.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }



        

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtdiscount.Text != "")
            {

                try
                {

                    txtdiscount.Text = Convert.ToDouble((Convert.ToDouble(txtNetAmount.Text) * Convert.ToDouble(txtdiscper.Text) / 100)).ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void print()
        {
            DialogResult result1 = MessageBox.Show("Do you want to print this Invoice?", "Account Management",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                try
                {
                    CrystalReport.rptVatInvoice rpt =new CrystalReport.rptVatInvoice();
                    //The report you created.
                    cmd = new OleDbCommand();
                    OleDbDataAdapter myDA = new OleDbDataAdapter();
                    DataSet myDS = new DataSet();
                    //The DataSet you created.
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT  SALEMASTERID,SALEDATE,SALETYPE,CREDITDATE,ACCOUNTID,ACCOUNTNAME,GRANDTOTAL,TAX,DISCOUNT,TOTAL,LRNO,TRANSPORTCOMPANY,EXTRA,EXTRA1,EXTRA2,EXTRA3,EXTRA4,PAID,PAYMENTDUE from SaleMaster  WHERE  SALEMASTERID=" + txtinvoiceno.Text + "";
                    cmd.CommandType = CommandType.Text;
                    myDA.SelectCommand = cmd;
                    myDA.Fill(myDS, "SaleMaster");


                    cmd.CommandText = "SELECT Company.COMPANYNAME,Company.ADDRESS,Company.PHONENO,Company.EMAIL,Company.WEB,Company.TINNO,Company.CSTNO,Company.EXTRA1,Company.EXTRA2 FROM Company ";
                    cmd.CommandType = CommandType.Text;
                    myDA.SelectCommand = cmd;
                    myDA.Fill(myDS, "Company");

                    cmd.CommandText = "SELECT SALEDETAILID,SALEMASTERID,ITEMID,SERIALNO,MODELNO,ITEMNAME,QTY,RATE,UNITID,UNITNAME,BASICAMOUNT,NETAMOUNT,TAXID,TAXNAME,TAXAMOUNT,DISCOUNTPER,DISCOUNT,AMOUNT,SLNO,EXTRA,EXTRA1,EXTRA2,EXTRA3,EXTRA4 FROM  SaleDetail   WHERE  SALEMASTERID=" + txtinvoiceno.Text + "";
                    cmd.CommandType = CommandType.Text;
                    myDA.SelectCommand = cmd;
                    myDA.Fill(myDS, "SaleDetail");


                    con.Close();
                    rpt.SetDataSource(myDS);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        
        private void txtTotalPayment_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSave.Focus();
            }
            else
            {
                txtPaymentDue.Text = Convert.ToString(Convert.ToDouble(txtGrandTotal.Text) - Convert.ToDouble(txtTotalPayment.Text));
            }
        }

        private void txtdiscper_TextChanged(object sender, EventArgs e)
        {
            if (txtdiscper.Text != "")
            {

                try
                {

                    txtdiscount.Text = Convert.ToDouble((Convert.ToDouble(txtprice.Text) * Convert.ToDouble(txtdiscper.Text) / 100)).ToString();
                    txtamount.Text = Convert.ToDouble((Convert.ToDouble(txtBasicAmount.Text) - Convert.ToDouble(txtdiscount.Text))).ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtdiscper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtamount.Text = Convert.ToString(Convert.ToDouble(txtNetAmount.Text) - Convert.ToDouble(txtdiscount.Text));
                txtdiscount.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
