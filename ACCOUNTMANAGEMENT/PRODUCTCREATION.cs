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
    public partial class PRODUCTCREATION : Form
    {
        public PRODUCTCREATION()
        {    
            InitializeComponent();
        }

        OleDbDataReader rdr = null;
        DataTable dtable = new DataTable();
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        DataTable dt = new DataTable();
        string batchstatus;
        string INVID;
        private Purchase purchase;



        public void batch()
        {
            if (checkBox1.Checked == true)
            {
                batchstatus = "true";

            }
            else
            {
                batchstatus = "false";

            }
        }
        public void group()
        {
            cmbGroup.Items.Clear();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            String sql = "SELECT GROUPNAME FROM ProductGroup";
            cmd = new OleDbCommand(sql, con);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                cmbGroup.Items.Add(rdr[0]);
                cmbSearchGroupName.Items.Add(rdr[0]);
            }
            con.Close();


        }
        public void taxresete()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            String sql2 = "SELECT TAXNAME FROM Tax";
            cmd = new OleDbCommand(sql2, con);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                cmbTax.Items.Add(rdr[0]);
            }
            con.Close();

        }

        public void productcompanyresete()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            String sql1 = "SELECT PRODUCTCOMPANYNAME FROM ProductCompany";
            cmd = new OleDbCommand(sql1, con);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                cmbCompany.Items.Add(rdr[0]);
                cmbSearchCompanyName.Items.Add(rdr[0]);
            }
            con.Close();
        }
        public void unitresete()
        
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            String sql3 = "SELECT UNITNAME FROM Unit";
            cmd = new OleDbCommand(sql3, con);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                cmbUnit.Items.Add(rdr[0]);
                cmbAltUnit.Items.Add(rdr[0]);
            }
            con.Close();
        }
        public void Reset()
        {
            try
            {
                cmbCompany.Items.Clear();
                cmbGroup.Items.Clear();
                cmbAltUnit.Items.Clear();
                cmbUnit.Items.Clear();
                cmbTax.Items.Clear();
                cmbSearchCompanyName.Items.Clear();
                cmbSearchGroupName.Items.Clear();
                cmbSearchItemName.Items.Clear();

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT MAX(ITEMID) as  ITEMID FROM ItemMaster";
                rdr = cmd.ExecuteReader();

                if ((rdr != null))
                {
                    rdr.Close();
                }
                con.Close();


                group();
                productcompanyresete();

                taxresete();
                unitresete();
             
              

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                String sql4 = "SELECT ITEMNAME FROM ItemMaster";
                cmd = new OleDbCommand(sql4, con);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    cmbSearchItemName.Items.Add(rdr[0]);
                }
                con.Close();
                txtItemName.Text = "";
                cmbGroup.Text = "";
                cmbCompany.Text = "";
                cmbUnit.Text = "";
                cmbSearchCompanyName.Text = "";
                cmbSearchGroupName.Text = "";
                cmbSearchItemName.Text = "";
                checkBox1.Checked = false;
                txtPurchaseRate.Text = "";
                txtSaleRate.Text = "";
                txtMrp.Text = "";
                txtOpStock.Text = "0";
                txtOpStockValue.Text = "0";
                txtMinimumQty.Text = "0";
                txtConversionFactor.Text = "0";
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                label10.Visible = false;
                label11.Visible = false;
                cmbAltUnit.Visible = false;
                txtConversionFactor.Visible = false;
                GRIDFILL();
                txtItemName.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GRIDFILL()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
            con.Open();
            String sql5 = "SELECT  ITEMID,ITEMNAME,GROUPNAME,PRODUCTCOMPANYNAME,TAXNAME,UNITNAME,PURCHASERATE,SALERATE,MRP FROM ItemMaster";
            cmd = new OleDbCommand(sql5, con);
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dgwItem.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgwItem.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8]);
            }
            con.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            new UNIT(this).Show();

        }

        private void btnAd_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            new TAX(this).Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                batch();
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                string cb = "insert into ItemMaster(ITEMID,ITEMNAME,GROUPID,GROUPNAME,PRODUCTCOMPANYID,PRODUCTCOMPANYNAME,UNITID,UNITNAME,TAXID,TAXNAME,PURCHASERATE,SALERATE,MRP,OPSTOCK,OPSTOCKVALUE,MINIMUMQTY,ALTUNITID,ALTUNITNAME,CONVERSIONFACTOR,MAINTAINBATCH) VALUES (" + ",'" + txtItemName.Text + "'," + ",'" + cmbGroup.Text + "'," + ",'" + cmbCompany.Text + "'," + ",'" + cmbUnit.Text + "'," + ",'" + cmbTax.Text + "'," + txtPurchaseRate.Text + "," + txtSaleRate.Text + "," + txtMrp.Text + "," + txtOpStock.Text + "," + txtOpStockValue.Text + "," + txtMinimumQty.Text + ","+ ",'" + cmbAltUnit.Text + "'," + txtConversionFactor.Text + ",'" + batchstatus + "')";
                cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                if (Convert.ToDouble(txtOpStock.Text) > 0)
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

                            INVID = Convert.ToString("1");
                        }
                        else
                        {
                            INVID = Convert.ToString(Convert.ToInt16(rdr["INVENTORYID"]) + 1);
                        }
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    con.Close();
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    string cb1 = "insert into INVENTORY(INVENTORYID,INVENTORYDATE,VOUCHERTYPE,VOUCHERNO,ITEMID,ITEMNAME,INQTY,OUTQTY) VALUES (" + INVID + ",'" + DateTime.Today + "','" + "OPENING STOCK" + ",'" + txtItemName.Text + "'," + txtOpStock.Text + "," + "0" + ")";
                    cmd = new OleDbCommand(cb1);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();
                }
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
                batch();

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT INVENTORYID as  INVENTORYID FROM INVENTORY WHERE  VOUCHERTYPE='" + "OPENING STOCK" + "' AND VOUCHERNO=" +  " ";
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr.IsDBNull(rdr.GetOrdinal("INVENTORYID")))
                    {

                        MessageBox.Show("NO INVENTRY");
                    }
                    else
                    {
                        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                        con.Open();
                        string cb = "update INVENTORY set  ITEMNAME = '" + txtItemName.Text + "', INQTY =" + txtOpStock.Text + "  where  VOUCHERTYPE='" + "OPENING STOCK" + " ";
                        cmd = new OleDbCommand(cb);
                        cmd.Connection = con;
                        cmd.ExecuteReader();
                        con.Close();
                
                    }
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                con.Close();
                  
                
                
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                string cb1 = "update ItemMaster set  ITEMNAME = '" + txtItemName.Text + "', GROUPID =" + " , GROUPNAME= '" + cmbGroup.Text + "',PRODUCTCOMPANYID = "  + ", PRODUCTCOMPANYNAME ='" + cmbCompany.Text + "' , UNITID= "  + ",UNITNAME = '" + cmbUnit.Text + "', TAXID ="   + " , TAXNAME= '" + cmbTax.Text + "',PURCHASERATE = " + txtPurchaseRate.Text + ", SALERATE =" + txtSaleRate.Text + " , MRP= " + txtMrp.Text + ",OPSTOCK = " + txtOpStock.Text + ", OPSTOCKVALUE =" + txtOpStockValue.Text + " , MINIMUMQTY= " + txtMinimumQty.Text + ",ALTUNITID = "   + ", ALTUNITNAME ='" + cmbAltUnit.Text + "' , CONVERSIONFACTOR= " + txtConversionFactor.Text + ",MAINTAINBATCH = '" + batchstatus + "' where  ITEMID = "   + "";
                cmd = new OleDbCommand(cb1);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully updated", "ItemMaster", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT VOUCHERTYPE  as  VOUCHERTYPE FROM INVENTORY WHERE  ITEMID=" + " ";
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr.IsDBNull(rdr.GetOrdinal("VOUCHERTYPE")))
                    {

                        MessageBox.Show("NO INVENTRY");
                    }
                    else
                    {
                       
                        if (Convert.ToString(rdr["VOUCHERTYPE"])!="OPENING STOCK")
                        {
                            MessageBox.Show("REFERANCE EXIST FIRST DELETE REFERENCE");
                        }
                        else 
                        {
                            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                            con.Open();
                            string cb = "DELETE FROM INVENTORY WHERE ITEMID = " + "";
                            cmd = new OleDbCommand(cb);
                            cmd.Connection = con;
                            cmd.ExecuteReader();
                            con.Close();
                        }
                    }
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                con.Close();
                  
                

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                string cb1 = "DELETE FROM ItemMaster WHERE ITEMID = " + "";
                cmd = new OleDbCommand(cb1);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully Deleted", "ItemMaster", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Form fc = Application.OpenForms["Purchase"];
                  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PRODUCTCOMPANY(this).Show();
        }

        private void btnAu_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            label11.Visible = true;
            cmbAltUnit.Visible = true;
            txtConversionFactor.Visible = true;

        }

        private void txtOpStock_Leave(object sender, EventArgs e)
        {
        }

        private void txtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {

                    cmbGroup.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }


        private void cmbCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {

                    cmbTax.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void cmbUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {

                    txtPurchaseRate.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

      

        private void txtPurchaseRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {

                    txtSaleRate.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtSaleRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {


                    txtMrp.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtMrp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {


                    txtMinimumQty.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtMinimumQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {


                    txtOpStock.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtOpStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {

                    txtOpStockValue.Text = Convert.ToString(Convert.ToDouble(txtPurchaseRate.Text) * Convert.ToDouble(txtOpStock.Text));

                    btnSave.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }


        private void btnAd_Click_1(object sender, EventArgs e)
        {
            try
            {

                new GROUP(this).Show();

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F3)
            {
                try
                {

                    if ("group reset" == GROUP.SetValueForText1)
                    {
                        GROUP.SetValueForText1 = "";
                        group();

                    }
                  

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void cmbGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    cmd = con.CreateCommand();

                    cmd.CommandText = "SELECT GROUPID FROM ProductGroup WHERE GROUPNAME='" + cmbGroup.Text + "'";
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        if (rdr.IsDBNull(rdr.GetOrdinal("GROUPID")))
                        {

                            MessageBox.Show("Invalid Group Id");
                        }
         
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    con.Close();
                    cmbCompany.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } if (e.KeyData == Keys.F3)
            {
                try
                {

                    new GROUP(this).Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cmbCompany_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    cmd = con.CreateCommand();

                    cmd.CommandText = "SELECT PRODUCTCOMPANYID FROM ProductCompany WHERE PRODUCTCOMPANYNAME='" + cmbCompany.Text + "'";
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        if (rdr.IsDBNull(rdr.GetOrdinal("PRODUCTCOMPANYID")))
                        {

                            MessageBox.Show("Invalid COMPANYID Id");
                        }
        
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    con.Close();

                    cmbTax.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } if (e.KeyData == Keys.F3)
            {
                try
                {

                    new PRODUCTCOMPANY(this).Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cmbTax_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    cmd = con.CreateCommand();

                    cmd.CommandText = "SELECT TAXID FROM Tax WHERE TAXNAME='" + cmbTax.Text + "'";
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        if (rdr.IsDBNull(rdr.GetOrdinal("TAXID")))
                        {

                            MessageBox.Show("Invalid TAXID Id");
                        }
              
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    con.Close();
                    cmbUnit.Focus();
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } if (e.KeyData == Keys.F3)
            {
                try
                {

                    new TAX(this).Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cmbUnit_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    cmd = con.CreateCommand();

                    cmd.CommandText = "SELECT UNITID FROM Unit WHERE UNITNAME='" +cmbUnit.Text + "'";
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        if (rdr.IsDBNull(rdr.GetOrdinal("UNITID")))
                        {

                            MessageBox.Show("Invalid UNITID Id");
                        }
              
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    con.Close();

                   txtPurchaseRate.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } if (e.KeyData == Keys.F3)
            {
                try
                {

                    new UNIT(this).Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void cmbAltUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                    con.Open();
                    cmd = con.CreateCommand();

                    cmd.CommandText = "SELECT UNITID FROM Tax WHERE UNITNAME='" + cmbUnit.Text + "'";
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        if (rdr.IsDBNull(rdr.GetOrdinal("UNITID")))
                        {

                            MessageBox.Show("Invalid UNITID Id");
                        }
                 
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    con.Close();

                    txtPurchaseRate.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } if (e.KeyData == Keys.F3)
            {
                try
                {

                    new UNIT(this).Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchItemName.Text != "")
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                String sql5 = "SELECT  ITEMID,ITEMNAME,GROUPNAME,PRODUCTCOMPANYNAME,TAXNAME,UNITNAME,PURCHASERATE,SALERATE,MRP FROM ItemMaster where ITEMNAME ='"+cmbSearchItemName.Text+"' ";
                cmd = new OleDbCommand(sql5, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dgwItem.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dgwItem.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8]);
                }
                con.Close();
            } if (cmbSearchCompanyName.Text != "")
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                String sql5 = "SELECT  ITEMID,ITEMNAME,GROUPNAME,PRODUCTCOMPANYNAME,TAXNAME,UNITNAME,PURCHASERATE,SALERATE,MRP FROM ItemMaster where PRODUCTCOMPANYNAME ='" + cmbSearchCompanyName.Text + "'";
                cmd = new OleDbCommand(sql5, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dgwItem.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dgwItem.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8]);
                }
                con.Close();
            } if (cmbSearchGroupName.Text != "")
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
                con.Open();
                String sql5 = "SELECT  ITEMID,ITEMNAME,GROUPNAME,PRODUCTCOMPANYNAME,TAXNAME,UNITNAME,PURCHASERATE,SALERATE,MRP FROM ItemMaster where GROUPNAME ='" + cmbSearchGroupName.Text + "'";
                cmd = new OleDbCommand(sql5, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dgwItem.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dgwItem.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8]);
                }
                con.Close();
            }
        }

        private void dgwItem_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

             
               con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");
               con.Open();
               cmd = con.CreateCommand();

               cmd.CommandText = "SELECT  ITEMID,ITEMNAME,GROUPID,GROUPNAME,PRODUCTCOMPANYID,PRODUCTCOMPANYNAME,UNITID,UNITNAME,TAXID,TAXNAME,PURCHASERATE,SALERATE,MRP,OPSTOCK,OPSTOCKVALUE,MINIMUMQTY,ALTUNITID,ALTUNITNAME,CONVERSIONFACTOR FROM ItemMaster where ITEMID =" + dgwItem.SelectedRows[0].Cells[0].Value.ToString() + "";
               rdr = cmd.ExecuteReader();
               if (rdr.Read())
               {
                   if (rdr.IsDBNull(rdr.GetOrdinal("ITEMID")))
                   {
                       MessageBox.Show("INVALID SELECTION");
                       
                   }
                   else
                   {
                     
                   txtItemName.Text = Convert.ToString(rdr["ITEMNAME"]);
                  
                    cmbGroup.Text = Convert.ToString(rdr["GROUPNAME"]);
                
                   cmbCompany.Text = Convert.ToString(rdr["PRODUCTCOMPANYNAME"]);
                
                      cmbUnit.Text = Convert.ToString(rdr["UNITNAME"]);
                   
                     cmbTax.Text = Convert.ToString(rdr["TAXNAME"]);
                    txtPurchaseRate.Text = Convert.ToString(rdr["PURCHASERATE"]);
                     txtSaleRate.Text = Convert.ToString(rdr["SALERATE"]);
                     txtMrp.Text = Convert.ToString(rdr["MRP"]);
                   txtOpStock.Text = Convert.ToString(rdr["OPSTOCK"]);
                     txtOpStockValue.Text = Convert.ToString(rdr["OPSTOCKVALUE"]);
                  txtMinimumQty.Text = Convert.ToString(rdr["MINIMUMQTY"]);
                  
                     cmbAltUnit.Text = Convert.ToString(rdr["ALTUNITNAME"]);
                   txtConversionFactor.Text = Convert.ToString(rdr["CONVERSIONFACTOR"]);

                   btnSave.Enabled = false;
                   btnDelete.Enabled = true;
                 

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

        private void PRODUCTCREATION_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
          //    Form fc1 = Application.OpenForms["SALESINVOICEcs"];

           // if (fc1 != null)
           //{

           //      ths1.itemresete();
           //      ths1.cmbitemname.Focus();
           // }
            
        }
        


    }
}
