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

namespace ATM__SYSTEM
{
    public partial class Fast_Cash : Form
    {
        public Fast_Cash()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\ATM Management System.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        int bal;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balancelbl.Text = "Balance Ksh " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void Fast_Cash_Load(object sender, EventArgs e)
        {
            getbalance();
        }
     
        private void addtransaction1()
        {
            string TrType = "Withdraws";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + TrType + "'," + 100 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully");
                Con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        private void addtransaction2()
        {
            string TrType = "Withdraws";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + TrType + "'," + 500 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully");
                Con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        private void addtransaction3()
        {
            string TrType = "Withdraws";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + TrType + "'," + 1000 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully");
                Con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        private void addtransaction4()
        {
            string TrType = "Withdraws";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + TrType + "'," + 20000 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully");
                Con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        private void addtransaction5()
        {
            string TrType = "Withdraws";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + TrType + "'," + 50000 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully");
                Con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        private void addtransaction6()
        {
            string TrType = "Withdraws";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + TrType + "'," + 100000 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully");
                Con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (bal < 100)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 100;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction1();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 500;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction2();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 1000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction3();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bal < 20000)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 20000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction4();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bal < 50000)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 50000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction5();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bal < 100000)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 100000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction6();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
