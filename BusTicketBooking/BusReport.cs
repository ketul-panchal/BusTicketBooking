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
    public partial class BusReport : Form
    {
        public BusReport()
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
            BusRDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (IDTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from RegisterBusTbl where BusId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", IDTB.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Register Bus Deleted");
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
