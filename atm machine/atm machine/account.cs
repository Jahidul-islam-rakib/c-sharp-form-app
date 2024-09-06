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
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jirak\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            int bal = 0;

            if(AccountNumTb.Text =="" ||  AccountNameTb.Text=="" || FatherNameTb.Text=="" || AddressTb.Text=="" || PhoneNoTb.Text=="" || PinTb.Text=="" ||  EducationTb.Text =="" || OccupationTb.Text==""   )
            {
                MessageBox.Show("Missing Information.Please fill up the required field.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Insert into RegisterTb values('" +AccountNumTb.Text+"','"+AccountNameTb.Text+"','"+FatherNameTb.Text+"','"+AddressTb.Text+"' , '"+PhoneNoTb.Text+"', '"+DOBTb.Value.Date+"','"+EducationTb.SelectedItem.ToString()+"', '"+OccupationTb.Text+"', '"+PinTb.Text+"' , '"+bal+"' )";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    con.Close();

                    login log = new login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void PinTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccountNumTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccountNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void FatherNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void DOBTb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void account_Load(object sender, EventArgs e)
        {

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
