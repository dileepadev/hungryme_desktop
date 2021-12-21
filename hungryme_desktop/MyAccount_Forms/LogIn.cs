/*
   --------------------------------------
      Developed by
      Dileepa Bandara
      https://dileepabandara.github.io
      contact.dileepabandara@gmail.com
      ©dileepabandara.dev
      2019
   --------------------------------------
*/

using MySql.Data.MySqlClient;
using hungryme_desktop.Home_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hungryme_desktop.MyAccount_Forms
{
    public partial class Log_In : Form
    {
        int i;
        public Log_In()
        {
            InitializeComponent();
            timer1.Start();
        }

        MySqlConnection con = new MySqlConnection("server=localhost; database=hungryme; username=root; password=");

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                
                con.Open();
                i = 0;
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM customeraccounts WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    lblLoginStatus.Text = "You have enterd invalid username and password";
                }
                else
                {
                    MyLogedAccount myAccount = new MyLogedAccount();
                    myAccount.Show();
                    this.Hide();
                }

                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("error = " + ex.Message);
            }


        }

        private void btnShowPasswrd_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword2.Text;
        }

        private void btnShowPasswrd_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword2.Hide();
        }

        private void btnHome_MC_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();
            this.Hide();
        }

        private void btnMyCart_MC_Click(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart(); 
            myCart.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OTPSMS oTPSMS = new OTPSMS();
            oTPSMS.Show();
            //CreateAnAccount createAnAccount = new CreateAnAccount(); 
            //createAnAccount.Show();
            this.Hide();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MyAccount myAccount = new MyAccount();
            myAccount.Show();
            this.Hide();
        }

        private void btnHome_MC_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnMyCart_MC_Click_1(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart();
            myCart.Show();
            this.Hide();
        }
    }
}
