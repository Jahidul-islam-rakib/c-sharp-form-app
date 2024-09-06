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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jirak\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = login.AccNumber;
        int bal,NewBalance;
        int amt;
        private void getBalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from RegisterTb where AccNumber =   '" + Acc + "'  ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            FastCash1.Text  = "Balance : "+ dt.Rows[0][0].ToString() + " tk ";
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }

        private void AddTransaction(int amount)
        {
            string TrType = "Withdraw";
            try
            {
                con.Open();
                //              string onlydate = "SELECT date('now') date ";

                string query = "Insert into TransactionTbl values('" + Acc + "','" + TrType + "','" + amount + "','" + DateTime.Today.Date.ToString() + "'  )";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FastCash_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.BackColor = Color.Red;

        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.Transparent;

        }


        private void label5_Click(object sender, EventArgs e)
        {
            home Home = new home();
            Home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("balance can not be negative.");
            }
            else
            {
                NewBalance = bal - 1000;
                try
                {
                    con.Open();
                    string query = "update RegisterTb set Balance =" + NewBalance + "where AccNumber =" + Acc + " ; ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    // MessageBox.Show("deposit successful");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successful Withdraw.");

                    con.Close();
                    AddTransaction(1000);

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

        private void button5_Click(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("balance can not be negative.");
            }
            else
            {
                NewBalance = bal - 2000;
                try
                {
                    con.Open();
                    string query = "update RegisterTb set Balance =" + NewBalance + "where AccNumber =" + Acc + " ; ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    // MessageBox.Show("deposit successful");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successful Withdraw.");

                    con.Close();
                    AddTransaction(2000);


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

        private void button2_Click(object sender, EventArgs e)
        {
            if (bal < 3000)
            {
                MessageBox.Show("balance can not be negative.");
            }
            else
            {
                NewBalance = bal - 3000;
                try
                {
                    con.Open();
                    string query = "update RegisterTb set Balance =" + NewBalance + "where AccNumber =" + Acc + " ; ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    // MessageBox.Show("deposit successful");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successful Withdraw.");

                    con.Close();
                    AddTransaction(3000);


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

        private void button3_Click(object sender, EventArgs e)
        {
            if (bal < 4000)
            {
                MessageBox.Show("balance can not be negative.");
            }
            else
            {
                NewBalance = bal - 4000;
                try
                {
                    con.Open();
                    string query = "update RegisterTb set Balance =" + NewBalance + "where AccNumber =" + Acc + " ; ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    // MessageBox.Show("deposit successful");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successful Withdraw.");

                    con.Close();
                    AddTransaction(4000);


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

        private void button4_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("balance can not be negative.");
            }
            else
            {
                NewBalance = bal - 5000;
                try
                {
                    con.Open();
                    string query = "update RegisterTb set Balance =" + NewBalance + "where AccNumber =" + Acc + " ; ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    // MessageBox.Show("deposit successful");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successful Withdraw.");

                    con.Close();
                    AddTransaction(5000);


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

        private void label6_MouseHover_1(object sender, EventArgs e)
        {
            label6.BackColor = Color.Red;

        }

        private void label6_MouseLeave_1(object sender, EventArgs e)
        {
            label6.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bal<500)
            {
                MessageBox.Show("balance can not be negative.");
            }
            else
            {
                NewBalance = bal - 500;
                try
                {
                    con.Open();
                    string query = "update RegisterTb set Balance =" + NewBalance + "where AccNumber =" + Acc + " ; ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    // MessageBox.Show("deposit successful");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successful Withdraw.");

                    con.Close();
                    AddTransaction(500);


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
    }
}
