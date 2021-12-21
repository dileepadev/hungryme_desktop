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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hungryme_desktop.Meals_Forms.Appetizers_Forms;
using MySql.Data.MySqlClient;
using hungryme_desktop.MyCart_Forms;

namespace hungryme_desktop.TableToMeal_Forms
{
    public partial class AppatizersSoup : UserControl
    {
        public AppatizersSoup()
        {
            InitializeComponent();
        }

       
        MySqlConnection con = new MySqlConnection("server=localhost; database=hungryme; username=root; password=");


        private void btnTomatoSoup_A_Click(object sender, EventArgs e)
        {
            Soup_Tomato soup_Tomato = new Soup_Tomato(); 
            soup_Tomato.ShowDialog();                  
        }

        private void btnGarlicSoup_A_Click(object sender, EventArgs e)
        {
            Soup_Garlic soup_Garlic = new Soup_Garlic(); 
            soup_Garlic.ShowDialog();                    
        }

        private void btnVegetableSoup_A_Click(object sender, EventArgs e)
        {
            Soup_Vegetable soup_Vegetable = new Soup_Vegetable(); 
            soup_Vegetable.ShowDialog();                          
        }


        private void btnChiickenSoup_A_Click(object sender, EventArgs e)
        {
            Soup_Chiicken soup_Chiicken = new Soup_Chiicken(); 
            soup_Chiicken.ShowDialog();                        
        }

        private void btnTomatoSoupTM_A_Click(object sender, EventArgs e)
        {
            double qty_TSTM, total_TSTM;                              
            qty_TSTM = Convert.ToDouble(nudTomatoSoupTM_A.Text);      
            total_TSTM = qty_TSTM * 120;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('TOSO_TM','Tomato Soup','120','" + nudTomatoSoupTM_A.Text + "','" + total_TSTM + "','Table To Meal')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception)
            {
                MessageBox.Show("You already added Tomato Soup to My Cart for Table To Meal");
            }
        }

      
        private void btnTomatoSoupTA_A_Click(object sender, EventArgs e)
        {
            double qty_TSTA, total_TSTA;                           
            qty_TSTA = Convert.ToDouble(nudTomatoSoupTA_A.Text);   
            total_TSTA = qty_TSTA * 120;                            

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('TOSO_TA','Tomato Soup','120','" + nudTomatoSoupTA_A.Text + "','" + total_TSTA + "','Take Away')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception)
            {
                MessageBox.Show("You already added Tomato Soup to My Cart for Take Away");
            }
        }

        private void btnGarlicSoupTM_A_Click(object sender, EventArgs e)
        {
            double qty_GSTM, total_GSTM;                              
            qty_GSTM = Convert.ToDouble(nudGarlicSoupTM_A.Text);      
            total_GSTM = qty_GSTM * 120;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('GASO_TM','Garlic Soup','120','" + nudGarlicSoupTM_A.Text + "','" + total_GSTM + "','Table To Meal')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show("You already added Garlic Soup to My Cart for Table To Meal" + ex.Message);
            }
        }

        private void btnGarlicSoupTA_A_Click(object sender, EventArgs e)
        {
            double qty_GSTA, total_GSTA;                              
            qty_GSTA = Convert.ToDouble(nudGarlicSoupTM_A.Text);      
            total_GSTA = qty_GSTA * 120;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('GASO_TA','Garlic Soup','120','" + nudGarlicSoupTA_A.Text + "','" + total_GSTA + "','Take Away')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception ex) 
            {
                MessageBox.Show("You already added Garlic Soup to My Cart for Take Away" +ex.Message);
            }
        }

        private void btnVegetableSoupTM_A_Click(object sender, EventArgs e)
        {
            double qty_VSTM, total_VSTM;                              
            qty_VSTM = Convert.ToDouble(nudVegetableSoupTM_A.Text);      
            total_VSTM = qty_VSTM * 130;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('VESO_TM','Vegetable Soup','130','" + nudVegetableSoupTM_A.Text + "','" + total_VSTM + "','Table To Meal')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show("You already added Vegetable Soup to My Cart for Table To Meal" + ex.Message);
            }
        }

        private void btnVegetableSoupTA_A_Click(object sender, EventArgs e)
        {
            double qty_VSTA, total_VSTA;                              
            qty_VSTA = Convert.ToDouble(nudVegetableSoupTA_A.Text);      
            total_VSTA = qty_VSTA * 130;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('VESO_TA','Vegetable Soup','130','" + nudVegetableSoupTA_A.Text + "','" + total_VSTA + "','Take Away')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show("You already added Vegetable Soup to My Cart for Take Away" + ex.Message);
            }
        }

        private void btnChickenSoupTM_A_Click(object sender, EventArgs e)
        {
            double qty_CSTM, total_CSTM;                              
            qty_CSTM = Convert.ToDouble(nudChickenSoupTM_A.Text);      
            total_CSTM = qty_CSTM * 160;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CKSO_TM','Chicken Soup','160','" + nudChickenSoupTM_A.Text + "','" + total_CSTM + "','Table To Meal')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show("You already added Chicken Soup to My Cart for Table To Meal" + ex.Message);
            }
        }

        private void btnChickenSoupTA_A_Click(object sender, EventArgs e)
        {
            double qty_CSTA, total_CSTA;                              
            qty_CSTA = Convert.ToDouble(nudChickenSoupTA_A.Text);      
            total_CSTA = qty_CSTA * 160;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CKSO_TA','Chicken Soup','160','" + nudChickenSoupTA_A.Text + "','" + total_CSTA + "','Take Away')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show("You already added Chicken Soup to My Cart for Take Away" + ex.Message);
            }
        }

    }

}
