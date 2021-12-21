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

namespace hungryme_desktop.Meals_Forms
{
    public partial class PastasAndMacaronis : Form
    {
        public PastasAndMacaronis()
        {
            InitializeComponent();
        }

        private void btnHome_PAM_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.ShowDialog();      
        }

        private void btnMyCart_PAM_Click(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart(); 
            myCart.ShowDialog();          
        }

        private void btnMeals_PAM_Click(object sender, EventArgs e)
        {
            Meals meals = new Meals(); 
            meals.ShowDialog();        
        }

        private void btnPastas_PAM_Click(object sender, EventArgs e)
        {
            btnPastas_PAM.Height = btnPastas_PAM.Height;
            btnPastas_PAM.Top = btnPastas_PAM.Top;       
            paM_Pastas1.BringToFront();                  
            pastas1.BringToFront();                      
        }

        private void btnMacaronis_PAM_Click(object sender, EventArgs e)
        {
            btnMacaronis_PAM.Height = btnMacaronis_PAM.Height; 
            btnMacaronis_PAM.Top = btnMacaronis_PAM.Top;       
            paM_Macaronis1.BringToFront();                     
            macaronis1.BringToFront();                         
        }

        private void btnMeals_PAM_Click_1(object sender, EventArgs e)
        {
            Meals meals = new Meals();
            meals.Show();
            this.Hide();
        }

        private void btnHome_PAM_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnMyCart_PAM_Click_1(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart();
            myCart.Show();
            this.Hide();
        }
    }
}
