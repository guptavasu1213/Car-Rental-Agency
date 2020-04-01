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
         * The function is called when the entry in the textbox is valid
         * PURPOSE:
         * - Changing the label to success
         * - Running the query
         * - If there is no entry found, the error message is displayed
         * - Else the table is updated
         */
        private void validTextboxEntry(Label label, String query)
        {
            // Changing the result label
            label.Text = "Running the query . . . ";
            label.ForeColor = Color.FromArgb(0, 192, 0); //dark green

            // fill the table with the value retrieved
            DataTable table = Database.getDataTableAfterRunningQuery(query);
            // If: Resulting table after the query is empty
            if (table.Rows.Count == 0)
            {
                customerInfoDataGridView.DataSource = null; // Make table empty
                MessageBox.Show("No such entry found in the database!");
            }
            // Else: Populating the table with the query result
            else { customerInfoDataGridView.DataSource = table; }
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
                validTextboxEntry(customerIDResultLabel, query);
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
                validTextboxEntry(nameResultLabel, query);
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
                validTextboxEntry(phoneNumResultLabel, query);
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
                validTextboxEntry(emailResultLabel, query);
            }
        }
        /*
         * 
         */
        private void deleteButton_Click(object sender, EventArgs e)
        {

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
                var whatever = customerInfoDataGridView.CurrentCell.Value; // Value in the modified cell
                var ID = row.Cells["CUSTOMER_ID"].Value; // Value of customer ID

                Console.WriteLine($"{whatever} in {ID}");
                // Change First Name
                if (currentColIndex == 1)
                {
                    string query = $"UPDATE Customer SET First_Name = '{whatever}' WHERE CUSTOMER_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Last Name
                else if (currentColIndex == 2)
                {
                    string query = $"UPDATE Customer SET Last_Name = '{whatever}' WHERE CUSTOMER_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Phone Number
                else if (currentColIndex == 3)
                {
                    string query = $"UPDATE Customer SET Phone_Number = '{whatever}' WHERE CUSTOMER_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Email
                else if (currentColIndex == 4)
                {
                    string query = $"UPDATE Customer SET Phone_Number = '{whatever}' WHERE CUSTOMER_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Insurance_Policy_Number
                else if (currentColIndex == 5)
                {
                    string query = $"UPDATE Customer SET Insurance_Policy_Number = '{whatever}' WHERE CUSTOMER_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Drivers_License
                else if (currentColIndex == 6)
                {
                    string query = $"UPDATE Customer SET Drivers_License = '{whatever}' WHERE CUSTOMER_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Password
                else if (currentColIndex == 7)
                {
                    // Hashing password first
                    string hashedPass = Login.HashPassword(whatever.ToString());
                    string query = $"UPDATE Customer SET Password = '{hashedPass}' WHERE CUSTOMER_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change City
                else if (currentColIndex == 8)
                {
                    string query = $"UPDATE Customer SET City = '{whatever}' WHERE CUSTOMER_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Province
                else if (currentColIndex == 9)
                {
                    string query = $"UPDATE Customer SET Province = '{whatever}' WHERE CUSTOMER_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Country
                else if (currentColIndex == 10)
                {
                    string query = $"UPDATE Customer SET Country = '{whatever}' WHERE CUSTOMER_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Street_Address
                else if (currentColIndex == 11)
                {
                    string query = $"UPDATE Customer SET Street_Address = '{whatever}' WHERE CUSTOMER_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Membership_Status
                else if (currentColIndex == 12)
                {
                    string query = $"UPDATE Customer SET Membership_Status = '{whatever}' WHERE CUSTOMER_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Birthday
                else if (currentColIndex == 13)
                {
                    string query = $"UPDATE Customer SET Birthday = '{whatever}' WHERE CUSTOMER_ID = {ID};";
                    Database.runQuery(query);
                }
            }
        }
        /*
         * Limiting the admin to enter only numeric values in the text box for phone number
         */
        private void customerInfoDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // When column is phone number
            if (customerInfoDataGridView.CurrentCell.ColumnIndex == 3)
            {
                e.Control.KeyPress += numericTextBox_KeyPress;
            }
            // When it is any other column other than phone number
            else
            {
                e.Control.KeyPress -= numericTextBox_KeyPress;
            }

        }
    }
}
