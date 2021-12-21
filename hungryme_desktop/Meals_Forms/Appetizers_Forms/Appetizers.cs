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

namespace hungryme_desktop.TableToMeal_Forms
{
    public partial class Appetizers : Form
    {
        public Appetizers()
        {
            InitializeComponent();
            btnSoups_A.Height = btnSoups_A.Height; 
            btnSoups_A.Top = btnSoups_A.Top;       
            appatizersSoup1.BringToFront();       

        }

        private void btnSalads_A_Click(object sender, EventArgs e)
        {
            btnSalads_A.Height = btnSalads_A.Height;  
            btnSalads_A.Top = btnSalads_A.Top;        
            appatizersSalads1.BringToFront();        
            salads1.BringToFront();                   
        }

        private void btnSoups_A_Click(object sender, EventArgs e)
        {
            btnSoups_A.Height = btnSoups_A.Height; 
            btnSoups_A.Top = btnSoups_A.Top;       
            appatizersSoup1.BringToFront();        
            soups1.BringToFront();                 
        }

        private void btnMyCart_A_Click(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart(); 
            myCart.Show();
            this.Hide();
        }

        private void btnHome_A_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnMeals_A_Click(object sender, EventArgs e)
        {
            Meals meals = new Meals(); 
            meals.Show();
            this.Hide();
        }

    }
}
