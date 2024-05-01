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
    public partial class CancelTicket : Form
    {
        public CancelTicket()
        {
            InitializeComponent();
            showBookTicket();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Ketul\OneDrive\Documents\BusTicketTbl.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        private void showBookTicket()
        {
            Con.Open();
            string Query = "Select * from BookTicketTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TicketDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            if (TIBTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from BookTicketTbl where ticketID=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", TIBTB.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Deleted");
                    Con.Close();
                    showBookTicket();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
