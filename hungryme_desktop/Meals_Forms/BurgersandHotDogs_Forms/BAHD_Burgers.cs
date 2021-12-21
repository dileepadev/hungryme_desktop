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
using MySql.Data.MySqlClient;
using hungryme_desktop.MyCart_Forms;

namespace hungryme_desktop.Meals_Forms.BurgersandHotDogs_Forms
{
    public partial class BAHD_Burgers : UserControl
    {
        public BAHD_Burgers()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost; database=hungryme; username=root; password=");

        private void btnCheeseBurger_BAHD_Click(object sender, EventArgs e)
        {
            Burger_Cheese burger_Cheese = new Burger_Cheese(); 
            burger_Cheese.ShowDialog();                        
        }

        private void btnChickenBurger_BAHD_Click(object sender, EventArgs e)
        {
            Burger_Chicken burger_Chicken = new Burger_Chicken(); 
            burger_Chicken.ShowDialog();                          
        }

        private void btnFishBurger_BAHD_Click(object sender, EventArgs e)
        {
            Burger_Fish burger_Veg = new Burger_Fish(); 
            burger_Veg.ShowDialog();                  
        }


        private void btnCheeseBurgerTM_BAHD_Click(object sender, EventArgs e)
        {
            double qty_CBTM, total_CBTM;                              
            qty_CBTM = Convert.ToDouble(nudCheeseBurgerTM_BAHD.Text);      
            total_CBTM = qty_CBTM * 150;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CSBU_TM','Cheese Burger','150','" + nudCheeseBurgerTM_BAHD.Text + "','" + total_CBTM + "','Table To Meal')", con);
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

        private void btnCheeseBurgerTA_BAHD_Click(object sender, EventArgs e)
        {
            double qty_CBTA, total_CBTA;                              
            qty_CBTA = Convert.ToDouble(nudCheeseBurgerTA_BAHD.Text);      
            total_CBTA = qty_CBTA * 150;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CSBU_TA','Cheese Burger','150','" + nudCheeseBurgerTA_BAHD.Text + "','" + total_CBTA + "','Take Away')", con);
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

        private void btnChickenBurgerTM_BAHD_Click(object sender, EventArgs e)
        {
            double qty_C2BTM, total_C2BTM;                              
            qty_C2BTM = Convert.ToDouble(nudChickenBurgerTM_BAHD.Text);      
            total_C2BTM = qty_C2BTM * 170;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CKBU_TM','Chicken Burger','170','" + nudChickenBurgerTM_BAHD.Text + "','" + total_C2BTM + "','Table To Meal')", con);
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

        private void btnChickenBurgerTA_BAHD_Click(object sender, EventArgs e)
        {
            double qty_C2BTA, total_C2BTA;                              
            qty_C2BTA = Convert.ToDouble(nudChickenBurgerTA_BAHD.Text);      
            total_C2BTA = qty_C2BTA * 170;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CKBU_TA','Chicken Burger','170','" + nudChickenBurgerTA_BAHD.Text + "','" + total_C2BTA + "','Take Away')", con);
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


        private void btnFishBurgerTM_BAHD_Click(object sender, EventArgs e)
        {
            double qty_FBTM, total_FBTM;                              
            qty_FBTM = Convert.ToDouble(nudFishBurgerTM_BAHD.Text);      
            total_FBTM = qty_FBTM * 160;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('FBU_TM','Fish Burger','160','" + nudCheeseBurgerTM_BAHD.Text + "','" + total_FBTM + "','Table To Meal')", con);
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

        private void btnFishBurgerTA_BAHD_Click(object sender, EventArgs e)
        {
            double qty_FBTA, total_FBTA;                              
            qty_FBTA = Convert.ToDouble(nudFishBurgerTA_BAHD.Text);      
            total_FBTA = qty_FBTA * 160;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('FBU_TA','Fish Burger','160','" + nudCheeseBurgerTA_BAHD.Text + "','" + total_FBTA + "','Take Away')", con);
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
    }
}
