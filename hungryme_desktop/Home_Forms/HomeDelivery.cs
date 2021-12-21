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
    public partial class HomeDelivery : Form
    {
        public HomeDelivery()
        {
            InitializeComponent();
            timerDTHD.Start(); //HomeDelivery DateTime
        }

        private void timerDTHD_Tick(object sender, EventArgs e)
        {
            lblDTHD.Text=DateTime.Now.ToString("dddd, dd-MMM-yyyy, HH:mm:ss"); //HomeDelivery DateTime
        }
    }
}
