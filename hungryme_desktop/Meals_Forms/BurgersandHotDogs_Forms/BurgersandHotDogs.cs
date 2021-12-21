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
    public partial class BurgersandHotDogs : Form
    {
        public BurgersandHotDogs()
        {
            InitializeComponent();
        }

        private void btnHome_BAHD_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.ShowDialog();      
        }

        private void btnMyCart_BAHD_Click(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart(); 
            myCart.ShowDialog();          
        }

        private void btnMeals_BAHD_Click(object sender, EventArgs e)
        {
            Meals meals = new Meals(); 
            meals.ShowDialog();        
        }

        private void btnBurgers_BAHD_Click(object sender, EventArgs e)
        {
            btnBurgers_BAHD.Height = btnBurgers_BAHD.Height; 
            btnBurgers_BAHD.Top = btnBurgers_BAHD.Top;       
            bahD_Burgers1.BringToFront();                    
            burgers1.BringToFront();                         
        }

        private void btnHotDogs_BAHD_Click(object sender, EventArgs e)
        {
            btnHotDogs_BAHD.Height = btnHotDogs_BAHD.Height; 
            btnHotDogs_BAHD.Top = btnHotDogs_BAHD.Top;       
            bahD_HotDogs1.BringToFront();                    
            hotDogs1.BringToFront();                         
        }

        private void btnMeals_BAHD_Click_1(object sender, EventArgs e)
        {
            Meals meals = new Meals();
            meals.Show();
            this.Hide();
        }

        private void btnHome_BAHD_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnMyCart_BAHD_Click_1(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart();
            myCart.Show();
            this.Hide();
        }
    }
}
