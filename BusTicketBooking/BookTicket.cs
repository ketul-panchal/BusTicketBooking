using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Configuration;
//using ConfigurationSettings = System.Configuration.ConfigurationManager;

namespace BusTicketBooking
{
    public partial class BookTicket : Form
    {
         private PrintDocument printDocument = new PrintDocument();
        public BookTicket()
        {
            InitializeComponent();
            showBookTicket();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }
        //SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Ketul\OneDrive\Documents\BusTicketTbl.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");


        SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString);
        private void showBookTicket()
        {
            Con.Open();
            string Query = "Select * from BookTicketTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookTDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassNameTb.Text == "" || GenTb.SelectedIndex == -1 || ConNum.Text == "" || jNameTb.SelectedIndex == -1 || SLTb.Text == "" || Dep.Text == "" || DestiTb.SelectedIndex == -1 || ArrivTb.Text == "" || TFPriceTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BookTicketTbl(passengername,gender,contactno,ticketno,jouryneyDate,journyName,sourceLocation,Departure,Destination,ArivalTime,TicketFairPrice) values(@PN,@PG,@PNO,@TNO,@JD,@JN,@SL,@DEP,@DES,@AT,@TFN)", Con);
                    cmd.Parameters.AddWithValue("@PN", PassNameTb.Text);
                    cmd.Parameters.AddWithValue("@PG", GenTb.Text);
                    cmd.Parameters.AddWithValue("@PNO", ConNum.Text);
                    cmd.Parameters.AddWithValue("@TNO", TicketNoTb.Text);
                    cmd.Parameters.AddWithValue("@JD", Date.Value.Date);
                    cmd.Parameters.AddWithValue("@JN", jNameTb.Text);
                    cmd.Parameters.AddWithValue("@SL", SLTb.Text);
                    cmd.Parameters.AddWithValue("@DEP", Dep.Text);
                    cmd.Parameters.AddWithValue("@DES", DestiTb.Text);
                    cmd.Parameters.AddWithValue("@AT", ArrivTb.Text);
                    cmd.Parameters.AddWithValue("@TFN", TicketNoTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Book successfully");
                    Con.Close();
                    showBookTicket();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PassNameTb.Text = "";
            GenTb.Text = "" ;
            ConNum.Text = "" ;
            jNameTb.Text = "" ;
            TicketNoTb.Text = "";
            SLTb.Text = "" ;
            Dep.Text = "" ;
            DestiTb.Text = "" ;
            ArrivTb.Text = "";
            TFPriceTb.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
         private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Get input values
            string passengerName = PassNameTb.Text;
            string gender = GenTb.Text;
            string contactNumber = ConNum.Text;
            string ticketNumber = TicketNoTb.Text;
            DateTime journeyDate = Date.Value;
            string journeyName = jNameTb.Text;
            string sourceLocation = SLTb.Text;
            string departure = Dep.Text;
            string destination = DestiTb.Text;
            string arrivalTime = ArrivTb.Text;
            string ticketPrice = TFPriceTb.Text;

            // Create a printable string
            string printDetails = "Passenger Name: '"+PassNameTb.Text+"'\n" +
                                  "Gender: '" + GenTb.Text + "'\n" +
                                  "Contact Number: '" + ConNum.Text + "'\n" +
                                  "Ticket Number: '" + TicketNoTb.Text + "'\n" +
                                  "Journey Date: '" + Date.Value + "'\n" +
                                  "Journey Name: '" + jNameTb.Text + "'\n" +
                                  "Source Location: '" + SLTb.Text + "'\n" +
                                  "Departure: '" + Dep.Text + "'\n" +
                                  "Destination: '" + DestiTb.Text + "'\n" +
                                  "Arrival Time: '" + ArrivTb.Text + "'\n" +
                                  "Ticket Fare Price: '" + TFPriceTb.Text + "'";

            // Set font and brush for printing
            Font printFont = new Font("Arial", 10);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Set the print area
            RectangleF printArea = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);

            // Print the ticket details
            e.Graphics.DrawString(printDetails, printFont, brush, printArea);
        }
    }
}
