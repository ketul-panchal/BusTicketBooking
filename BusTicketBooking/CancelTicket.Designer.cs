﻿namespace BusTicketBooking
{
    partial class CancelTicket
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
            this.TIBTB = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.TicketDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Ticket By ID";
            // 
            // TIBTB
            // 
            this.TIBTB.Location = new System.Drawing.Point(283, 25);
            this.TIBTB.Margin = new System.Windows.Forms.Padding(4);
            this.TIBTB.Name = "TIBTB";
            this.TIBTB.Size = new System.Drawing.Size(265, 22);
            this.TIBTB.TabIndex = 2;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(577, 25);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(129, 28);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "Cancel Ticket";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // TicketDGV
            // 
            this.TicketDGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.TicketDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketDGV.Location = new System.Drawing.Point(16, 75);
            this.TicketDGV.Margin = new System.Windows.Forms.Padding(4);
            this.TicketDGV.Name = "TicketDGV";
            this.TicketDGV.Size = new System.Drawing.Size(1124, 321);
            this.TicketDGV.TabIndex = 4;
            // 
            // CancelTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 428);
            this.Controls.Add(this.TicketDGV);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.TIBTB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CancelTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelTicket";
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TIBTB;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.DataGridView TicketDGV;
    }
}