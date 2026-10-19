
using System;
using System.Drawing;
using System.Windows.Forms;

namespace home_assignments
{
    public partial class Airline_Ticket_Booking_System : Form
    {
        public Airline_Ticket_Booking_System()
        {
            InitializeComponent();
            ApplyProfessionalStyle();
        }

        private void ApplyProfessionalStyle()
        {
            // Form appearance
            this.Text = "Airline Ticket Booking System";
            this.BackColor = Color.FromArgb(244, 247, 252);
            this.Font = new Font("Segoe UI", 10F);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(900, 650);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Style existing controls
            foreach (Control control in this.Controls)
            {
                if (control is Label label)
                {
                    label.Font = new Font("Segoe UI", 10F);
                    label.ForeColor = Color.FromArgb(35, 55, 85);
                }

                if (control is TextBox textBox)
                {
                    textBox.Font = new Font("Segoe UI", 11F);
                    textBox.BackColor = Color.White;
                    textBox.ForeColor = Color.FromArgb(31, 45, 61);
                }

                if (control is ComboBox comboBox)
                {
                    comboBox.Font = new Font("Segoe UI", 11F);
                    comboBox.BackColor = Color.White;
                    comboBox.ForeColor = Color.FromArgb(31, 45, 61);
                    comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                if (control is CheckBox checkBox)
                {
                    checkBox.Font = new Font("Segoe UI", 10F);
                    checkBox.ForeColor = Color.FromArgb(31, 55, 85);
                }

                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    button.Cursor = Cursors.Hand;
                    button.Size = new Size(115, 40);
                }
            }

            // Title label
            Control title = this.Controls["lblTitle"];

            if (title is Label titleLabel)
            {
                titleLabel.BackColor = Color.FromArgb(24, 45, 85);
                titleLabel.ForeColor = Color.White;
                titleLabel.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.Location = new Point(15, 15);
                titleLabel.Size = new Size(850, 75);
            }

            // Calculate button
            if (this.Controls["btnCalculate"] is Button calculateButton)
            {
                calculateButton.BackColor = Color.FromArgb(37, 99, 235);
                calculateButton.ForeColor = Color.White;
            }

            // Clear button
            if (this.Controls["btnClear"] is Button clearButton)
            {
                clearButton.BackColor = Color.FromArgb(225, 235, 249);
                clearButton.ForeColor = Color.FromArgb(24, 45, 85);
            }

            // Exit button
            if (this.Controls["btnExit"] is Button exitButton)
            {
                exitButton.BackColor = Color.FromArgb(195, 55, 70);
                exitButton.ForeColor = Color.White;
            }

            // Results label
            if (this.Controls["lblResult"] is Label resultLabel)
            {
                resultLabel.AutoSize = false;
                resultLabel.BackColor = Color.White;
                resultLabel.ForeColor = Color.FromArgb(24, 45, 85);
                resultLabel.BorderStyle = BorderStyle.FixedSingle;
                resultLabel.Font = new Font("Segoe UI", 10F);
                resultLabel.Size = new Size(820, 120);
                resultLabel.Padding = new Padding(12);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validate passenger name
            string passengerName = txtPassengerName.Text.Trim();

            if (passengerName == "")
            {
                MessageBox.Show("Please enter the passenger name.");
                txtPassengerName.Focus();
                return;
            }

            // Validate numeric inputs
            int age, tickets;
            decimal baggage;

            if (!int.TryParse(txtPassengerAge.Text, out age))
            {
                MessageBox.Show("Enter a valid passenger age.");
                txtPassengerAge.Focus();
                return;
            }

            if (!int.TryParse(txtTickets.Text, out tickets))
            {
                MessageBox.Show("Enter a valid number of tickets.");
                txtTickets.Focus();
                return;
            }

            if (!decimal.TryParse(txtBaggage.Text, out baggage))
            {
                MessageBox.Show("Enter a valid baggage weight.");
                txtBaggage.Focus();
                return;
            }

            // Validate ranges
            if (age < 1 || age > 100)
            {
                MessageBox.Show("Age must be between 1 and 100.");
                return;
            }

            if (tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Tickets must be between 1 and 5.");
                return;
            }

            if (baggage < 0 || baggage > 50)
            {
                MessageBox.Show("Baggage must be between 0 and 50 kg per passenger.");
                return;
            }

            if (cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a ticket class.");
                return;
            }

            string ticketClass = cmbClass.Text;

            // Booking approval
            bool bookingApproved = true;
            string rejectionReason = "";

            if (age < 12 && ticketClass == "First Class")
            {
                bookingApproved = false;
                rejectionReason =
                    "Passengers below 12 cannot book First Class.";
            }

            if (!bookingApproved)
            {
                MessageBox.Show("Booking Rejected: " + rejectionReason);
                lblResult.Text = "Booking Rejected";
                return;
            }

            // Example ticket rates; replace with rates given by your lecturer.
            decimal ticketPrice = 100m;

            switch (ticketClass)
            {
                case "Economy":
                    ticketPrice = 100m;
                    break;

                case "Business":
                    ticketPrice = 200m;
                    break;

                case "First Class":
                    ticketPrice = 350m;
                    break;

                default:
                    MessageBox.Show("Invalid ticket class.");
                    return;
            }

            // Basic ticket cost
            decimal basicCost = ticketPrice * tickets;
            decimal total = basicCost;

            // Multiple-ticket discount
            decimal ticketDiscountRate = 0m;

            if (tickets == 5)
            {
                ticketDiscountRate = 0.10m;
            }
            else if (tickets >= 3)
            {
                ticketDiscountRate = 0.05m;
            }

            decimal ticketDiscount = total * ticketDiscountRate;
            total -= ticketDiscount;

            // Child or senior discount
            decimal ageDiscountRate = 0m;

            if (age < 12)
            {
                ageDiscountRate = 0.20m;
            }
            else if (age >= 60)
            {
                ageDiscountRate = 0.10m;
            }

            decimal ageDiscount = total * ageDiscountRate;
            total -= ageDiscount;

            // Travel insurance
            decimal insuranceCost = 0m;

            if (chkInsurance.Checked)
            {
                insuranceCost = 25m * tickets;
                total += insuranceCost;
            }

            // Baggage up to 20 kg is free.
            // The assignment does not specify the fee above 20 kg.
            string baggageMessage = baggage <= 20
                ? "Baggage: Free"
                : "Baggage: Over 20 kg; check excess baggage fee.";

            lblResult.Text =
                "BOOKING APPROVED\n" +
                "Passenger: " + passengerName + "\n" +
                "Ticket Class: " + ticketClass + "\n" +
                "Basic Ticket Cost: " + basicCost.ToString("C2") + "\n" +
                "Ticket Discount: " + ticketDiscount.ToString("C2") + "\n" +
                "Age Discount: " + ageDiscount.ToString("C2") + "\n" +
                "Insurance: " + insuranceCost.ToString("C2") + "\n" +
                baggageMessage + "\n" +
                "Final Total: " + total.ToString("C2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassengerName.Clear();
            txtPassengerAge.Clear();
            txtTickets.Clear();
            txtBaggage.Clear();

            cmbClass.SelectedIndex = -1;
            chkInsurance.Checked = false;

            lblResult.Text = "";

            txtPassengerName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Airline_Ticket_Booking_System_Load(
            object sender, EventArgs e)
        {
        }

        private void txtGuestName_TextChanged(
            object sender, EventArgs e)
        {
        }
    }
}
