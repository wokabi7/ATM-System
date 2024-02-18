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
    public partial class Change_Pin : Form
    {
        public Change_Pin()
        {
            InitializeComponent();
        }

        public object Con { get; private set; }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\ATM Management System.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Pin1Tb.Text == "" || Pin2Tb.Text == "")
            {
                MessageBox.Show("Enter And Confirm The New Pin");
            }
            else if(Pin2Tb.Text != Pin1Tb.Text)
            {
                MessageBox.Show("Pin1 And Pin2 are Different");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update AccountTbl set PIN=" + Pin1Tb.Text + " where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin Successuly Updated");
                    con.Close();
                    Login home = new Login();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
    }
}
