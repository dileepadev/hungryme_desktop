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
using System.Net;
using System.Net.Mail;

namespace hungryme_desktop.MyAccount_Forms
{
    public partial class CreateAnAccount : Form
    {
        public CreateAnAccount()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        String Gender;
        MySqlConnection con = new MySqlConnection("server=localhost; database=hungryme; username=root; password=");

        private void btnSignUpCA_MA_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                if (chkAccept.Checked)
                {
                    if (radMale.Checked)
                    {
                        Gender = "M";
                    }
                    if (radFemale.Checked)
                    {
                        Gender = "F";
                    }
                    if (radOther.Checked)
                    {
                        Gender = "O";
                    }

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO customeraccounts(Username, Password, ReEnterPassword, Email, MobileNo, Gender)VALUES( '" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtReEnterPassword.Text + "','" + txtEmail.Text + "','" + txtMobileNo.Text + "', '" + Gender + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your Sign Up is Done.  Welcome " + txtUsername.Text);


                    string to, from, pass, mail;
                    to = (textBox1.Text).ToString();
                    from = ("sender_gmail").ToString();
                    mail = ("Hi ! Welcome to HungryMe Restaurants").ToString();
                    pass = ("sender_gmail_password").ToString();
                    MailMessage message = new MailMessage();
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = mail;
                    message.Subject = "Welcome to HungryMe";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtp.Send(message);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }


                    txtUsername.Text = null;
                    txtPassword.Text = null;
                    txtReEnterPassword.Text = null;
                    txtEmail.Text = null;
                    txtMobileNo.Text = null;

                    MyLogedAccount myAccount = new MyLogedAccount();
                    myAccount.Show();
                    this.Hide();


                    

                }
                else
                {
                    MessageBox.Show("You cannot Sign Up without Accept");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("This Username is already taken by someone! Please use another username" +ex.Message);
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword2.Hide();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword2.Text;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            txtReEnterPassword2.Hide();
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            txtReEnterPassword2.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            txtReEnterPassword.Text = txtReEnterPassword2.Text;
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

        private void btnLogInCA_MA_Click(object sender, EventArgs e)
        {
            Log_In log_In = new Log_In();
            log_In.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OTPSMS oTPSMS = new OTPSMS();
            oTPSMS.Show();
            this.Hide();
        }

        private void btnMyCart_MC_Click_1(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart();
            myCart.Show();
            this.Hide();
        }

        private void btnHome_MC_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
