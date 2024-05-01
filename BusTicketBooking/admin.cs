using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BusTicketBooking
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }


        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterBus obj = new RegisterBus();
            obj.Show();
           // this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusReport br = new BusReport();
            br.Show();
           // this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookTicket bt = new BookTicket();
            bt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CancelTicket ct = new CancelTicket();
            ct.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManagePassenger mp = new ManagePassenger();
            mp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResgisterPassenger rp = new ResgisterPassenger();
            rp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddJourney aj = new AddJourney();
            aj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ViewJourney bta = new ViewJourney();
            bta.Show();
        }
    }
}
