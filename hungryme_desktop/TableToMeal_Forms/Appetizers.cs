using RestaurantApp.Home_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.TableToMeal_Forms
{
    public partial class Appetizers : Form
    {
        public Appetizers()
        {
            InitializeComponent();
            button1.Height = button1.Height; //Soups front when start
            button1.Top = button1.Top;       //Soups front when start
            appatizersSoup1.BringToFront();  //Soups front when start

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Height = button2.Height;  //Salads front when button2 press
            button2.Top = button2.Top;        //Salads front when button2 press
            appatizersSalads1.BringToFront(); //Salads front when button2 press
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Height = button1.Height; //Soups front when button1 press
            button1.Top = button1.Top;       //Soups front when button1 press
            appatizersSoup1.BringToFront();  //Soups front when button1 press
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart(); //Open MyCart
            myCart.ShowDialog();
        }
    }
}
