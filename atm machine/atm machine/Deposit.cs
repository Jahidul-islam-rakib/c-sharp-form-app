using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm_machine
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jirak\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");




       public string Acc = login.AccNumber;


        private void AddTransaction()
        {
            string TrType = "Deposit";
            try
            {
                con.Open();
  //              string onlydate = "SELECT date('now') date ";

                string query = "Insert into TransactionTbl values('" + Acc + "','" + TrType + "','" + DepoAmtTb.Text + "','" + DateTime.Today.Date.ToString() + "'  )";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (DepoAmtTb.Text == "" || Convert.ToInt32(DepoAmtTb.Text) <= 0)
            {
                MessageBox.Show("Enter valid amount to deposit");
            }
            else
            {
                NewBalance = OldBalance + Convert.ToInt32(DepoAmtTb.Text);
                try
                {
                    con.Open();
                    string query = "update RegisterTb set Balance =" + NewBalance + "where AccNumber =" + Acc +" ; ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    // MessageBox.Show("deposit successful");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted successfully!");

                    con.Close();
                    AddTransaction();

                    home Home = new home();
                    Home.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error :"+ ex.Message);
                }

                //finally
                //{
                //    con.Close();
                //}
            }
        }


        int OldBalance,NewBalance;
        private void getBalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from RegisterTb where AccNumber =   '" + Acc + "'  ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OldBalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            home Home = new home();
            Home.Show();
            this.Hide();
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

        private void label6_MouseHover_1(object sender, EventArgs e)
        {
            label6.BackColor = Color.Red;

        }

        private void label6_MouseLeave_1(object sender, EventArgs e)
        {
            label6.BackColor = Color.Transparent;

        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            getBalance();
        }
    }
}
