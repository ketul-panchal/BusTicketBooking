using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BusTicketBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Ketul\OneDrive\Documents\BusTicketTbl.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        private void loginbtn_Click(object sender, EventArgs e)
        {
            /*if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Both Admin Name And Password");
            }
            else if (UnameTb.Text == "Admin" && PasswordTb.Text == "Password")
            {
                admin Obj = new admin();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Admin name and password!!");
                UnameTb.Text = "";
                PasswordTb.Text = "";
            } */
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from userTbl where username='" + UnameTb.Text + "'and password='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    admin Obj = new admin();
                    Obj.Show();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong officer name or password");
                    UnameTb.Text = "";
                    PasswordTb.Text = "";
                }
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
