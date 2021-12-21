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
using hungryme_desktop.Meals_Forms.Beverages_Forms;
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
    public partial class Beverages : Form
    {
        public Beverages()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost; database=hungryme; username=root; password=");

        private void btnHome_B_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.ShowDialog();      
        }

        private void btnMyCart_B_Click(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart(); 
            myCart.ShowDialog();          
        }

        private void btnTea_B_Click(object sender, EventArgs e)
        {
            Tea tea = new Tea(); 
            tea.ShowDialog();    
        }

        private void btnCoffee_B_Click(object sender, EventArgs e)
        {
            Coffee coffee = new Coffee(); 
            coffee.ShowDialog();          
        }

        private void btnMilkShake_B_Click(object sender, EventArgs e)
        {
            MilkShake milkShake = new MilkShake(); 
            milkShake.ShowDialog();                
        }

        private void btnSoftDrinks_B_Click(object sender, EventArgs e)
        {
            SoftDrinks softDrinks = new SoftDrinks(); 
            softDrinks.ShowDialog();                  
        }

        private void btnMeals_B_Click(object sender, EventArgs e)
        {
            Meals meals = new Meals(); 
            meals.ShowDialog();        
        }


        private void btnTeaTM_B_Click(object sender, EventArgs e)
        {
            double qty_TTM, total_TTM;                              
            qty_TTM = Convert.ToDouble(nudTeaTM_B.Text);      
            total_TTM = qty_TTM * 50;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('TEBE_TM','Tea','50','" + nudTeaTM_B.Text + "','" + total_TTM + "','Table To Meal')", con);
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

        private void btnTeaTA_B_Click(object sender, EventArgs e)
        {
            double qty_TTA, total_TTA;                              
            qty_TTA = Convert.ToDouble(nudTeaTA_B.Text);      
            total_TTA = qty_TTA * 50;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('TEBE_TA','Tea','50','" + nudTeaTM_B.Text + "','" + total_TTA + "','Take Away')", con);
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

        private void btnCoffeeTM_B_Click(object sender, EventArgs e)
        {
            double qty_CTM, total_CTM;                              
            qty_CTM = Convert.ToDouble(nudCoffeeTM_B.Text);      
            total_CTM = qty_CTM * 60;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('COBE_TM','Coffee','60','" + nudCoffeeTM_B.Text + "','" + total_CTM + "','Table To Meal')", con);
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

        private void btnCoffeeTA_B_Click(object sender, EventArgs e)
        {
            double qty_CTA, total_CTA;                              
            qty_CTA = Convert.ToDouble(nudCoffeeTA_B.Text);      
            total_CTA = qty_CTA * 60;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('COBE_TA','Coffee','60','" + nudCoffeeTA_B.Text + "','" + total_CTA + "','Take Away')", con);
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

        private void btnMilkShakeTM_B_Click(object sender, EventArgs e)
        {
            double qty_MSTM, total_MSTM;                              
            qty_MSTM = Convert.ToDouble(nudMilkShakeTM_B.Text);      
            total_MSTM = qty_MSTM * 120;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('MSBE_TM','Milk Shake','120','" + nudMilkShakeTM_B.Text + "','" + total_MSTM + "','Table To Meal')", con);
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

        private void btnMilkShakeTA_B_Click(object sender, EventArgs e)
        {
            double qty_MSTA, total_MSTA;                              
            qty_MSTA = Convert.ToDouble(nudMilkShakeTA_B.Text);      
            total_MSTA = qty_MSTA * 120;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('MSBE_TA','Milk Shake','120','" + nudMilkShakeTA_B.Text + "','" + total_MSTA + "','Take Away')", con);
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

        private void btnSoftDrinksTM_B_Click(object sender, EventArgs e)
        {
            double qty_SDTM, total_SDTM;                            
            qty_SDTM = Convert.ToDouble(nudSoftDrinksTM_B.Text);      
            total_SDTM = qty_SDTM * 100;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SDBE_TM','Soft Drinks','100','" + nudSoftDrinksTM_B.Text + "','" + total_SDTM + "','Table To Meal')", con);
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

        private void btnSoftDrinksTA_B_Click(object sender, EventArgs e)
        {
            double qty_SDTA, total_SDTA;                              
            qty_SDTA = Convert.ToDouble(nudSoftDrinksTA_B.Text);      
            total_SDTA = qty_SDTA * 100;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SDBE_TA','Soft Drinks','100','" + nudSoftDrinksTA_B.Text + "','" + total_SDTA + "','Take Away')", con);
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

        private void btnMeals_B_Click_1(object sender, EventArgs e)
        {
            Meals meals = new Meals();
            meals.Show();
            this.Hide();
        }

        private void btnHome_B_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnMyCart_B_Click_1(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart();
            myCart.Show();
            this.Hide();
        }
    }
}
