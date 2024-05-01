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
    public partial class RegisterBus : Form
    {
        public RegisterBus()
        {
            InitializeComponent();
            showRegisterBus();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Ketul\OneDrive\Documents\BusTicketTbl.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        private void showRegisterBus()
        {
            Con.Open();
            string Query = "Select * from RegisterBusTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            RBDGV.DataSource = ds.Tables[0];
            Con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (busTypeCb.SelectedIndex == -1 || BusNameTb.Text == "" || BusCNum.Text == "" || BusNoTb.Text == "" || FType.SelectedIndex == -1 || NoOfSeats.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into RegisterBusTbl(BusType,BusName,BusChasisNo,BusNo,FuelType,Noofseats) values(@BT,@BN,@BCN,@BNO,@FT,@NOS)", Con);
                    cmd.Parameters.AddWithValue("@BT", busTypeCb.Text);
                    cmd.Parameters.AddWithValue("@BN", BusNameTb.Text);
                    cmd.Parameters.AddWithValue("@BCN", BusCNum.Text);
                    cmd.Parameters.AddWithValue("@BNO", BusNoTb.Text);
                    cmd.Parameters.AddWithValue("@FT", FType.Text);
                    cmd.Parameters.AddWithValue("@NOS", NoOfSeats.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bus Register successfully");
                    Con.Close();
                    showRegisterBus();
                   
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
