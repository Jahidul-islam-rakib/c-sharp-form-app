using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace atm_machine
{
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jirak\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        public string Acc = login.AccNumber;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ChangePin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pin1Tb.Text == "" || Pin2Tb.Text == "")
            {
                MessageBox.Show("Enter and confirm new pin.");
            }

            else if (Pin1Tb.Text != Pin2Tb.Text)
            {
                MessageBox.Show("new Pin and confirm Pin are different.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update RegisterTb set PIN =" + Pin2Tb.Text + "where AccNumber =" + Acc + " ; ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("new pin has been changed successfully!");

                    con.Close();

                    login Home = new login();
                    Home.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error :" + ex.Message);
                }

                //finally
                //{
                //    con.Close();
                //}
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.BackColor = Color.Red;

        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.Transparent;

        }

        private void label6_MouseHover_1(object sender, EventArgs e)
        {
            label6.BackColor = Color.Red;

        }

        private void label6_MouseLeave_1(object sender, EventArgs e)
        {
            label6.BackColor = Color.Transparent;

        }
    }
}
