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
using hungryme_desktop.Meals_Forms.Pizzas_Forms;
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

namespace hungryme_desktop.TableToMeal_Forms
{
    public partial class Pizzas : Form
    {
        public Pizzas()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost; database=hungryme; username=root; password=");

        private void btnHome_P_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.ShowDialog();      
        }

        private void btnMyCart_P_Click(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart(); 
            myCart.ShowDialog();          
        }

        private void btnMeals_P_Click(object sender, EventArgs e)
        {
            Meals meals = new Meals(); 
            meals.ShowDialog();        
        }

        private void btnChickenPizza_P_Click(object sender, EventArgs e)
        {
            Pizza_Chicken pizza_Chicken = new Pizza_Chicken(); 
            pizza_Chicken.ShowDialog();                        
        }

        private void btnSpicyPizza_P_Click(object sender, EventArgs e)
        {
            Pizza_Spicy pizza_Spicy = new Pizza_Spicy(); 
            pizza_Spicy.ShowDialog();                    
        }

        private void btnVegetablePizza_P_Click(object sender, EventArgs e)
        {
            Pizza_Veg pizza_Veg = new Pizza_Veg(); 
            pizza_Veg.ShowDialog();                
        }

        private void btnCheesePizza_P_Click(object sender, EventArgs e)
        {
            Pizza_Cheese pizza_Cheese = new Pizza_Cheese(); 
            pizza_Cheese.ShowDialog();                      
        }


        private void btnCheesePizzaTM_P_Click(object sender, EventArgs e)
        {
            double qty_C2PTM, total_C2PTM;
            qty_C2PTM = Convert.ToDouble(nudCheesePizzaTM_P.Text);
            total_C2PTM = qty_C2PTM * 240;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CSPI_TM','Cheese Pizza','240','" + nudChickenPizzaTM_P.Text + "','" + total_C2PTM + "','Table To Meal')", con);
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

        private void btnCheesePizzaTA_P_Click(object sender, EventArgs e)
        {
            double qty_C2PTA, total_C2PTA;
            qty_C2PTA = Convert.ToDouble(nudCheesePizzaTA_P.Text);
            total_C2PTA = qty_C2PTA * 240;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CSPI_TA','Cheese Pizza','240','" + nudChickenPizzaTA_P.Text + "','" + total_C2PTA + "','Take Away')", con);
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


        private void btnChickenPizzaTM_P_Click(object sender, EventArgs e)
        {
            double qty_CPTM, total_CPTM;
            qty_CPTM = Convert.ToDouble(nudChickenPizzaTM_P.Text);
            total_CPTM = qty_CPTM * 250;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CKPI_TM','Chicken Pizza','250','" + nudChickenPizzaTM_P.Text + "','" + total_CPTM + "','Table To Meal')", con);
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

        private void btnChickenPizzaTA_P_Click(object sender, EventArgs e)
        {
            double qty_CPTA, total_CPTA;
            qty_CPTA = Convert.ToDouble(nudChickenPizzaTA_P.Text);
            total_CPTA = qty_CPTA * 250;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CKPI_TA','Chicken Pizza','250','" + nudChickenPizzaTA_P.Text + "','" + total_CPTA + "','Take Away')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception ex)
            {
                AlreadyAdded alreadyAdded = new AlreadyAdded();
                alreadyAdded.ShowDialog();
                MessageBox.Show(ex.Message); ;
            }
        }


        private void btnSpicyPizzaTM_P_Click(object sender, EventArgs e)
        {
            double qty_SPTM, total_SPTM;
            qty_SPTM = Convert.ToDouble(nudSpicyPizzaTM_P.Text);
            total_SPTM = qty_SPTM * 220;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SPPI_TM','Spicy Pizza','220','" + nudSpicyPizzaTM_P.Text + "','" + total_SPTM + "','Table To Meal')", con);
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

        private void btnSpicyPizzaTA_P_Click(object sender, EventArgs e)
        {
            double qty_SPTA, total_SPTA;
            qty_SPTA = Convert.ToDouble(nudSpicyPizzaTA_P.Text);
            total_SPTA = qty_SPTA * 220;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SPPI_TA','Spicy Pizza','220','" + nudSpicyPizzaTA_P.Text + "','" + total_SPTA + "','Take Away')", con);
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


        private void btnVegetablePizzaTM_P_Click(object sender, EventArgs e)
        {
            double qty_VPTM, total_VPTM;
            qty_VPTM = Convert.ToDouble(nudVegetablePizzaTM_P.Text);
            total_VPTM = qty_VPTM * 200;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('VEPI_TM','Vegetable Pizza','200','" + nudVegetablePizzaTM_P.Text + "','" + total_VPTM + "','Table To Meal')", con);
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

        private void btnVegetablePizzaTA_P_Click(object sender, EventArgs e)
        {
            double qty_VPTA, total_VPTA;
            qty_VPTA = Convert.ToDouble(nudVegetablePizzaTA_P.Text);
            total_VPTA = qty_VPTA * 200;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('VEPI_TA','Vegetable Pizza','200','" + nudVegetablePizzaTA_P.Text + "','" + total_VPTA + "','Take Away')", con);
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

        private void btnMeals_P_Click_1(object sender, EventArgs e)
        {
            Meals meals = new Meals();
            meals.Show();
            this.Hide();
        }

        private void btnHome_P_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnMyCart_P_Click_1(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart();
            myCart.Show();
            this.Hide();
        }
    }
}
