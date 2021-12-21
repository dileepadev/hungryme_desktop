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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using hungryme_desktop.MyCart_Forms;

namespace hungryme_desktop.Home_Forms
{
    public partial class MyCart : Form
    {
        public MyCart()
        {
            InitializeComponent();
            timerDTMC.Start();
        }

        
        MySqlConnection con = new MySqlConnection("server=localhost; database=hungryme; username=root; password=");

        private void timerDTMC_Tick(object sender, EventArgs e)
        {
            lblDTMC.Text=DateTime.Now.ToString("dddd, dd-MMM-yyyy, HH:mm:ss"); 
        }

        private void btnHome_MC_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnView_MC_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM mycart", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                int i;
                lblTotalBill.Text = "0";

                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    lblTotalBill.Text = Convert.ToString(int.Parse(lblTotalBill.Text) + int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("error = " + ex.Message);
            }
        }

        private void btnDelete_MC_Click(object sender, EventArgs e)
        {
            try
            {
                string selected_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand("DELETE FROM mycart WHERE ID = '" + selected_id + "' ", con);
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }

            catch (Exception ex)
            {
                SelectToDelete selectToDelete = new SelectToDelete();
                selectToDelete.Show();
                MessageBox.Show(ex.Message);
            }

            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM mycart", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            try
            {
                int i;
                lblTotalBill.Text = "0";

                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    lblTotalBill.Text = Convert.ToString(int.Parse(lblTotalBill.Text) + int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("error = " + ex.Message);
            }
        }

        private void btnAdd_MC_Click(object sender, EventArgs e)
        {
            Meals meals = new Meals();
            meals.Show();
            this.Hide();
        }

    }
}
