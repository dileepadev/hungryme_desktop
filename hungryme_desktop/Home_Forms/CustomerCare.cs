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

using hungryme_desktop.CustomerCare_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hungryme_desktop.Home_Forms
{
    public partial class CustomerCare : Form
    {
        public CustomerCare()
        {
            InitializeComponent();
            timerHM.Start(); 
        }

        private void timerHM_Tick(object sender, EventArgs e)
        {
            lblDTHM.Text=DateTime.Now.ToString("dddd, dd-MMM-yyyy, HH:mm:ss"); 
        }

        private void btnWaiter_Click(object sender, EventArgs e)
        {
            Waiter waiter = new Waiter();
            waiter.Show();
        }

        private void btnHeadOffice_Click(object sender, EventArgs e)
        {
            ContactUs headOffice = new ContactUs();
            headOffice.Show();
            this.Hide();
        }

        private void pictureBox_Waiter_Click(object sender, EventArgs e)
        {
            Waiter waiter = new Waiter();
            waiter.Show();
        }

        private void pictureBox_ContactUs_Click(object sender, EventArgs e)
        {
            ContactUs headOffice = new ContactUs();
            headOffice.Show();
            this.Hide();
        }

        private void btnHome_CC_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();
            this.Hide();
        }

    }
}
