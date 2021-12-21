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
using hungryme_desktop.Meals_Forms.Noodels_Forms;
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
    public partial class Noodels : Form
    {
        public Noodels()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost; database=hungryme; username=root; password=");

        private void btnHome_N_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.ShowDialog();      
        }

        private void btnMyCart_N_Click(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart(); 
            myCart.ShowDialog();          
        }

        private void btnMeals_N_Click(object sender, EventArgs e)
        {
            Meals meals = new Meals(); 
            meals.ShowDialog();        
        }

        private void btnCheeseNoodels_N_Click(object sender, EventArgs e)
        {
            Noodels_Cheese noodels_Cheese = new Noodels_Cheese(); 
            noodels_Cheese.ShowDialog();                          
        }

        private void btnChickenNoodels_N_Click(object sender, EventArgs e)
        {
            Noodels_Chicken noodels_Chicken = new Noodels_Chicken(); 
            noodels_Chicken.ShowDialog();                            
        }

        private void btnSeaFoodNoodels_N_Click(object sender, EventArgs e)
        {
            Noodels_SeaFood noodels_SeaFood = new Noodels_SeaFood(); 
            noodels_SeaFood.ShowDialog();                            
        }

        private void btnVegetableNoodels_N_Click(object sender, EventArgs e)
        {
            Noodels_Veg noodels_Veg = new Noodels_Veg(); 
            noodels_Veg.ShowDialog();                    
        }


        private void btnChickenNoodelsTM_N_Click(object sender, EventArgs e)
        {
            double qty_CNTM, total_CNTM;
            qty_CNTM = Convert.ToDouble(nudChickenNoodelsTM_N.Text);
            total_CNTM = qty_CNTM * 240;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CKNO_TM','Chicken Noodels','240','" + nudChickenNoodelsTM_N.Text + "','" + total_CNTM + "','Table To Meal')", con);
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

        private void btnChickenNoodelsTA_N_Click(object sender, EventArgs e)
        {
            double qty_CNTA, total_CNTA;
            qty_CNTA = Convert.ToDouble(nudChickenNoodelsTA_N.Text);
            total_CNTA = qty_CNTA * 240;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CKNO_TA','Chicken Noodels','240','" + nudChickenNoodelsTA_N.Text + "','" + total_CNTA + "','Take Away')", con);
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

        
        private void btnCheeseNoodelsTM_N_Click(object sender, EventArgs e)
        {
            double qty_C2NTM, total_C2NTM;
            qty_C2NTM = Convert.ToDouble(nudCheeseNoodelsTM_N.Text);
            total_C2NTM = qty_C2NTM * 220;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CSNO_TM','Cheese Noodels','220','" + nudCheeseNoodelsTM_N.Text + "','" + total_C2NTM + "','Table To Meal')", con);
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

        private void btnCheeseNoodelsTA_N_Click(object sender, EventArgs e)
        {
            double qty_C2NTA, total_C2NTA;
            qty_C2NTA = Convert.ToDouble(nudCheeseNoodelsTA_N.Text);
            total_C2NTA = qty_C2NTA * 220;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CSNO_TA','Cheese Noodels','220','" + nudCheeseNoodelsTM_N.Text + "','" + total_C2NTA + "','Take Away')", con);
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

        private void btnSeaFoodNoodelsTM_N_Click(object sender, EventArgs e)
        {
            double qty_SFNTM, total_SFNTM;
            qty_SFNTM = Convert.ToDouble(nudSeaFoodNoodelsTM_N.Text);
            total_SFNTM = qty_SFNTM * 250;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SFNO_TM','Seafood Noodels','250','" + nudSeaFoodNoodelsTM_N.Text + "','" + total_SFNTM + "','Table To Meal')", con);
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

        private void btnSeaFoodNoodelsTA_N_Click(object sender, EventArgs e)
        {
            double qty_SFNTA, total_SFNTA;
            qty_SFNTA = Convert.ToDouble(nudSeaFoodNoodelsTA_N.Text);
            total_SFNTA = qty_SFNTA * 250;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SFNO_TA','Seafood Noodels','250','" + nudSeaFoodNoodelsTA_N.Text + "','" + total_SFNTA + "','Take Away')", con);
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


        private void btnVegetableNoodelsTM_N_Click(object sender, EventArgs e)
        {
            double qty_VNTM, total_VNTM;
            qty_VNTM = Convert.ToDouble(nudVegetableNoodelsTM_N.Text);
            total_VNTM = qty_VNTM * 200;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('VENO_TM','Vegetable Noodels','200','" + nudVegetableNoodelsTM_N.Text + "','" + total_VNTM + "','Table To Meal')", con);
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

        private void btnVegetableNoodelsTA_N_Click(object sender, EventArgs e)
        {
            double qty_VNTA, total_VNTA;
            qty_VNTA = Convert.ToDouble(nudVegetableNoodelsTA_N.Text);
            total_VNTA = qty_VNTA * 200;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('VENO_TA','Vegetable Noodels','200','" + nudVegetableNoodelsTM_N.Text + "','" + total_VNTA + "','Take Away')", con);
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

        private void btnMeals_N_Click_1(object sender, EventArgs e)
        {
            Meals meals = new Meals();
            meals.Show();
            this.Hide();
        }

        private void btnHome_N_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnMyCart_N_Click_1(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart();
            myCart.Show();
            this.Hide();
        }
    }
}
