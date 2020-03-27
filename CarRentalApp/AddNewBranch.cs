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
    public partial class AddNewBranch : Form
    {
        public AddNewBranch()
        {
            InitializeComponent();
        }

        /*
         * When the Submit button is clicked and all entries are filled by the user, then entries are added
         * to the database
         */
        private void submitButton_Click(object sender, EventArgs e)
        {
            String branchName = branchNameTextBox.Text.TrimEnd();
            String streetAddress = streetAddressTexBox.Text.TrimEnd();
            String city = cityTextBox.Text.TrimEnd(); //MAYBE AN INTEGER FIELD
            String province = provinceTextBox.Text.TrimEnd(); //MAYBE AN INTEGER FIELD
            String country = countryTextBox.Text.TrimEnd();
            String phoneNumber = phoneNumberTextBox.Text.TrimEnd();

            // Check to ensure all the fields have text
            if (branchName == "" || streetAddress == "" || phoneNumber == "" || city == "" || province == "" ||
                country == "")
            {
                resultLabel.Text = "All fields are required";
                resultLabel.ForeColor = Color.FromArgb(192, 0, 0); // dark red
                resultLabel.Visible = true;
            }
            else
            {
                resultLabel.Text = "Added successfully to the database!";
                resultLabel.ForeColor = Color.FromArgb(0, 192, 0); // Dark Green
                resultLabel.Visible = true;

                // RUN THE QUERY
            }
        }
        /*
         * Allowing only numerical values for Phone Number
         */
        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
