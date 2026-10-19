
using System;
using System.Drawing;
using System.Windows.Forms;

namespace home_assignments
{
    public partial class Vehicle_Rental_System : Form
    {
        public Vehicle_Rental_System()
        {
            InitializeComponent();
            ApplyProfessionalStyle();

            // Connect button events
            btnCalculate.Click += btnCalculate_Click;
            btnClear.Click += btnClear_Click;
            btnExit.Click += btnExit_Click;

            // Fill vehicle choices
            cmbVehicleType.Items.Clear();
            cmbVehicleType.Items.Add("Economy");
            cmbVehicleType.Items.Add("SUV");
            cmbVehicleType.Items.Add("Luxury");
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ApplyProfessionalStyle()
        {
            // Form design
            this.Text = "Vehicle Rental Management System";
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(900, 650);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Title
            lblTitle.Text = "VEHICLE RENTAL SYSTEM";
            lblTitle.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitle.BackColor = Color.FromArgb(25, 45, 80);
            lblTitle.ForeColor = Color.White;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Height = 75;

            // Input controls
            txtCustomerName.Font = new Font("Segoe UI", 11);
            txtCustomerAge.Font = new Font("Segoe UI", 11);
            txtRentalDays.Font = new Font("Segoe UI", 11);
            txtExperience.Font = new Font("Segoe UI", 11);
            cmbVehicleType.Font = new Font("Segoe UI", 11);

            chkInsurance.Text = "Add Insurance ($15 per day)";
            chkInsurance.Font = new Font("Segoe UI", 10);

            // Buttons
            StyleButton(btnCalculate, Color.RoyalBlue, Color.White);
            StyleButton(btnClear, Color.AliceBlue, Color.FromArgb(25, 45, 80));
            StyleButton(btnExit, Color.IndianRed, Color.White);

            btnCalculate.Text = "CALCULATE";
            btnClear.Text = "CLEAR";
            btnExit.Text = "EXIT";

            // Results
            lblResult.Text = "";
            lblResult.Font = new Font("Segoe UI", 11);
            lblResult.BackColor = Color.White;
            lblResult.ForeColor = Color.FromArgb(35, 45, 60);
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.AutoSize = false;
            lblResult.Padding = new Padding(12);
        }

        private void StyleButton(Button button, Color backColor,
            Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Cursor = Cursors.Hand;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Check customer name
            string customerName = txtCustomerName.Text.Trim();

            if (customerName == "")
            {
                MessageBox.Show("Please enter the customer name.",
                    "Missing Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return;
            }

            // Validate age
            int age;
            if (!int.TryParse(txtCustomerAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid customer age.");
                txtCustomerAge.Focus();
                return;
            }

            if (age < 18 || age > 80)
            {
                MessageBox.Show("Customer age must be between 18 and 80.");
                return;
            }

            // Validate rental days
            int rentalDays;
            if (!int.TryParse(txtRentalDays.Text, out rentalDays))
            {
                MessageBox.Show("Please enter a valid number of rental days.");
                txtRentalDays.Focus();
                return;
            }

            if (rentalDays < 1 || rentalDays > 30)
            {
                MessageBox.Show("Rental days must be between 1 and 30.");
                return;
            }

            // Validate driving experience
            int experience;
            if (!int.TryParse(txtExperience.Text, out experience))
            {
                MessageBox.Show("Please enter valid driving experience.");
                txtExperience.Focus();
                return;
            }

            if (experience < 0)
            {
                MessageBox.Show("Driving experience cannot be negative.");
                return;
            }

            // Check vehicle selection
            if (cmbVehicleType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle type.");
                cmbVehicleType.Focus();
                return;
            }

            // General eligibility rules
            if (age < 21)
            {
                MessageBox.Show(
                    "Sorry, customers below 21 years are not eligible to rent.",
                    "Rental Not Allowed", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lblResult.Text = "RENTAL NOT APPROVED";
                return;
            }

            if (experience < 1)
            {
                MessageBox.Show(
                    "At least 1 year of driving experience is required.",
                    "Rental Not Allowed", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lblResult.Text = "RENTAL NOT APPROVED";
                return;
            }

            string vehicleType = cmbVehicleType.SelectedItem.ToString();
            decimal dailyRate = 0m;

            // Set daily vehicle rate
            if (vehicleType == "Economy")
            {
                dailyRate = 35m;
            }
            else if (vehicleType == "SUV")
            {
                dailyRate = 60m;
            }
            else if (vehicleType == "Luxury")
            {
                dailyRate = 100m;

                if (age < 25 || experience < 3)
                {
                    MessageBox.Show(
                        "Luxury vehicles require age 25 or above " +
                        "and at least 3 years of driving experience.",
                        "Luxury Vehicle Requirement",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    lblResult.Text = "RENTAL NOT APPROVED";
                    return;
                }
            }

            // Calculate rental cost
            decimal basicCost = dailyRate * rentalDays;
            decimal discountRate = 0m;

            if (rentalDays >= 14)
            {
                discountRate = 0.10m;
            }
            else if (rentalDays >= 7)
            {
                discountRate = 0.05m;
            }

            decimal discount = basicCost * discountRate;
            decimal costAfterDiscount = basicCost - discount;

            // Young-driver surcharge for ages 21–24
            decimal surcharge = 0m;

            if (age >= 21 && age <= 24)
            {
                surcharge = costAfterDiscount * 0.10m;
            }

            // Insurance is charged per rental day
            decimal insuranceCost = 0m;

            if (chkInsurance.Checked)
            {
                insuranceCost = 15m * rentalDays;
            }

            decimal finalCost =
                costAfterDiscount + surcharge + insuranceCost;

            // Display results
            // Display results in a separate window
            string summary =
                "VEHICLE RENTAL SUMMARY\n\n" +
                "Customer Name: " + customerName + "\n" +
                "Customer Age: " + age + "\n" +
                "Driving Experience: " + experience + " year(s)\n" +
                "Vehicle Type: " + vehicleType + "\n" +
                "Rental Days: " + rentalDays + "\n\n" +
                "Daily Rate: $" + dailyRate.ToString("0.00") + "\n" +
                "Basic Rental Cost: $" + basicCost.ToString("0.00") + "\n" +
                "Discount: -$" + discount.ToString("0.00") + "\n" +
                "Young-Driver Surcharge: $" + surcharge.ToString("0.00") + "\n" +
                "Insurance Cost: $" + insuranceCost.ToString("0.00") + "\n\n" +
                "FINAL RENTAL COST: $" + finalCost.ToString("0.00");

            lblResult.Text = summary;
            lblResult.Visible = true;

            MessageBox.Show(
                summary,
                "Vehicle Rental Calculation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtCustomerAge.Clear();
            txtRentalDays.Clear();
            txtExperience.Clear();

            cmbVehicleType.SelectedIndex = -1;
            chkInsurance.Checked = false;
            lblResult.Text = "";

            txtCustomerName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Vehicle_Rental_System_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }
    }
}
