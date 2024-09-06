using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm_machine
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }


        private void label5_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            bal.Show();
            this.Hide();
        }

        public static String AccNumber;

        private void home_Load(object sender, EventArgs e)
        {
            AccountNoLbl.Text = "Account Number : " + login.AccNumber;
            AccNumber = login.AccNumber;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }


        private void AccountNoLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePin Pin = new ChangePin();
            Pin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FastCash FCash = new FastCash();
            FCash.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MiniStatement mini = new MiniStatement();
            mini.Show(); 
            this.Hide();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor= Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;

        }

        private void label2_MouseHover_1(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;

        }

        private void label2_MouseLeave_1(object sender, EventArgs e)
        {
            label6.BackColor = Color.Transparent;

        }
    }
}
