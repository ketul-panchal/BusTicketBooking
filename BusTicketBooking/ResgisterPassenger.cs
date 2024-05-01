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
    public partial class ResgisterPassenger : Form
    {
        public ResgisterPassenger()
        {
            InitializeComponent();
            showPassengers();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Ketul\OneDrive\Documents\BusTicketTbl.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        private void showPassengers()
        {
            Con.Open();
            string Query = "Select * from RegisterPassengerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            RPDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassNameTb.Text == "" || GenCb.SelectedIndex == -1 || AgeTb.Text == "" || EmailTb.Text == "" || CnumTb.Text == "" || NationalityCB.SelectedIndex == -1 || stateCb.SelectedIndex == -1 || CityTb.Text == "" || PinCodeTb.Text == "" || EnameTb.Text == "" || ECNum.Text == "" || ReletionTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into RegisterPassengerTbl(passengerName,gender,age,emailID,Cnum,nationality,state,cityname,pincode,ename,econtactNum,relation) values(@PN,@PG,@PA,@PEID,@PNUM,@PNAT,@PS,@PC,@PPIN,@ENM,@ENUM,@EREL)", Con);
                    cmd.Parameters.AddWithValue("@PN", PassNameTb.Text);
                    cmd.Parameters.AddWithValue("@PG", GenCb.Text);
                    cmd.Parameters.AddWithValue("@PA", AgeTb.Text);
                    cmd.Parameters.AddWithValue("@PEID", EmailTb.Text);
                    cmd.Parameters.AddWithValue("@PNUM", CnumTb.Text);
                    cmd.Parameters.AddWithValue("@PNAT", NationalityCB.Text);
                    cmd.Parameters.AddWithValue("@PS", stateCb.Text);
                    cmd.Parameters.AddWithValue("@PC", CityTb.Text);
                    cmd.Parameters.AddWithValue("@PPIN", PinCodeTb.Text);
                    cmd.Parameters.AddWithValue("@ENM", EnameTb.Text);
                    cmd.Parameters.AddWithValue("@ENUM", ECNum.Text);
                    cmd.Parameters.AddWithValue("@EREL", ReletionTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Register successfully");
                    Con.Close();
                    showPassengers();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PassNameTb.Text = "";
            GenCb.Text = "";
            AgeTb.Text = "" ;
            EmailTb.Text = "";
            CnumTb.Text = "";
            NationalityCB.Text = "";
            stateCb.Text = "";
            CityTb.Text = "";
            PinCodeTb.Text = "";
            EnameTb.Text = "" ;
            ECNum.Text = "";
            ReletionTb.Text = "";
        }
    }
}
