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

namespace hungryme_desktop.Meals_Forms.PastasAndMacaronis_Forms
{
    public partial class PAM_Macaronis : UserControl
    {
        public PAM_Macaronis()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost; database=hungryme; username=root; password=");

        private void btnCheeseMacaroni_BAHD_Click(object sender, EventArgs e)
        {
            Macaroni_Cheese macaroni_Cheese = new Macaroni_Cheese(); 
            macaroni_Cheese.ShowDialog();                            
        }

        private void btnChickenMacaroni_BAHD_Click(object sender, EventArgs e)
        {
            Macaroni_Chicken macaroni_Chicken = new Macaroni_Chicken(); 
            macaroni_Chicken.ShowDialog();                              
        }

        private void btnSeaFoodMacaroni_BAHD_Click(object sender, EventArgs e)
        {
            Macaroni_SeaFood macaroni_SeaFood = new Macaroni_SeaFood(); 
            macaroni_SeaFood.ShowDialog();                              
        }

        private void btnCheeseMacaroniTM_PAM_Click(object sender, EventArgs e)
        {
            double qty_CMTM, total_CMTM;
            qty_CMTM = Convert.ToDouble(nudCheeseMacaroniTM_PAM.Text);
            total_CMTM = qty_CMTM * 200;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CSMA_TM','Cheese Macaroni','200','" + nudCheeseMacaroniTM_PAM.Text + "','" + total_CMTM + "','Table To Meal')", con);
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

        private void btnCheeseMacaroniTA_PAM_Click(object sender, EventArgs e)
        {
            double qty_CMTA, total_CMTA;
            qty_CMTA = Convert.ToDouble(nudCheeseMacaroniTA_PAM.Text);
            total_CMTA = qty_CMTA * 200;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CSMA_TA','Cheese Macaroni','200','" + nudCheeseMacaroniTA_PAM.Text + "','" + total_CMTA + "','Take Away')", con);
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


        private void btnChickenMacaroniTM_PAM_Click(object sender, EventArgs e)
        {
            double qty_C2MTM, total_C2MTM;
            qty_C2MTM = Convert.ToDouble(nudChickenMacaroniTM_PAM.Text);
            total_C2MTM = qty_C2MTM * 220;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CKMA_TM','Chicken Macaroni','220','" + nudChickenMacaroniTM_PAM.Text + "','" + total_C2MTM + "','Table To Meal')", con);
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

        private void btnChickenMacaroniTA_PAM_Click(object sender, EventArgs e)
        {
            double qty_C2MTA, total_C2MTA;
            qty_C2MTA = Convert.ToDouble(nudChickenMacaroniTM_PAM.Text);
            total_C2MTA = qty_C2MTA * 220;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CKMA_TA','Chicken Macaroni','220','" + nudChickenMacaroniTA_PAM.Text + "','" + total_C2MTA + "','Take away')", con);
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

        private void btnSeaFoodMacaroniTM_PAM_Click(object sender, EventArgs e)
        {
            double qty_SFMTM, total_SFMTM;
            qty_SFMTM = Convert.ToDouble(nudSeaFoodMacaroniTM_PAM.Text);
            total_SFMTM = qty_SFMTM * 250;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SFMA_TM','Seafood Macaroni','250','" + nudSeaFoodMacaroniTM_PAM.Text + "','" + total_SFMTM + "','Table To Meal')", con);
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

        private void btnSeaFoodMacaroniTA_PAM_Click(object sender, EventArgs e)
        {
            double qty_SFMTA, total_SFMTA;
            qty_SFMTA = Convert.ToDouble(nudSeaFoodMacaroniTA_PAM.Text);
            total_SFMTA = qty_SFMTA * 250;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SFMA_TA','Seafood Macaroni','250','" + nudSeaFoodMacaroniTA_PAM.Text + "','" + total_SFMTA + "','Take Away')", con);
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
