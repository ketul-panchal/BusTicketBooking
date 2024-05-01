namespace BusTicketBooking
{
    partial class AddJourney
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.JDGV = new System.Windows.Forms.DataGridView();
            this.JnameTb = new System.Windows.Forms.ComboBox();
            this.SLTb = new System.Windows.Forms.ComboBox();
            this.DestiTb = new System.Windows.Forms.ComboBox();
            this.DeptTb = new System.Windows.Forms.TextBox();
            this.ArrivTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.JDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Journey Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Arrival Time";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 288);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Journey";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // JDGV
            // 
            this.JDGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.JDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JDGV.Location = new System.Drawing.Point(379, 46);
            this.JDGV.Margin = new System.Windows.Forms.Padding(4);
            this.JDGV.Name = "JDGV";
            this.JDGV.Size = new System.Drawing.Size(756, 244);
            this.JDGV.TabIndex = 6;
            // 
            // JnameTb
            // 
            this.JnameTb.FormattingEnabled = true;
            this.JnameTb.Items.AddRange(new object[] {
            "Radh Express: Bombay to Delhi",
            "New Gujarat: Anand to Ahmdabad",
            "Skyline Cruiser: Bombay to Delhi Commute",
            "Capital Connect: Bombay to Delhi Route",
            "New Gujarat: Anand to Vadodra",
            "Bombay-Delhi Express: GSRT Services",
            "New Gujarat:  Ahmdabad to surat",
            "Heritage Highway: Radh Bombay to Delhi",
            "Sunset Serenade: Radh Bus Adventure",
            "City Lights Express: Radh Journey to Delhi",
            "Majestic Mover: Radh Bombay to Delhi",
            "Radiant Roadtrip: Bombay to Delhi Expedition"});
            this.JnameTb.Location = new System.Drawing.Point(151, 53);
            this.JnameTb.Margin = new System.Windows.Forms.Padding(4);
            this.JnameTb.Name = "JnameTb";
            this.JnameTb.Size = new System.Drawing.Size(216, 24);
            this.JnameTb.TabIndex = 14;
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
            "Delhi ",
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
            "Mumbai",
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
            this.SLTb.Location = new System.Drawing.Point(153, 100);
            this.SLTb.Margin = new System.Windows.Forms.Padding(4);
            this.SLTb.Name = "SLTb";
            this.SLTb.Size = new System.Drawing.Size(216, 24);
            this.SLTb.TabIndex = 15;
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
            "Delhi ",
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
            "Mumbai",
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
            this.DestiTb.Location = new System.Drawing.Point(151, 185);
            this.DestiTb.Margin = new System.Windows.Forms.Padding(4);
            this.DestiTb.Name = "DestiTb";
            this.DestiTb.Size = new System.Drawing.Size(216, 24);
            this.DestiTb.TabIndex = 16;
            // 
            // DeptTb
            // 
            this.DeptTb.Location = new System.Drawing.Point(153, 146);
            this.DeptTb.Margin = new System.Windows.Forms.Padding(4);
            this.DeptTb.Name = "DeptTb";
            this.DeptTb.Size = new System.Drawing.Size(132, 22);
            this.DeptTb.TabIndex = 17;
            // 
            // ArrivTB
            // 
            this.ArrivTB.Location = new System.Drawing.Point(153, 226);
            this.ArrivTB.Margin = new System.Windows.Forms.Padding(4);
            this.ArrivTB.Name = "ArrivTB";
            this.ArrivTB.Size = new System.Drawing.Size(132, 22);
            this.ArrivTB.TabIndex = 18;
            // 
            // AddJourney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 362);
            this.Controls.Add(this.ArrivTB);
            this.Controls.Add(this.DeptTb);
            this.Controls.Add(this.DestiTb);
            this.Controls.Add(this.SLTb);
            this.Controls.Add(this.JnameTb);
            this.Controls.Add(this.JDGV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddJourney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddJourney";
            ((System.ComponentModel.ISupportInitialize)(this.JDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView JDGV;
        private System.Windows.Forms.ComboBox JnameTb;
        private System.Windows.Forms.ComboBox SLTb;
        private System.Windows.Forms.ComboBox DestiTb;
        private System.Windows.Forms.TextBox DeptTb;
        private System.Windows.Forms.TextBox ArrivTB;
    }
}