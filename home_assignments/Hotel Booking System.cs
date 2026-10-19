using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_assignments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtGuestName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
        


private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. Validate the guest name
            string guestName = txtGuestName.Text.Trim();

            if (guestName == "")
            {
                MessageBox.Show("Please enter the guest name.");
                txtGuestName.Focus();
                return;
            }

            // 2. Validate numeric inputs using TryParse
            int age, nights, guests;

            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                txtAge.Focus();
                return;
            }

            if (!int.TryParse(txtNights.Text, out nights))
            {
                MessageBox.Show("Please enter a valid number of nights.");
                lbl4.Focus();
                return;
            }

            if (!int.TryParse(txtGuests.Text, out guests))
            {
                MessageBox.Show("Please enter a valid number of guests.");
                lbl5.Focus();
                return;
            }

            // 3. Check the allowed ranges
            if (age < 18 || age > 90)
            {
                MessageBox.Show("Guest age must be between 18 and 90.");
                return;
            }

            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Nights must be between 1 and 30.");
                return;
            }

            if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Guests must be between 1 and 6.");
                return;
            }

            if (cmbRoomType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            string roomType = cmbRoomType.Text;

            // 4. Check room capacity
            int capacity = 0;

            switch (roomType)
            {
                case "Standard":
                    capacity = 2;
                    break;

                case "Normal":
                    capacity = 4;
                    break;

                case "Hight":
                    capacity = 6;
                    break;
            }

            bool bookingApproved = true;

            if (guests > capacity)
            {
                bookingApproved = false;
                MessageBox.Show("Booking rejected: too many guests for this room.");
            }

            if (!bookingApproved)
            {
                lblResult.Text = "Booking Rejected";
                return;
            }

            // 5. Determine the room rate using switch
            decimal rate = 0;

            switch (roomType)
            {
                case "Standard":
                    rate = 50m;
                    break;

                case "Normal":
                    rate = 80m;
                    break;

                case "Hight":
                    rate = 130m;
                    break;

                default:
                    MessageBox.Show("Invalid room type.");
                    return;
            }

            // 6. Calculate the basic room cost
            decimal basicCost = rate * nights;

            // 7. Calculate the length-of-stay discount
            decimal stayDiscountRate = 0m;

            if (nights >= 10)
            {
                stayDiscountRate = 0.12m;
            }
            else if (nights >= 5)
            {
                stayDiscountRate = 0.05m;
            }

            decimal stayDiscount = basicCost * stayDiscountRate;
            decimal costAfterStayDiscount = basicCost - stayDiscount;

            // 8. Calculate the senior discount
            decimal seniorDiscount = 0m;

            if (age >= 60)
            {
                seniorDiscount = costAfterStayDiscount * 0.05m;
            }

            decimal roomCost = costAfterStayDiscount - seniorDiscount;

            // 9. Add breakfast, if selected
            decimal breakfastCost = 0m;

            if (chkBreakfast.Checked)
            {
                breakfastCost = 10m * guests * nights;
            }

            decimal subtotal = roomCost + breakfastCost;

            // 10. Add the service surcharge for more than 4 guests
            decimal serviceCharge = 0m;

            if (guests > 4)
            {
                serviceCharge = subtotal * 0.05m;
            }

            decimal finalCost = subtotal + serviceCharge;

            // 11. Display the results
            lblResult.Text =
                "Booking Approved\n" +
                "Guest: " + guestName + "\n" +
                "Room Type: " + roomType + "\n" +
                "Basic Cost: " + basicCost.ToString("C2") + "\n" +
                "Stay Discount: " + stayDiscount.ToString("C2") + "\n" +
                "Senior Discount: " + seniorDiscount.ToString("C2") + "\n" +
                "Breakfast: " + breakfastCost.ToString("C2") + "\n" +
                "Service Charge: " + serviceCharge.ToString("C2") + "\n" +
                "Final Cost: " + finalCost.ToString("C2");
        }

       

        private void txtNights_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuestName.Clear();
            txtAge.Clear();
            txtNights.Clear();
            txtGuests.Clear();

            cmbRoomType.SelectedIndex = -1;
            chkBreakfast.Checked = false;

            lblResult.Text = "";

            txtGuestName.Focus();
        }
    }
}

