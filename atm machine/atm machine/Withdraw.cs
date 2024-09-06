using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm_machine
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jirak\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = login.AccNumber;
        int bal;
        int NewBalance;


        private void getBalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from RegisterTb where AccNumber =   '" + Acc + "'  ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balanceLbl.Text = "Balance : " + dt.Rows[0][0].ToString() + " tk ";
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }

        private void AddTransaction()
        {
            string TrType = "Withdraw";
            try
            {
                con.Open();
                //              string onlydate = "SELECT date('now') date ";

                string query = "Insert into TransactionTbl values('" + Acc + "','" + TrType + "','" + WdAmtTb.Text + "','" + DateTime.Today.Date.ToString() + "'  )";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WdAmtTb.Text == "")
            {
                MessageBox.Show("Enter an amount");
            }
            else if (Convert.ToInt32(WdAmtTb.Text) <= 0)
            {
                MessageBox.Show("Enter a valid Amount");
            }
            else if (Convert.ToInt32(WdAmtTb.Text) > bal)
            {
                MessageBox.Show("withdraw balance is higher than available balance");
            }
            else
            {
                NewBalance = bal - Convert.ToInt32(WdAmtTb.Text);
                try
                {
                    con.Open();
                    string query = "update RegisterTb set Balance =" + NewBalance + "where AccNumber =" + Acc + " ; ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    // MessageBox.Show("deposit successful");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successful Withdraw.");

                    con.Close();
                    AddTransaction();

                    home Home = new home();
                    Home.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error :" + ex.Message);
                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            home Home = new home();
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
    }
}
