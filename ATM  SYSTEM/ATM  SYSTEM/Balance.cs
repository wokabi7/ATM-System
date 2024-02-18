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

namespace ATM__SYSTEM
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\ATM Management System.mdf"";Integrated Security=True;Connect Timeout=30");
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + AccNumberlbl.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = "Ksh " +dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumberlbl.Text = HOME.AccNumber;
            getbalance();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
