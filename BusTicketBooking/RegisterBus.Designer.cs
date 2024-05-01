namespace BusTicketBooking
{
    partial class RegisterBus
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
            this.label6 = new System.Windows.Forms.Label();
            this.BusNameTb = new System.Windows.Forms.TextBox();
            this.BusCNum = new System.Windows.Forms.TextBox();
            this.BusNoTb = new System.Windows.Forms.TextBox();
            this.busTypeCb = new System.Windows.Forms.ComboBox();
            this.FType = new System.Windows.Forms.ComboBox();
            this.NoOfSeats = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RBDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RBDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bus Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bus Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(84, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bus Chassis No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(84, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bus No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(84, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fuel Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(84, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "No of Seats";
            // 
            // BusNameTb
            // 
            this.BusNameTb.Location = new System.Drawing.Point(248, 105);
            this.BusNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.BusNameTb.Name = "BusNameTb";
            this.BusNameTb.Size = new System.Drawing.Size(165, 22);
            this.BusNameTb.TabIndex = 6;
            // 
            // BusCNum
            // 
            this.BusCNum.Location = new System.Drawing.Point(248, 151);
            this.BusCNum.Margin = new System.Windows.Forms.Padding(4);
            this.BusCNum.Name = "BusCNum";
            this.BusCNum.Size = new System.Drawing.Size(165, 22);
            this.BusCNum.TabIndex = 7;
            // 
            // BusNoTb
            // 
            this.BusNoTb.Location = new System.Drawing.Point(248, 198);
            this.BusNoTb.Margin = new System.Windows.Forms.Padding(4);
            this.BusNoTb.Name = "BusNoTb";
            this.BusNoTb.Size = new System.Drawing.Size(165, 22);
            this.BusNoTb.TabIndex = 8;
            // 
            // busTypeCb
            // 
            this.busTypeCb.FormattingEnabled = true;
            this.busTypeCb.Items.AddRange(new object[] {
            "Sleeper Coach",
            "Non-Sleeper",
            "Non Stop Bus",
            "Minicoach",
            "Double-decker bus",
            "Single-decker bus"});
            this.busTypeCb.Location = new System.Drawing.Point(248, 64);
            this.busTypeCb.Margin = new System.Windows.Forms.Padding(4);
            this.busTypeCb.Name = "busTypeCb";
            this.busTypeCb.Size = new System.Drawing.Size(165, 24);
            this.busTypeCb.TabIndex = 9;
            // 
            // FType
            // 
            this.FType.FormattingEnabled = true;
            this.FType.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Electric"});
            this.FType.Location = new System.Drawing.Point(248, 245);
            this.FType.Margin = new System.Windows.Forms.Padding(4);
            this.FType.Name = "FType";
            this.FType.Size = new System.Drawing.Size(165, 24);
            this.FType.TabIndex = 10;
            // 
            // NoOfSeats
            // 
            this.NoOfSeats.Location = new System.Drawing.Point(248, 295);
            this.NoOfSeats.Margin = new System.Windows.Forms.Padding(4);
            this.NoOfSeats.Name = "NoOfSeats";
            this.NoOfSeats.Size = new System.Drawing.Size(165, 22);
            this.NoOfSeats.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(767, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Resgister Bus";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RBDGV
            // 
            this.RBDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RBDGV.Location = new System.Drawing.Point(497, 50);
            this.RBDGV.Margin = new System.Windows.Forms.Padding(4);
            this.RBDGV.Name = "RBDGV";
            this.RBDGV.Size = new System.Drawing.Size(793, 266);
            this.RBDGV.TabIndex = 13;
            // 
            // RegisterBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 470);
            this.Controls.Add(this.RBDGV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NoOfSeats);
            this.Controls.Add(this.FType);
            this.Controls.Add(this.busTypeCb);
            this.Controls.Add(this.BusNoTb);
            this.Controls.Add(this.BusCNum);
            this.Controls.Add(this.BusNameTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterBus";
            ((System.ComponentModel.ISupportInitialize)(this.RBDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BusNameTb;
        private System.Windows.Forms.TextBox BusCNum;
        private System.Windows.Forms.TextBox BusNoTb;
        private System.Windows.Forms.ComboBox busTypeCb;
        private System.Windows.Forms.ComboBox FType;
        private System.Windows.Forms.TextBox NoOfSeats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView RBDGV;
    }
}