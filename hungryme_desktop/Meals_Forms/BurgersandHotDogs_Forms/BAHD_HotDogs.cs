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
    public partial class BAHD_HotDogs : UserControl
    {
        public BAHD_HotDogs()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost; database=hungryme; username=root; password=");

        private void btnCheeseDog_BAHD_Click(object sender, EventArgs e)
        {
            HotDog_Cheese hotDog_Cheese = new HotDog_Cheese(); 
            hotDog_Cheese.ShowDialog();                        
        }

        private void btnSpicyDog_BAHD_Click(object sender, EventArgs e)
        {
            HotDog_Spicy hotDog_Spicy = new HotDog_Spicy(); 
            hotDog_Spicy.ShowDialog();                      
        }

        private void btnFishDog_BAHD_Click(object sender, EventArgs e)
        {
            HotDog_Fish hotDog_Fish = new HotDog_Fish(); 
            hotDog_Fish.ShowDialog();                    
        }


        private void btnSpicyDogTM_BAHD_Click(object sender, EventArgs e)
        {
            double qty_SHDTM, total_SHDTM;                              
            qty_SHDTM = Convert.ToDouble(nudSpicyDogTM_BAHD.Text);      
            total_SHDTM = qty_SHDTM * 175;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SPHD_TM','Spicy Dog','175','" + nudSpicyDogTM_BAHD.Text + "','" + total_SHDTM + "','Table To Meal')", con);
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

        private void btnSpicyDogTA_BAHD_Click(object sender, EventArgs e)
        {
            double qty_SHDTA, total_SHDTA;                              
            qty_SHDTA = Convert.ToDouble(nudSpicyDogTA_BAHD.Text);      
            total_SHDTA = qty_SHDTA * 175;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SPHD_TA','Spicy Dog','175','" + nudSpicyDogTA_BAHD.Text + "','" + total_SHDTA + "','Take Away')", con);
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

        private void btnFishDogTM_BAHD_Click(object sender, EventArgs e)
        {
            double qty_FDTM, total_FDTM;                              
            qty_FDTM = Convert.ToDouble(nudFishDogTM_BAHD.Text);      
            total_FDTM = qty_FDTM * 180;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('FIHD_TM','Fish Dog','180','" + nudFishDogTM_BAHD.Text + "','" + total_FDTM + "','Table To Meal')", con);
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

        private void btnFishDogTA_BAHD_Click(object sender, EventArgs e)
        {
            double qty_FDTA, total_FDTA;                              
            qty_FDTA = Convert.ToDouble(nudFishDogTA_BAHD.Text);      
            total_FDTA = qty_FDTA * 180;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('FIHD_TA','Fish Dog','180','" + nudFishDogTA_BAHD.Text + "','" + total_FDTA + "','Take Away')", con);
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

        private void btnCheeseDogTM_BAHD_Click(object sender, EventArgs e)
        {
            double qty_CDTM, total_CDTM;                              
            qty_CDTM = Convert.ToDouble(nudCheeseDogTM_BAHD.Text);      
            total_CDTM = qty_CDTM * 160;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CSHD_TM','Cheese Dog','160','" + nudCheeseDogTM_BAHD.Text + "','" + total_CDTM + "','Table To Meal')", con);
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

        private void btnCheeseDogTA_BAHD_Click(object sender, EventArgs e)
        {
            double qty_CDTA, total_CDTA;                              
            qty_CDTA = Convert.ToDouble(nudCheeseDogTA_BAHD.Text);      
            total_CDTA = qty_CDTA * 160;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('CSHD_TA','Cheese Dog','160','" + nudCheeseDogTM_BAHD.Text + "','" + total_CDTA + "','Take Away')", con);
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
