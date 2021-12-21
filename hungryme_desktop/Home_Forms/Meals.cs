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

using hungryme_desktop.Meals_Forms;
using hungryme_desktop.TableToMeal_Forms;
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
    public partial class Meals : Form
    {
        public Meals()
        {
            InitializeComponent();
            timerDTTTM.Start(); 
        }

        private void timerDTTTM_Tick(object sender, EventArgs e)
        {
            lblDTMTT.Text=DateTime.Now.ToString("dddd, dd-MMM-yyyy, HH:mm:ss");
        }

       

        private void btnAppetizers_M_Click_1(object sender, EventArgs e)
        {
            Appetizers appetizers = new Appetizers();
            appetizers.Show();
            this.Hide();
        }

        private void btnBeverages_Click_1(object sender, EventArgs e)
        {
            Beverages beverages = new Beverages();
            beverages.Show();
            this.Hide();
        }

        private void btnDesserts_Click_1(object sender, EventArgs e)
        {
            Desserts desserts = new Desserts();
            desserts.Show();
            this.Hide();
        }

        private void btnRices_Click_1(object sender, EventArgs e)
        {
            Rices rices = new Rices();
            rices.Show();
            this.Hide();
        }

        private void btnPasAndMac_Click_1(object sender, EventArgs e)
        {
            PastasAndMacaronis pastasAndMacaronis = new PastasAndMacaronis();
            pastasAndMacaronis.Show();
            this.Hide();
        }

        private void btnNoodels_Click_1(object sender, EventArgs e)
        {
            Noodels noodels = new Noodels();
            noodels.Show();
            this.Hide();
        }

        private void btnPizzas_Click_1(object sender, EventArgs e)
        {
            Pizzas pizzas = new Pizzas();
            pizzas.Show();
            this.Hide();
        }

        private void btnBurgAndHotD_Click_1(object sender, EventArgs e)
        {
            BurgersandHotDogs burgersandHotDogs = new BurgersandHotDogs();
            burgersandHotDogs.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Appetizers appetizers = new Appetizers();
            appetizers.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Beverages beverages = new Beverages();
            beverages.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Desserts desserts = new Desserts();
            desserts.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Rices rices = new Rices();
            rices.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PastasAndMacaronis pastasAndMacaronis = new PastasAndMacaronis();
            pastasAndMacaronis.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Noodels noodels = new Noodels();
            noodels.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Pizzas pizzas = new Pizzas();
            pizzas.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BurgersandHotDogs burgersandHotDogs = new BurgersandHotDogs();
            burgersandHotDogs.Show();
            this.Hide();
        }

        private void btnHome_M_Click_1(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();
            this.Hide();
        }

        private void btnMyCart_M_Click_1(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart();
            myCart.Show();
            this.Hide();
        }
    }
}
