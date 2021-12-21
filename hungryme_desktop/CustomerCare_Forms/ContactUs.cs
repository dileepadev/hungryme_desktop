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

namespace hungryme_desktop.CustomerCare_Forms
{
    public partial class ContactUs : Form
    {
        public ContactUs()
        {
            InitializeComponent();
        }


        private void btnSendHO_CC_Click(object sender, EventArgs e)
        {
            string to, from, pass, mail;
            to = ("receiver_gmail").ToString();
            from = ("sender_gmail").ToString();
            mail = (txtMail.Text).ToString();
            pass = ("sender_gmail_password").ToString();
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mail;
            message.Subject = "Customer Feedback";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Email send successfully", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string to, from, pass, mail;
            to = ("receiver_gmail").ToString();
            from = ("sender_gmail").ToString();
            mail = (txtMail.Text).ToString();
            pass = ("sender_gmail_password").ToString();
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mail;
            message.Subject = "Customer Feedback";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Email send successfully", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerCare customerCare = new CustomerCare();
            customerCare.Show();
            this.Hide();
        }

        private void btnHome_CC_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();
            this.Hide();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            CustomerCare customer = new CustomerCare();
            customer.Show();
            this.Hide();
        }

        private void btnWebPage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dileepabandara.github.io/hungryme_web/");
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.lk/maps/place/HungryMe/@7.4705586,80.317314,17z/data=!3m1!4b1!4m5!3m4!1s0x3ae33b59825747e5:0xbc8b1a638086d545!8m2!3d7.4705586!4d80.3195027");
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/");
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void btnYouTube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void btnLinkedIn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/");
        }
    }
}
