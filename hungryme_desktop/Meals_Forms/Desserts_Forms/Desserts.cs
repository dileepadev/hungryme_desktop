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
using hungryme_desktop.Meals_Forms.Desserts_Forms;
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
    public partial class Desserts : Form
    {
        public Desserts()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost; database=hungryme; username=root; password=");

        private void btnHome_D_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.ShowDialog();      
        }

        private void btnMyCart_D_Click(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart(); 
            myCart.ShowDialog();          
        }

        private void btnMeals_D_Click(object sender, EventArgs e)
        {
            Meals meals = new Meals(); 
            meals.ShowDialog();        
        }

        private void btnFruitSalad_D_Click(object sender, EventArgs e)
        {
            FruitSalad fruitSalad = new FruitSalad(); 
            fruitSalad.ShowDialog();                  
        }

        private void btnIceCream_D_Click(object sender, EventArgs e)
        {
            IceCream iceCream = new IceCream(); 
            iceCream.ShowDialog();              
        }

        private void btnMouse_D_Click(object sender, EventArgs e)
        {
            Mouse mouse = new Mouse(); 
            mouse.ShowDialog();        
        }

        private void btnPudding_D_Click(object sender, EventArgs e)
        {
            Pudding pudding = new Pudding();  
            pudding.ShowDialog();             
        }


        private void btnIceCreamTM_D_Click(object sender, EventArgs e)
        {
            double qty_ICTM, total_ICTM;                              
            qty_ICTM = Convert.ToDouble(nudIceCreamTM_D.Text);      
            total_ICTM = qty_ICTM * 120;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('ICDE_TM','Ice Cream','120','" + nudIceCreamTM_D.Text + "','" + total_ICTM + "','Table To Meal')", con);
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

        private void btnIceCreamTA_D_Click(object sender, EventArgs e)
        {
            double qty_ICTA, total_ICTA;                              
            qty_ICTA = Convert.ToDouble(nudIceCreamTA_D.Text);      
            total_ICTA = qty_ICTA * 120;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('ICDE_TA','Ice Cream','120','" + nudIceCreamTA_D.Text + "','" + total_ICTA + "','Take Away')", con);
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


        private void btnMouseTM_D_Click(object sender, EventArgs e)
        {
            double qty_MTM, total_MTM;                              
            qty_MTM = Convert.ToDouble(nudMouseTM_D.Text);      
            total_MTM = qty_MTM * 160;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('MODE_TM','Mousse','160','" + nudMouseTM_D.Text + "','" + total_MTM + "','Table To Meal')", con);
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

        private void btnMouseTA_D_Click(object sender, EventArgs e)
        {
            double qty_MTA, total_MTA;                              
            qty_MTA = Convert.ToDouble(nudMouseTA_D.Text);      
            total_MTA = qty_MTA * 160;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('MODE_TA','Mousse','160','" + nudMouseTA_D.Text + "','" + total_MTA + "','Take Away')", con);
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


        private void btnPuddingTM_D_Click(object sender, EventArgs e)
        {
            double qty_PTM, total_PTM;                              
            qty_PTM = Convert.ToDouble(nudPuddingTM_D.Text);      
            total_PTM = qty_PTM * 120;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('PUDE_TM','Pudding','120','" + nudPuddingTM_D.Text + "','" + total_PTM + "','Table To Meal')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show("You already added Pudding to My Cart for Table To Meal" + ex.Message);
            }
        }

        private void btnPuddingTA_D_Click(object sender, EventArgs e)
        {
            double qty_PTA, total_PTA;                              
            qty_PTA = Convert.ToDouble(nudPuddingTA_D.Text);      
            total_PTA = qty_PTA * 120;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('PUDE_TA','Pudding','120','" + nudPuddingTM_D.Text + "','" + total_PTA + "','Take Away')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                AddToCart addToCart = new AddToCart();
                addToCart.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show("You already added Pudding to My Cart for Take Away" + ex.Message);
            }
        }


        private void btnFruitSaladTM_D_Click(object sender, EventArgs e)
        {
            double qty_FSTM, total_FSTM;                              
            qty_FSTM = Convert.ToDouble(nudFruitSaladTM_D.Text);      
            total_FSTM = qty_FSTM * 100;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('FSDE_TM','Fruit Salad','100','" + nudFruitSaladTM_D.Text + "','" + total_FSTM + "','Table To Meal')", con);
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

        private void btnFruitSaladTA_D_Click(object sender, EventArgs e)
        {
            double qty_FSTA, total_FSTA;                              
            qty_FSTA = Convert.ToDouble(nudFruitSaladTA_D.Text);      
            total_FSTA = qty_FSTA * 100;                               

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mycart(ID,Meal,Price,Quantity,Total,Status)VALUES('FSDE_TA','Fruit Salad','100','" + nudFruitSaladTA_D.Text + "','" + total_FSTA + "','Take Away')", con);
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

        private void btnMeals_D_Click_1(object sender, EventArgs e)
        {
            Meals meals = new Meals();
            meals.Show();
            this.Hide();
        }

        private void btnHome_D_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnMyCart_D_Click_1(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart();
            myCart.Show();
            this.Hide();
        }
    }
}
