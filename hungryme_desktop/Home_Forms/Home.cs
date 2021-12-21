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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            timerDTH.Start(); 
        }

        private void btnCustomerCare_Click(object sender, EventArgs e)
        {
            CustomerCare customerCare = new CustomerCare(); 
            customerCare.Show();
            this.Hide();
           
        }

        private void btnMeals_Click(object sender, EventArgs e)
        {
            Meals mealToTable = new Meals(); 
            mealToTable.Show();
            this.Hide();
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            MyAccount myAccount = new MyAccount(); 
            myAccount.Show();
            this.Hide();
        }

        private void btnMyCart_Click(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart(); 
            myCart.Show();
            this.Hide();

        }

        private void timerDTH_Tick(object sender, EventArgs e)
        {
            lblDTH.Text = DateTime.Now.ToString("dddd, dd-MMM-yyyy, HH:mm:ss");
        }

        private void btnWebPage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dileepabandara.github.io/hungryme_web/");  
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.lk/maps/place/HungryMe/@7.4705586,80.317314,17z/data=!3m1!4b1!4m5!3m4!1s0x3ae33b59825747e5:0xbc8b1a638086d545!8m2!3d7.4705586!4d80.3195027");
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com"); 
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com"); 
        }

        private void btnLinkedIn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com");
        }

        private void btnYouTube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com"); 
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com"); 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Meals mealToTable = new Meals();
            mealToTable.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CustomerCare customerCare = new CustomerCare();
            customerCare.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MyAccount myAccount = new MyAccount();
            myAccount.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart();
            myCart.Show();
            this.Hide();
        }
    }
}
