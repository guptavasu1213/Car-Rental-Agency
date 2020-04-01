using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
            dateOfBirthPicker.MinDate = new DateTime(1900, 1, 1);
            dateOfBirthPicker.MaxDate = new DateTime(2002, 1, 1);
            dateOfBirthPicker.Value = new DateTime(1990, 1, 1);
        }
        /*
         * Allowing only numerical values for the field
         */
        private void allowOnlyNumericalValues(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*
         * When the Submit button is clicked and all entries are filled by the user, then entries are added
         * to the database
         */
        private void submitButton_Click(object sender, EventArgs e)
        {
            Customer cx = new Customer();
            cx.FirstName = firstNameTextBox.Text.TrimEnd();
            cx.LastName = lastNameTextBox.Text.TrimEnd();
            cx.PhoneNumber = Decimal.Parse(phoneNumberTextBox.Text.TrimEnd());
            cx.BDay = dateOfBirthPicker.Value.ToShortDateString();
            cx.Insurance  = insuranceIDTexBox.Text.TrimEnd();
            cx.Drivers = driverLicenseNumberTextBox.Text.TrimEnd();
            cx.EmailAddress = emailBox.Text.Trim();
            cx.Address = addressBox.Text.Trim();
            cx.City = cityBox.Text.Trim();
            cx.Province = provinceBox.Text.Trim();
            cx.Country = countryBox.Text.Trim();
            cx.Status = "Basic";
            cx.SelfServer = false;

            // Check to ensure all the fields have text
            if (cx.FirstName == "" || cx.LastName == "" || cx.PhoneNumber < 1000000000 || cx.Insurance == "" ||
                cx.Drivers == "" || cx.EmailAddress == "" || cx.Address == "" || cx.City == "" || cx.Province == "" ||
                cx.Country == "")
            {
                resultLabel.Text = "All fields are required";
                resultLabel.ForeColor = Color.FromArgb(192, 0, 0); // dark red
                resultLabel.Visible = true;
            }
            else
            {
                if (Login.insertCustomer(cx)) // the query is contained within here
                {
                    this.DialogResult = DialogResult.OK;
                    resultLabel.Text = "Added successfully to the database!";
                    resultLabel.ForeColor = Color.FromArgb(0, 192, 0); // Dark Green
                    resultLabel.Visible = true;
                }
            }
        }
    }
}
