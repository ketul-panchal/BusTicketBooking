namespace BusTicketBooking
{
    partial class BusReport
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
            this.IDTB = new System.Windows.Forms.TextBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.BusRDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BusRDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Bus by Their ID";
            // 
            // IDTB
            // 
            this.IDTB.Location = new System.Drawing.Point(300, 23);
            this.IDTB.Margin = new System.Windows.Forms.Padding(4);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(249, 22);
            this.IDTB.TabIndex = 1;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(595, 23);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(4);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(100, 28);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // BusRDGV
            // 
            this.BusRDGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.BusRDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusRDGV.Location = new System.Drawing.Point(55, 79);
            this.BusRDGV.Margin = new System.Windows.Forms.Padding(4);
            this.BusRDGV.Name = "BusRDGV";
            this.BusRDGV.Size = new System.Drawing.Size(1089, 278);
            this.BusRDGV.TabIndex = 3;
            // 
            // BusReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 431);
            this.Controls.Add(this.BusRDGV);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.IDTB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BusReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusReport";
            ((System.ComponentModel.ISupportInitialize)(this.BusRDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DataGridView BusRDGV;
    }
}