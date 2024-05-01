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
    public partial class ViewJourney : Form
    {
        public ViewJourney()
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
    }

}
