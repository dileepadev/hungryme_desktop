using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.TableToMeal_Forms
{
    public partial class AppatizersSoup : UserControl
    {
        public AppatizersSoup()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you, your Soup moves to 'My Cart' ");
        }
    }
}
