namespace BusTicketBooking
{
    partial class BookTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenTb = new System.Windows.Forms.ComboBox();
            this.TicketNoTb = new System.Windows.Forms.TextBox();
            this.ConNum = new System.Windows.Forms.TextBox();
            this.PassNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DestiTb = new System.Windows.Forms.ComboBox();
            this.SLTb = new System.Windows.Forms.ComboBox();
            this.jNameTb = new System.Windows.Forms.ComboBox();
            this.TFPriceTb = new System.Windows.Forms.TextBox();
            this.ArrivTb = new System.Windows.Forms.TextBox();
            this.Dep = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BookTDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookTDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GenTb);
            this.groupBox1.Controls.Add(this.TicketNoTb);
            this.groupBox1.Controls.Add(this.ConNum);
            this.groupBox1.Controls.Add(this.PassNameTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(481, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passenger Details";
            // 
            // GenTb
            // 
            this.GenTb.FormattingEnabled = true;
            this.GenTb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenTb.Location = new System.Drawing.Point(167, 70);
            this.GenTb.Margin = new System.Windows.Forms.Padding(4);
            this.GenTb.Name = "GenTb";
            this.GenTb.Size = new System.Drawing.Size(275, 24);
            this.GenTb.TabIndex = 7;
            // 
            // TicketNoTb
            // 
            this.TicketNoTb.Location = new System.Drawing.Point(167, 151);
            this.TicketNoTb.Margin = new System.Windows.Forms.Padding(4);
            this.TicketNoTb.Name = "TicketNoTb";
            this.TicketNoTb.Size = new System.Drawing.Size(275, 22);
            this.TicketNoTb.TabIndex = 6;
            // 
            // ConNum
            // 
            this.ConNum.Location = new System.Drawing.Point(167, 108);
            this.ConNum.Margin = new System.Windows.Forms.Padding(4);
            this.ConNum.Name = "ConNum";
            this.ConNum.Size = new System.Drawing.Size(275, 22);
            this.ConNum.TabIndex = 5;
            // 
            // PassNameTb
            // 
            this.PassNameTb.Location = new System.Drawing.Point(167, 33);
            this.PassNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.PassNameTb.Name = "PassNameTb";
            this.PassNameTb.Size = new System.Drawing.Size(275, 22);
            this.PassNameTb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ticket No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passenger Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DestiTb);
            this.groupBox2.Controls.Add(this.SLTb);
            this.groupBox2.Controls.Add(this.jNameTb);
            this.groupBox2.Controls.Add(this.TFPriceTb);
            this.groupBox2.Controls.Add(this.ArrivTb);
            this.groupBox2.Controls.Add(this.Dep);
            this.groupBox2.Controls.Add(this.Date);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(16, 236);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(481, 336);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Details";
            // 
            // DestiTb
            // 
            this.DestiTb.FormattingEnabled = true;
            this.DestiTb.Items.AddRange(new object[] {
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chhattisgarh",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttar Pradesh",
            "Uttarakhand",
            "West Bengal"});
            this.DestiTb.Location = new System.Drawing.Point(167, 193);
            this.DestiTb.Margin = new System.Windows.Forms.Padding(4);
            this.DestiTb.Name = "DestiTb";
            this.DestiTb.Size = new System.Drawing.Size(160, 24);
            this.DestiTb.TabIndex = 15;
            // 
            // SLTb
            // 
            this.SLTb.FormattingEnabled = true;
            this.SLTb.Items.AddRange(new object[] {
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chhattisgarh",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttar Pradesh",
            "Uttarakhand",
            "West Bengal"});
            this.SLTb.Location = new System.Drawing.Point(167, 114);
            this.SLTb.Margin = new System.Windows.Forms.Padding(4);
            this.SLTb.Name = "SLTb";
            this.SLTb.Size = new System.Drawing.Size(160, 24);
            this.SLTb.TabIndex = 14;
            // 
            // jNameTb
            // 
            this.jNameTb.FormattingEnabled = true;
            this.jNameTb.Items.AddRange(new object[] {
            "Radh Express: Bombay to Delhi",
            "Metro Voyager: Bombay to Delhi Connection",
            "New Gujarat: Anand to Ahmdabad",
            "Skyline Cruiser: Bombay to Delhi Commute",
            "Capital Connect: Bombay to Delhi Route",
            "New Gujarat: Anand to Vadodra",
            "Bombay-Delhi Express: Radh Services",
            "New Gujarat:  Ahmdabad to surat",
            "Heritage Highway: Radh Bombay to Delhi",
            "Sunset Serenade: Radh Bus Adventure",
            "City Lights Express: Radh Journey to Delhi",
            "Majestic Mover: Radh Bombay to Delhi",
            "Radiant Roadtrip: Bombay to Delhi Expedition"});
            this.jNameTb.Location = new System.Drawing.Point(167, 73);
            this.jNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.jNameTb.Name = "jNameTb";
            this.jNameTb.Size = new System.Drawing.Size(289, 24);
            this.jNameTb.TabIndex = 13;
            // 
            // TFPriceTb
            // 
            this.TFPriceTb.Location = new System.Drawing.Point(167, 279);
            this.TFPriceTb.Margin = new System.Windows.Forms.Padding(4);
            this.TFPriceTb.Name = "TFPriceTb";
            this.TFPriceTb.Size = new System.Drawing.Size(160, 22);
            this.TFPriceTb.TabIndex = 12;
            // 
            // ArrivTb
            // 
            this.ArrivTb.Location = new System.Drawing.Point(167, 238);
            this.ArrivTb.Margin = new System.Windows.Forms.Padding(4);
            this.ArrivTb.Name = "ArrivTb";
            this.ArrivTb.Size = new System.Drawing.Size(160, 22);
            this.ArrivTb.TabIndex = 11;
            // 
            // Dep
            // 
            this.Dep.Location = new System.Drawing.Point(167, 158);
            this.Dep.Margin = new System.Windows.Forms.Padding(4);
            this.Dep.Name = "Dep";
            this.Dep.Size = new System.Drawing.Size(160, 22);
            this.Dep.TabIndex = 10;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(167, 23);
            this.Date.Margin = new System.Windows.Forms.Padding(4);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(228, 22);
            this.Date.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 279);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Ticket Fair Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 241);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Arrival Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Destination";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Departure";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Source Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Journey Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Journey Date";
            // 
            // BookTDGV
            // 
            this.BookTDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookTDGV.Location = new System.Drawing.Point(509, 11);
            this.BookTDGV.Margin = new System.Windows.Forms.Padding(4);
            this.BookTDGV.Name = "BookTDGV";
            this.BookTDGV.Size = new System.Drawing.Size(904, 366);
            this.BookTDGV.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Book Ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(809, 452);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Print Ticket";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(981, 452);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 607);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BookTDGV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookTicket";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookTDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GenTb;
        private System.Windows.Forms.TextBox TicketNoTb;
        private System.Windows.Forms.TextBox ConNum;
        private System.Windows.Forms.TextBox PassNameTb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DestiTb;
        private System.Windows.Forms.ComboBox SLTb;
        private System.Windows.Forms.ComboBox jNameTb;
        private System.Windows.Forms.TextBox TFPriceTb;
        private System.Windows.Forms.TextBox ArrivTb;
        private System.Windows.Forms.TextBox Dep;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.DataGridView BookTDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}