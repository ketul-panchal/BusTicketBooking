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
    public partial class ManagePassenger : Form
    {
        public ManagePassenger()
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
            PDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (PIDTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from RegisterPassengerTbl where passengerID=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", PIDTB.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted");
                    Con.Close();
                    showPassengers();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
