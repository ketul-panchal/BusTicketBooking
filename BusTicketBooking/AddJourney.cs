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
    public partial class AddJourney : Form
    {
        public AddJourney()
        {
            InitializeComponent();
            showJourney();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Ketul\OneDrive\Documents\BusTicketTbl.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        private void showJourney()
        {
            Con.Open();
            string Query = "Select * from JourneyTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            JDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (JnameTb.Text == "" || SLTb.SelectedIndex == -1 || DeptTb.Text == "" || DestiTb.SelectedIndex == -1 || ArrivTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into JourneyTbl(jName,sourceLocation,departure,destination,arivalTime) values(@JN,@SL,@DEP,@DES,@AT)", Con);
                    cmd.Parameters.AddWithValue("@JN", JnameTb.Text);
                    cmd.Parameters.AddWithValue("@SL", SLTb.Text);
                    cmd.Parameters.AddWithValue("@DEP", DeptTb.Text);
                    cmd.Parameters.AddWithValue("@DES", DestiTb.Text);
                    cmd.Parameters.AddWithValue("@AT", ArrivTB.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Journey Register successfully");
                    Con.Close();
                    showJourney();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
