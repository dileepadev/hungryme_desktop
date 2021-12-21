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
    public partial class HungryMe : Form
    {
        public HungryMe()
        {
            InitializeComponent();
            timerHM.Start(); //HungryMe DateTime
        }

        private void timerHM_Tick(object sender, EventArgs e)
        {
            lblDTHM.Text=DateTime.Now.ToString("dddd, dd-MMM-yyyy, HH:mm:ss"); //HungryMe DateTime
        }
    }
}
