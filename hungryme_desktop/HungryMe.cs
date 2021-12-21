using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp
{
    public partial class HungryMe : Form
    {
        public HungryMe()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();
            InitializeComponent();
        }
        private void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
