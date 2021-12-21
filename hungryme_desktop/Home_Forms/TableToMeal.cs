using RestaurantApp.TableToMeal_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.Home_Forms
{
    public partial class TableToMeal : Form
    {
        public TableToMeal()
        {
            InitializeComponent();
            timerDTTTM.Start(); //MealToTable DateTime
        }

        private void timerDTTTM_Tick(object sender, EventArgs e)
        {
            lblDTMTT.Text=DateTime.Now.ToString("dddd, dd-MMM-yyyy, HH:mm:ss"); //MealToTable DateTime
        }

        private void btnAppetizersTTM_Click(object sender, EventArgs e)
        {
            Appetizers appetizers = new Appetizers();
            appetizers.ShowDialog();
        }
    }
}
