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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            

        }
        

        OleDbConnection cnn = new OleDbConnection();
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection myConnection = default(OleDbConnection);
                myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';");

                OleDbCommand myCommand = default(OleDbCommand);

                myCommand = new OleDbCommand("SELECT USERNAME,PASSWORD FROM LOGIN WHERE USERNAME = @username AND PASSWORD = @UserPassword", myConnection);
                OleDbParameter uName = new OleDbParameter("@username", OleDbType.VarChar);
                OleDbParameter uPassword = new OleDbParameter("@UserPassword", OleDbType.VarChar);
                uName.Value = UserID.Text;
                uPassword.Value = Password.Text;
                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                   


                      this.Hide();
                      MAINFORM frm = new MAINFORM();
                      frm.lblcompanypath.Text = lblpath.Text;
                      frm.lblcompanyname.Text = lblcompanyname.Text;
                      frm.Show();
                      this.Hide();

                      Check_Expiry();
                      

                }


                else
                {
                    MessageBox.Show("Password or Username doesn't match.", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    UserID.Clear();
                    Password.Clear();
                    UserID.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Check_Expiry()
        {
            DateTime newDate = new DateTime();
            TimeSpan RemainingDay = new TimeSpan();
            DateTime TodayDate = DateTime.Today;

            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }

                string strCom = "Select ExpiryDate, FirstDay from Expiry where sr = 1";


                cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';";
                cnn.Open();

                OleDbCommand Comm = new OleDbCommand(strCom, cnn);

                OleDbDataReader dr = Comm.ExecuteReader();

                while (dr.Read())
                {
                    if (dr[0] == DBNull.Value)
                    {
                        newDate = DateTime.Today;
                        Insert_Expiry_Date(newDate);
                    }
                    else if (Convert.ToDateTime(dr[1]) > DateTime.Today)
                    {
                        MessageBox.Show("Please correct your System Date.", "SMS");
                        Application.Exit();
                    }
                    else if (Convert.ToDateTime(dr[0]) < DateTime.Today)
                    {
                        MessageBox.Show("Please correct your System Date.", "SMS");
                        Application.Exit();
                    }
                    else
                    {
                        if (Convert.ToDateTime(dr[0]) == DateTime.Today)
                        {
                            MessageBox.Show("Your trail period is expired. Please purchase this Software.", "SMS");
                            Application.Exit();
                        }
                        else
                        {
                            newDate = Convert.ToDateTime(dr[0]);
                            RemainingDay = newDate.Subtract(TodayDate);

                            MessageBox.Show("You have " + RemainingDay.Days + " days Left.", "SMS");
                        }
                    }
                }

                dr.Dispose();
                Comm.Dispose();
                cnn.Close();
        }
        private void Insert_Expiry_Date(DateTime date)
        {
            try
            {

                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }


                string strCom = "update Expiry set ExpiryDate = #" + date.AddDays(10) +
                    "#, FirstDay = #" + date + "# where sr = 1";

                cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblpath.Text + "';";
                cnn.Open();

                OleDbCommand Comm = new OleDbCommand(strCom, cnn);

                Comm.ExecuteNonQuery();

                MessageBox.Show("You have 10 days left to use this Software.", "SMS");

                Comm.Dispose();
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
