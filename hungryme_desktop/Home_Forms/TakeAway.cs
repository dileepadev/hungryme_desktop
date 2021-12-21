using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp
{
    public partial class TakeAway : Form
    {
        public TakeAway()
        {
            InitializeComponent();
            timerDTTA.Start(); //TakeAway DateTime
        }

        private void timerDTTA_Tick(object sender, EventArgs e)
        {
            lblDTTA.Text=DateTime.Now.ToString("dddd, dd-MMM-yyyy, HH:mm:ss"); //TakeAway DateTime
        }

        private void btnAppetizers_Click(object sender, EventArgs e)
        {

        }
    }
}
