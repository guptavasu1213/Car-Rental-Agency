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
    public partial class AddNewBooking : Form
    {
        public AddNewBooking()
        {
            InitializeComponent();
            // Populating the drop down menus 
            carFuelComboBox.Items.Add("Petrol");
            carFuelComboBox.Items.Add("Diesel");
            carTransmissionComboBox.Items.Add("Automatic");
            carTransmissionComboBox.Items.Add("Manual");

            // DELETE ALL THESE
            pickupComboBox.Items.Add("Vasu");
            dropOffComboBox.Items.Add("Ahsan");
            makeComboCox.Items.Add("Alex");
            modelComboBox.Items.Add("Worthy");
        }
        /*
         * Whenever the customer ID text box is left, the text within the textbox 
         * is evaluated. If the customer ID entered in the textbox is found in the 
         * database, then the user is notified.
         */
        private void customerIDTextBox_Leave(object sender, EventArgs e)
        {
            String customerID = customerIDTextBox.Text.Trim();
            if (customerID.Length == 0) // Textbox is empty
            {
                customerResultLabel.Text = "Field is empty";
                customerResultLabel.ForeColor = Color.FromArgb(192, 0, 0); // Dark red
                return;
            }
            // If customer id is in the database
            if (customerID == "123")
            {
                customerResultLabel.Text = "Valid Customer ID";
                customerResultLabel.ForeColor = Color.FromArgb(0, 192, 0); // Dark green
            }
            // If the customer ID is not found in the database
            else
            {
                customerResultLabel.Text = "Invalid Customer ID";
                customerResultLabel.ForeColor = Color.FromArgb(192, 0, 0); // Dark red
            }
        }

        /*
         * Checks if the following mandatory fields are selected:
         * - Validity of Customer ID 
         * - Pickup branch 
         * - Dropoff Branch
         * - Make
         * - Model         
         * Returns: True if all the mandatory fields are filled and valid. False if there is any invalid
         * entry
         */
        private bool errorCheckForEmptyMandatoryFields()
        {
            int flag = 0;
            // Customer ID 
            if (customerResultLabel.ForeColor == Color.FromArgb(192, 0, 0))
            {
                flag = 1;
            }

            // Pickup branch drop down
            if (pickupComboBox.SelectedIndex == -1)
            {
                errorPickupBranch.Text = "Please select a branch";
                flag = 1;
            }
            else
            {
                errorPickupBranch.Text = "";
            }
            // Dropoff branch drop down
            if (dropOffComboBox.SelectedIndex == -1)
            {
                errorDropoffBranch.Text = "Please select a branch";
                flag = 1;
            }
            else
            {
                errorDropoffBranch.Text = "";

            }
            // Make drop down
            if (makeComboCox.SelectedIndex == -1)
            {
                errorMake.Text = "Please select a make of car";
                flag = 1;
            }
            else
            {
                errorMake.Text = "";
            }
            // Model drop down
            if (modelComboBox.SelectedIndex == -1)
            {
                errorModel.Text = "Please select a model of a car";
                flag = 1;
            }
            else
            {
                errorModel.Text = "";
            }

            // Returning appropriate values
            if (flag == 1) { return false; }
            else { return true; }
        }
        /*
         * When submit button is clicked, the mandatory fields are checked if they are filled.
         * If all the mandatory fields are selected, then we check for all the optional fields 
         * and make the queries as per the condition.
         */
        private void submitButton_Click(object sender, EventArgs e)
        {
            //if (pickUpDate.Value.Date < DateTime.Today)
            //{
            //    resultLabel.Visible = true;
            //    resultLabel.Text = "NOOOOOOOOOOOOOO";
            //    resultLabel.ForeColor = Color.FromArgb(192, 0, 0);
            //}
            //else
            //{
            //    resultLabel.Visible = true;
            //    resultLabel.Text = "YEEEE";
            //    resultLabel.ForeColor = Color.FromArgb(0, 192, 0);
            //}

            // Check if the mandatory fields are filled
            if (!errorCheckForEmptyMandatoryFields())
            {
                resultLabel.ForeColor = Color.FromArgb(192, 0, 0); // dark red
                resultLabel.Text = "Please enter all the mandatory fields";
                return;
            }

            // Setting the result label
            resultLabel.ForeColor = Color.FromArgb(0, 192, 0); // dark green
            resultLabel.Text = "Added the transaction to the database!\nYour Transaction Number is #1234567";

            // Check if Transmission and Fuel type are selected
            if (carTransmissionComboBox.SelectedIndex != -1 && carFuelComboBox.SelectedIndex != -1)
            {
                //resultLabel.Text = "Both are selected";

                // Get the values for all the fields
                // Run a query
                // Generate booking number
            }
            else if (carTransmissionComboBox.SelectedIndex != -1) // Check if Transmission is selected
            {
                //resultLabel.Text = "Trans is selected";

                // Get the values for all the fields
                // Run a query
                // Generate booking number
            }
            else if (carFuelComboBox.SelectedIndex != -1) // Fuel type is selected
            {
                //resultLabel.Text = "Fuel type is selected";

                // Get the values for all the fields
                // Run a query
                // Generate booking number
            }
            else // None of the optional fields are selected
            {
                //resultLabel.Text = "None of the optional fields are selected";

                // Get the values for all the fields
                // Run a query
                // Generate booking number
            }
        }
    }
}
