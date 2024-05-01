namespace BusTicketBooking
{
    partial class ViewJourney
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
            this.JDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.JDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // JDGV
            // 
            this.JDGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.JDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JDGV.Location = new System.Drawing.Point(16, 27);
            this.JDGV.Margin = new System.Windows.Forms.Padding(4);
            this.JDGV.Name = "JDGV";
            this.JDGV.Size = new System.Drawing.Size(1052, 256);
            this.JDGV.TabIndex = 0;
            // 
            // ViewJourney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 321);
            this.Controls.Add(this.JDGV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewJourney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewJourney";
            ((System.ComponentModel.ISupportInitialize)(this.JDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView JDGV;
    }
}