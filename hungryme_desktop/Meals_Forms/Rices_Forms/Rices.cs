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
using hungryme_desktop.Meals_Forms.Rices_Forms;
using hungryme_desktop.MyCart_Forms;
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
    public partial class Rices : Form
    {
        public Rices()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost; database=hungryme; username=root; password=");

        private void btnHome_R_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.ShowDialog();     
        }

        private void btnMyCart_R_Click(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart(); 
            myCart.ShowDialog();          
        }

        private void btnMeals_R_Click(object sender, EventArgs e)
        {
            Meals meals = new Meals(); 
            meals.ShowDialog();        
        }

        private void btnChickenRice_R_Click(object sender, EventArgs e)
        {
            Rice_Chicken rice_Chicken = new Rice_Chicken(); 
            rice_Chicken.ShowDialog();                      
        }

        private void btnSeaFoodRice_R_Click(object sender, EventArgs e)
        {
            Rice_SeaFood rice_SeaFood = new Rice_SeaFood(); 
            rice_SeaFood.ShowDialog();                      
        }

        private void btnVegetableRice_R_Click(object sender, EventArgs e)
        {
            Rice_Veg rice_Veg = new Rice_Veg(); 
            rice_Veg.ShowDialog();              
        }


        private void btnChickenRiceTM_R_Click(object sender, EventArgs e)
        {
            double qty_CRTM, total_CRTM;
            qty_CRTM = Convert.ToDouble(nudChickenRiceTM_R.Text);
            total_CRTM = qty_CRTM * 250;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CKRI_TM','Chicken Rice','250','" + nudChickenRiceTM_R.Text + "','" + total_CRTM + "','Table To Meal')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception ex)
            {
                AlreadyAdded alreadyAdded = new AlreadyAdded();
                alreadyAdded.ShowDialog();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChickenRiceTA_R_Click(object sender, EventArgs e)
        {
            double qty_CRTA, total_CRTA;
            qty_CRTA = Convert.ToDouble(nudChickenRiceTA_R.Text);
            total_CRTA = qty_CRTA * 250;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CKRI_TA','Chicken Rice','250','" + nudChickenRiceTA_R.Text + "','" + total_CRTA + "','Take Away')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception ex)
            {
                AlreadyAdded alreadyAdded = new AlreadyAdded();
                alreadyAdded.ShowDialog();
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSeaFoodRiceTM_R_Click(object sender, EventArgs e)
        {
            double qty_SFRTM, total_SFRTM;
            qty_SFRTM = Convert.ToDouble(nudSeaFoodRiceTM_R.Text);
            total_SFRTM = qty_SFRTM * 280;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SFRI_TM','Seafood Rice','280','" + nudSeaFoodRiceTM_R.Text + "','" + total_SFRTM + "','Table To Meal')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception ex)
            {
                AlreadyAdded alreadyAdded = new AlreadyAdded();
                alreadyAdded.ShowDialog();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeaFoodRiceTA_R_Click(object sender, EventArgs e)
        {
            double qty_SFRTA, total_SFRTA;
            qty_SFRTA = Convert.ToDouble(nudSeaFoodRiceTM_R.Text);
            total_SFRTA = qty_SFRTA * 280;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SFRI_TA','Seafood Rice','280','" + nudSeaFoodRiceTA_R.Text + "','" + total_SFRTA + "','Take Away')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception ex)
            {
                AlreadyAdded alreadyAdded = new AlreadyAdded();
                alreadyAdded.ShowDialog();
                MessageBox.Show(ex.Message);
            }
        }


        private void btnVegetableRiceTM_R_Click(object sender, EventArgs e)
        {
            double qty_VRTM, total_VRTM;
            qty_VRTM = Convert.ToDouble(nudVegetableRiceTM_R.Text);
            total_VRTM = qty_VRTM * 220;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('VERI_TM','Vegetable Rice','220','" + nudVegetableRiceTM_R.Text + "','" + total_VRTM + "','Table To Meal')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception ex)
            {
                AlreadyAdded alreadyAdded = new AlreadyAdded();
                alreadyAdded.ShowDialog();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVegetableRiceTA_R_Click(object sender, EventArgs e)
        {
            double qty_VRTA, total_VRTA;
            qty_VRTA = Convert.ToDouble(nudVegetableRiceTA_R.Text);
            total_VRTA = qty_VRTA * 220;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('VERI_TA','Vegetable Rice','220','" + nudVegetableRiceTA_R.Text + "','" + total_VRTA + "','Take Away')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception ex)
            {
                AlreadyAdded alreadyAdded = new AlreadyAdded();
                alreadyAdded.ShowDialog();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMeals_R_Click_1(object sender, EventArgs e)
        {
            Meals meals = new Meals();
            meals.Show();
            this.Hide();
        }

        private void btnHome_R_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnMyCart_R_Click_1(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart();
            myCart.Show();
            this.Hide();
        }
    }
}
