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
    public partial class AppatizersSalads : UserControl
    {
        public AppatizersSalads()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost; database=hungryme; username=root; password=");


        private void btnVegetableSalad_A_Click(object sender, EventArgs e)
        {
            Salad_Vegetable salad_Vegetable = new Salad_Vegetable(); 
            salad_Vegetable.ShowDialog();                            
        }

        private void btnSpecialSalad_A_Click(object sender, EventArgs e)
        {
            Salad_Special salad_Special = new Salad_Special(); 
            salad_Special.ShowDialog();                        
        }


        private void btnVegetableSaladTM_A_Click(object sender, EventArgs e)
        {
            double qty_VSTM, total_VSTM;                              
            qty_VSTM = Convert.ToDouble(nudVegetableSaladTM_A.Text);      
            total_VSTM = qty_VSTM * 120;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('VESA_TM','Vegetable Salad','120','" + nudVegetableSaladTM_A.Text + "','" + total_VSTM + "','Table To Meal')", con);
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

        private void btnVegetableSaladTA_A_Click(object sender, EventArgs e)
        {
            double qty_VSTA, total_VSTA;                              
            qty_VSTA = Convert.ToDouble(nudVegetableSaladTA_A.Text);      
            total_VSTA = qty_VSTA * 120;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('VESA_TA','Vegetable Salad','120','" + nudVegetableSaladTM_A.Text + "','" + total_VSTA + "','Take Away')", con);
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

        private void btnSpecialSaladTM_A_Click(object sender, EventArgs e)
        {
            double qty_SSTM, total_SSTM;                              
            qty_SSTM = Convert.ToDouble(nudSpecialSaladTM_A.Text);      
            total_SSTM = qty_SSTM * 130;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SPSA_TM','Special Salad','130','" + nudSpecialSaladTM_A.Text + "','" + total_SSTM + "','Table To Meal')", con);
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

        private void btnSpecialSaladTA_A_Click(object sender, EventArgs e)
        {
            double qty_SSTA, total_SSTA;                              
            qty_SSTA = Convert.ToDouble(nudSpecialSaladTA_A.Text);      
            total_SSTA = qty_SSTA * 130;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('SPSA_TA','Special Salad','130','" + nudSpecialSaladTM_A.Text + "','" + total_SSTA + "','Take Away')", con);
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
