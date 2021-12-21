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
using hungryme_desktop.Home_Forms;

namespace hungryme_desktop.MyAccount_Forms
{
    public partial class OTPSMS : Form
    {
        string randomNumber;
        public OTPSMS()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "" )
            {
                MessageBox.Show("Please fill your name and email", "Fill information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Random rnd = new Random();
                randomNumber = (rnd.Next(000000, 999999)).ToString();

                string to, from, pass, mail;
                to = (txtEmail.Text).ToString();
                from = ("sender_gmail").ToString();
                mail = ("Hi " + txtName.Text + "! Your verification code is " + randomNumber).ToString();
                pass = ("sender_gmail_password").ToString();
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = mail;
                message.Subject = "Verification Code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Your verification code has send to your email. Please use that code to fill below box.", "Verification code", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == randomNumber)
            {
                MessageBox.Show("Verify successfully. Please complete forms.", "Verify Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CreateAnAccount createAnAccount = new CreateAnAccount(); 
                createAnAccount.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Use verification code to verify", "Use Verification code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MyAccount myAccount = new MyAccount();
            myAccount.Show();
            this.Hide();
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
    }
}
