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
    public partial class PAM_Pastas : UserControl
    {
        public PAM_Pastas()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost; database=hungryme; username=root; password=");

        private void btnCheesePasta_BAHD_Click(object sender, EventArgs e)
        {
            Pasta_Cheese pasta_Cheese = new Pasta_Cheese(); 
            pasta_Cheese.ShowDialog();                      
        }

        private void btnChickenPasta_BAHD_Click(object sender, EventArgs e)
        {
            Pasta_Chicken pasta_Chicken = new Pasta_Chicken(); 
            pasta_Chicken.ShowDialog();                        
        }

        private void btnSeaFoodPasta_BAHD_Click(object sender, EventArgs e)
        {
            Pasta_SeaFood pasta_SeaFood = new Pasta_SeaFood(); 
            pasta_SeaFood.ShowDialog();                        
        }


        private void btnCheesePastaTM_PAM_Click(object sender, EventArgs e)
        {
            double qty_CPTM, total_CPTM;
            qty_CPTM = Convert.ToDouble(nudCheesePastaTM_PAM.Text);
            total_CPTM = qty_CPTM * 200;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CSPA_TM','Cheese Pasta','200','" + nudCheesePastaTM_PAM.Text + "','" + total_CPTM + "','Table To Meal')", con);
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

        private void btnCheesePastaTA_PAM_Click(object sender, EventArgs e)
        {
            double qty_CPTA, total_CPTA;
            qty_CPTA = Convert.ToDouble(nudCheesePastaTA_PAM.Text);
            total_CPTA = qty_CPTA * 200;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CSPA_TA','Cheese Pasta','200','" + nudCheesePastaTA_PAM.Text + "','" + total_CPTA + "','Take Away')", con);
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


        private void btnChickenPastaTM_PAM_Click(object sender, EventArgs e)
        {
            double qty_C2PTM, total_C2PTM;
            qty_C2PTM = Convert.ToDouble(nudChickenPastaTM_PAM.Text);
            total_C2PTM = qty_C2PTM * 240;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CKPA_TM','Chicken Pasta','240','" + nudChickenPastaTM_PAM.Text + "','" + total_C2PTM + "','Table To Meal')", con);
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

        private void btnChickenPastaTA_PAM_Click(object sender, EventArgs e)
        {
            double qty_C2PTA, total_C2PTA;
            qty_C2PTA = Convert.ToDouble(nudChickenPastaTA_PAM.Text);
            total_C2PTA = qty_C2PTA * 240;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CKPA_TA','Chicken Pasta','240','" + nudChickenPastaTA_PAM.Text + "','" + total_C2PTA + "','Take Away')", con);
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


        private void btnSeaFoodPastaTM_PAM_Click(object sender, EventArgs e)
        {
            double qty_SFPTM, total_SFPTM;
            qty_SFPTM = Convert.ToDouble(nudSeaFoodPastaTM_PAM.Text);
            total_SFPTM = qty_SFPTM * 250;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SFPA_TM','Seafood Pasta','250','" + nudSeaFoodPastaTM_PAM.Text + "','" + total_SFPTM + "','Table To Meal')", con);
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

        private void btnSeaFoodPastaTA_PAM_Click(object sender, EventArgs e)
        {
            double qty_SFPTA, total_SFPTA;
            qty_SFPTA = Convert.ToDouble(nudSeaFoodPastaTA_PAM.Text);
            total_SFPTA = qty_SFPTA * 250;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SFPA_TA','Seafood Pasta','250','" + nudSeaFoodPastaTA_PAM.Text + "','" + total_SFPTA + "','Take Away')", con);
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
