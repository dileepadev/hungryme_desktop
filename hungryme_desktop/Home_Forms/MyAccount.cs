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

using hungryme_desktop.Home_Forms;
using hungryme_desktop.MyAccount_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hungryme_desktop
{
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
            timerDTMA.Start(); 
        }

        private void timerDTMA_Tick(object sender, EventArgs e)
        {
            lblDTMA.Text=DateTime.Now.ToString("dddd, dd-MMM-yyyy, HH:mm:ss"); 
        }

        private void btnCA_MA_Click(object sender, EventArgs e)
        {
            OTPSMS oTPSMS = new OTPSMS();
            oTPSMS.Show();
            //CreateAnAccount createAnAccount = new CreateAnAccount(); 
            //createAnAccount.Show();
            this.Hide();
        }

        private void btnLI_MA_Click(object sender, EventArgs e)
        {
            Log_In log_In = new Log_In();
            log_In.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OTPSMS oTPSMS = new OTPSMS();
            oTPSMS.Show();
            this.Hide();
        }

        private void btnMyCart_MA_Click(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart();
            myCart.Show();
            this.Hide();
        }

        private void btnHome_MA_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
