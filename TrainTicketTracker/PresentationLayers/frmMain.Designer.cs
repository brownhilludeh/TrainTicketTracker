namespace TrainTicketTracker
{
    partial class frmMain
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
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.lblTicketType = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblTicketPrice = new System.Windows.Forms.Label();
            this.btnStore = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.cmbTicketType = new System.Windows.Forms.ComboBox();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Location = new System.Drawing.Point(69, 66);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(91, 13);
            this.lblPassengerName.TabIndex = 0;
            this.lblPassengerName.Text = "Passenger Name:";
            // 
            // lblTicketType
            // 
            this.lblTicketType.AutoSize = true;
            this.lblTicketType.Location = new System.Drawing.Point(69, 93);
            this.lblTicketType.Name = "lblTicketType";
            this.lblTicketType.Size = new System.Drawing.Size(67, 13);
            this.lblTicketType.TabIndex = 1;
            this.lblTicketType.Text = "Ticket Type:";
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(69, 124);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(40, 13);
            this.lblOrigin.TabIndex = 2;
            this.lblOrigin.Text = "Origin: ";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(69, 150);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(60, 13);
            this.lblDeparture.TabIndex = 3;
            this.lblDeparture.Text = "Departure: ";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(69, 176);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(63, 13);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination:";
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.AutoSize = true;
            this.lblTicketPrice.Location = new System.Drawing.Point(69, 202);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(67, 13);
            this.lblTicketPrice.TabIndex = 5;
            this.lblTicketPrice.Text = "Ticket Price:";
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(190, 260);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(75, 23);
            this.btnStore.TabIndex = 6;
            this.btnStore.Text = "Save Ticket";
            this.btnStore.UseVisualStyleBackColor = true;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(190, 164);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(184, 20);
            this.txtDestination.TabIndex = 7;
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(190, 138);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(184, 20);
            this.txtDeparture.TabIndex = 8;
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(190, 59);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(184, 20);
            this.txtPassengerName.TabIndex = 9;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(190, 112);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(184, 20);
            this.txtOrigin.TabIndex = 10;
            // 
            // cmbTicketType
            // 
            this.cmbTicketType.FormattingEnabled = true;
            this.cmbTicketType.Location = new System.Drawing.Point(190, 85);
            this.cmbTicketType.Name = "cmbTicketType";
            this.cmbTicketType.Size = new System.Drawing.Size(184, 21);
            this.cmbTicketType.TabIndex = 11;
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Location = new System.Drawing.Point(190, 190);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(184, 20);
            this.txtTicketPrice.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTicketPrice);
            this.Controls.Add(this.cmbTicketType);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.lblTicketPrice);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.lblTicketType);
            this.Controls.Add(this.lblPassengerName);
            this.Name = "frmMain";
            this.Text = "Train Ticket Tracket :: Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.Label lblTicketType;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblTicketPrice;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.ComboBox cmbTicketType;
        private System.Windows.Forms.TextBox txtTicketPrice;
    }
}

