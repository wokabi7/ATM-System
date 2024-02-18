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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\ATM Management System.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        int bal;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" +Acc+ "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balancelbl.Text = "Balance Ksh " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void addtransaction()
        {
            string TrType = "Withdraws";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + TrType + "'," + withdrawTbl.Text + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void Withdraw_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        int newbalance;
        private void button1_Click(object sender, EventArgs e)
        {
            if (withdrawTbl.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (Convert.ToInt32(withdrawTbl.Text) <= 0)
            {
                MessageBox.Show("Enter a Valid Amount");
            }
            else if(Convert.ToInt32(withdrawTbl.Text) > bal)
            {
                MessageBox.Show("Balance Can not be Negative");
            }
            else
            {
                try
                {
                     newbalance = bal - Convert.ToInt32(withdrawTbl.Text);
                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + " where Accnum='" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Success Withdraw");
                        Con.Close();
                        addtransaction();
                        HOME home = new HOME();
                        home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOME home = new HOME();
            home.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
