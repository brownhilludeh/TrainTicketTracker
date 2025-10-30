using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainTicketTracker.BusinessObjects;
using TrainTicketTracker.PresentationLayers;

namespace TrainTicketTracker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //variable
        private bool unsavedChanges = false;

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtPassengerName.Focus();
            //Populating the combo box
            foreach (string tickeType in TrainTicket.ticketTypes)
            {
                cmbTicketType.Items.Add(tickeType);
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmView fview = new frmView();
            fview.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEdit fedit = new frmEdit();
            fedit.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        //Custom Method / Framework - Validation, Clear and may be calculate ticket Price. 
        private bool Validator()
        {
            //checking for pricce

            if (string.IsNullOrWhiteSpace(txtPassengerName.Text) ||
                string.IsNullOrWhiteSpace(txtDestination.Text) ||
                string.IsNullOrWhiteSpace(txtOrigin.Text) ||
                string.IsNullOrWhiteSpace(txtDeparture.Text) ||
               cmbTicketType.SelectedIndex == -1)
            {

                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(!double.TryParse(txtTicketPrice.Text, out double ticketPrice))
            {
                MessageBox.Show("Ticket Price must be a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }

        //clear input fields
        public void ClearInput()
        {
            txtPassengerName.Clear();
            txtDestination.Clear();
            txtOrigin.Clear();
            txtDeparture.Clear();
            txtTicketPrice.Clear();
            cmbTicketType.SelectedIndex = -1;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unsavedChanges)
            {
                DialogResult result = MessageBox.Show("You have unsaved changes. Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) {
                    e.Cancel = true;
                }
            }
        }

       

        private void btnStore_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
                //CLean, Trim and convert to upper case
                string PassengerName = txtPassengerName.Text.Trim().ToUpper();
                string Destination = txtDestination.Text.Trim().ToUpper();
                string TicketType = cmbTicketType.SelectedItem.ToString();
                string Origin = txtOrigin.Text.Trim().ToUpper();
                string Departure = txtDeparture.Text.Trim().ToUpper();
                double ticketPrice = double.Parse(txtTicketPrice.Text.Trim());
                TrainTicket ticket = new TrainTicket(PassengerName, TicketType,  Origin, Destination, Departure, ticketPrice);
                TrainTicket.tickets.Add(ticket);
                MessageBox.Show("Ticket has been stored successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
                txtPassengerName.Focus();
            }
        }
    }
}
