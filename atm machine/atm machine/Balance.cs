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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jirak\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void getBalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from RegisterTb where AccNumber =   '"+AccNumberLbl.Text+"'  ",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BalanceLbl.Text =  dt.Rows[0][0].ToString() + " tk ";
            con.Close();
        }
        private void AccNumberLbl_Click(object sender, EventArgs e)
        {

        }

        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumberLbl.Text = home.AccNumber;
            getBalance();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            home Home = new home();
            this.Hide();
            Home.Show();
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
