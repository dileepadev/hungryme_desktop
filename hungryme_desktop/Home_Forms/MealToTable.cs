﻿using System;
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
    public partial class MealToTable : Form
    {
        public MealToTable()
        {
            InitializeComponent();
            timerDTMTT.Start(); //MealToTable DateTime
        }

        private void timerDTMTT_Tick(object sender, EventArgs e)
        {
            lblDTMTT.Text=DateTime.Now.ToString("dddd, dd-MMM-yyyy, HH:mm:ss"); //MealToTable DateTime
        }
    }
}
