using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class FindUser : Form
    {
        public FindUser()
        {
            InitializeComponent();
        }
        /*
         * Allowing only numerical values for the textbox
         */
        private void numericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /*
         * When search button is clicked while searching by customer ID, an error check is
         * performed to ensure that the text field is filled with text by the user.
         * The search is performed from the database if the field contains text.
         */
        private void customerIDSearchButton_Click(object sender, EventArgs e)
        {
            customerIDResultLabel.Visible = true;
            nameResultLabel.Visible = false;
            emailResultLabel.Visible = false;
            phoneNumResultLabel.Visible = false;

            String customerID = customerIDTextbox.Text.TrimEnd();
            if (customerID == "") // If the text field is empty
            {
                customerIDResultLabel.Text = "Please enter something";
                customerIDResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query = $"select * from Customer where Customer.CUSTOMER_ID = '{customerID}';";
                // Runs query and updates table
                Common.validTextboxEntry(customerIDResultLabel, query, customerInfoDataGridView);
            }
        }

        /*
         * When search button is clicked while searching by name, an error check is
         * performed to ensure that both fields are filled with text.
         * The search is performed from the database if bo+th fields contain text.
         */
        private void NameSearchButton_Click(object sender, EventArgs e)
        {
            nameResultLabel.Visible = true;
            emailResultLabel.Visible = false;
            phoneNumResultLabel.Visible = false;
            customerIDResultLabel.Visible = false;


            String fName = firstNameTextBox.Text.TrimEnd();
            String lName = lastNameTextBox.Text.TrimEnd();
            if (fName == "" || lName == "") // If any of the text fields are empty
            {
                nameResultLabel.Text = "Please search by both fields";
                nameResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query = $"select * from Customer where Customer.First_Name = '{fName}' and Customer.Last_Name = '{lName}';";

                // Runs query and updates table
                Common.validTextboxEntry(nameResultLabel, query, customerInfoDataGridView);
            }
        }
        /*
         * When search button is clicked while searching by phone number, an error check is
         * performed to ensure that the field for phone num is filled with text.
         * The search is performed from the database if the field contains text.
         */
        private void phoneNumSearchButton_Click(object sender, EventArgs e)
        {
            phoneNumResultLabel.Visible = true;
            nameResultLabel.Visible = false;
            emailResultLabel.Visible = false;
            customerIDResultLabel.Visible = false;

            String phoneNum = phoneNumberTextBox.Text.TrimEnd();
            if (phoneNum == "") // If the text field is empty
            {
                phoneNumResultLabel.Text = "Please enter something";
                phoneNumResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query = $"select * from Customer where Customer.Phone_Number = {phoneNum};";

                // Runs query and updates table
                Common.validTextboxEntry(phoneNumResultLabel, query, customerInfoDataGridView);
            }
        }
        /*
         * When search button is clicked while searching by email, an error check is
         * performed to ensure that the field for email is filled with text.
         * The search is performed from the database if the field contains text.
         */
        private void emailSearchButton_Click(object sender, EventArgs e)
        {
            emailResultLabel.Visible = true;
            phoneNumResultLabel.Visible = false;
            nameResultLabel.Visible = false;
            customerIDResultLabel.Visible = false;

            String email = emailTextBox.Text.TrimEnd();
            if (email == "") // If the text field is empty
            {
                emailResultLabel.Text = "Please enter something";
                emailResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query = $"select * from Customer where Customer.Email = '{email}';";

                // Runs query and updates table 
                Common.validTextboxEntry(emailResultLabel, query, customerInfoDataGridView);
            }
        }

        /*
         * If any cell changes, a check is performed to see which column does the cell lie in, and
         * queries are ran based on the column
         */
        private void customerInfoDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (customerInfoDataGridView.CurrentRow != null)
            {
                DataGridViewRow row = customerInfoDataGridView.CurrentRow; // Current Row

                int currentColIndex = customerInfoDataGridView.CurrentCell.ColumnIndex; // Index of modified column
                var update = customerInfoDataGridView.CurrentCell.Value; // Value in the modified cell

                string query;
                string queryTable = "Customer"; // Table to query from
                string keyName = "CUSTOMER_ID"; // Key Name

                var ID = row.Cells[keyName].Value; // Value of Customer ID

                switch (currentColIndex) // Column index of the change
                {
                    case 1: // Change First_Name
                        query = $"UPDATE {queryTable} SET First_Name = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 2: // Change Last_Name
                        query = $"UPDATE {queryTable} SET Last_Name = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 3: // Change Phone_Number
                        query = $"UPDATE {queryTable} SET Phone_Number = {update} WHERE {keyName} = {ID};";
                        break;
                    case 4: // Change Email
                        query = $"UPDATE {queryTable} SET Email = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 5: // Change Insurance_Policy_Number
                        query = $"UPDATE {queryTable} SET Insurance_Policy_Number = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 6: // Change Drivers_License
                        query = $"UPDATE {queryTable} SET Drivers_License = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 7: // Change Password
                        // Hashing password first
                        string hashedPass = Login.HashPassword(update.ToString());
                        query = $"UPDATE {queryTable} SET Password = '{hashedPass}' WHERE {keyName} = {ID};";
                        break;
                    case 8: // Change City
                        query = $"UPDATE {queryTable} SET City = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 9: // Change Province
                        query = $"UPDATE {queryTable} SET Province = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 10: // Change Country
                        query = $"UPDATE {queryTable} SET Country = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 11: // Change Street_Address
                        query = $"UPDATE {queryTable} SET Street_Address = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 12: // Change Membership_Status
                        query = $"UPDATE {queryTable} SET Membership_Status = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 13: // Birthday
                        query = $"UPDATE {queryTable} SET Birthday = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 14: // Card_Type
                        query = $"UPDATE {queryTable} SET Card_Type = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 15: // Card_Number
                        query = $"UPDATE {queryTable} SET Card_Number = {update} WHERE {keyName} = {ID};";
                        break;
                    default:    // default statement sequence
                        return;
                }
                Database.runQuery(query); // Running the query
            }
        }
        /*
         * Limiting the admin to enter only numeric values in the text box for numeric field
         */
        private void customerInfoDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // When column is a numeric field
            if (customerInfoDataGridView.CurrentCell.ColumnIndex == 3 || customerInfoDataGridView.CurrentCell.ColumnIndex == 15)
            {
                e.Control.KeyPress += numericTextBox_KeyPress;
            }
            // When it is any other column other than a numeric field
            else
            {
                e.Control.KeyPress -= numericTextBox_KeyPress;
            }

        }
    }
}
