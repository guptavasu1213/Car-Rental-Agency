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
        }

        /*
         * When the Submit button is clicked and all entries are filled by the user, then entries are added
         * to the database
         */
        private void submitButton_Click(object sender, EventArgs e)
        {
            String firstName = firstNameTextBox.Text.TrimEnd();
            String lastName = lastNameTextBox.Text.TrimEnd();
            String phoneNumber = phoneNumberTextBox.Text.TrimEnd(); //MAYBE AN INTEGER FIELD
            String age = ageTextBox.Text.TrimEnd(); //MAYBE AN INTEGER FIELD
            String insuranceID = insuranceIDTexBox.Text.TrimEnd();
            String driverLicenseClassType = driverLicenseClassTypeTextBox.Text.TrimEnd();
            String driverLicenseNumber = driverLicenseNumberTextBox.Text.TrimEnd();

            // Check to ensure all the fields have text
            if (firstName == "" || lastName == "" || phoneNumber == "" || age == "" || insuranceID == "" ||
                driverLicenseNumber == "" || driverLicenseClassType == "")
            {
                resultLabel.Text = "All fields are required";
                resultLabel.ForeColor = Color.FromArgb(192, 0, 0); // dark red
                resultLabel.Visible = true;
            }
            else
            {
                resultLabel.Text = "Added successfully to the \ndatabase!";
                resultLabel.ForeColor = Color.FromArgb(0, 192, 0); // Dark Green
                resultLabel.Visible = true;

                // RUN THE QUERY
            }
        }
    }
}
