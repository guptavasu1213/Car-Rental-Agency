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
    public partial class FindEmployee : Form
    {
        public FindEmployee()
        {
            InitializeComponent();
        }
        /*
         * Allowing only numerical values for for numeric fields
         */
        private void numericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /*
         * The function checks if the user entered value is a number (integer, or a float).
         * The digit is not typed in the textbox if the digit is not an integer or a float
         */
        private void checkForANumber(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
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
                employeeInfoDataGridView.DataSource = null; // Make table empty
                MessageBox.Show("No such entry found in the database!");
            }
            // Else: Populating the table with the query result
            else { employeeInfoDataGridView.DataSource = table; }
        }
        /*
         * When search button is clicked while searching by employee ID, an error check is
         * performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
         */
        private void employeeIDSearchButton_Click(object sender, EventArgs e)
        {
            employeeIDResultLabel.Visible = true;
            nameResultLabel.Visible = false;
            sinResultLabel.Visible = false;
            phoneNumResultLabel.Visible = false;

            String employeeID = employeeIDTextbox.Text.TrimEnd();
            if (employeeID == "") // If the text field is empty
            {
                employeeIDResultLabel.Text = "Please enter something";
                employeeIDResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query = $"select * from Employee where EMPLOYEE_ID = '{employeeID}';";
                // Runs query and updates table
                validTextboxEntry(employeeIDResultLabel, query);
            }
        }

        /*
         * When search button is clicked while searching by name, an error check is
         * performed to ensure that both fields are filled with text.
         * The search is performed from the database if both fields contain text.
         */
        private void nameSearchButton_Click(object sender, EventArgs e)
        {
            nameResultLabel.Visible = true;
            sinResultLabel.Visible = false;
            phoneNumResultLabel.Visible = false;
            employeeIDResultLabel.Visible = false;
            
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
                String query = $"select * from Employee where First_Name = '{fName}' and Last_Name = '{lName}';";
                // Runs query and updates table
                validTextboxEntry(employeeIDResultLabel, query);
            }
        }
        /*
         * When search button is clicked while searching by SIN number, an error check is
         * performed to ensure that the field for SIN is filled with text.
         * The search is performed from the database if the field contains text.
         */
        private void sinSearchButton_Click(object sender, EventArgs e)
        {
            sinResultLabel.Visible = true;
            phoneNumResultLabel.Visible = false;
            nameResultLabel.Visible = false;
            employeeIDResultLabel.Visible = false;

            String sin = sinTextBox.Text.TrimEnd();
            if (sin == "") // If the text field is empty
            {
                sinResultLabel.Text = "Please enter something";
                sinResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query = $"select * from Employee where Employee.SIN = '{sin}';";
                // Runs query and updates table
                validTextboxEntry(employeeIDResultLabel, query);
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
            sinResultLabel.Visible = false;
            employeeIDResultLabel.Visible = false;

            String phoneNum = phoneNumberTextBox.Text.TrimEnd();
            if (phoneNum == "") // If the text field is empty
            {
                phoneNumResultLabel.Text = "Please enter something";
                phoneNumResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query = $"select * from Employee where Phone_Number = '{phoneNum}';";
                // Runs query and updates table
                validTextboxEntry(employeeIDResultLabel, query);
            }
        }
        /*
         * The function is called whenever the delete button is hit when a row is selected
         * Admin is asked for a verification message to check if the record is supposed to be deleted.
         * The query for deleting the selected row is launched
         */
        private void employeeInfoDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // Getting the Employee ID at the selected row
            var employeeID = employeeInfoDataGridView.CurrentRow.Cells["EMPLOYEE_ID"].Value;
            if (employeeID != DBNull.Value)
            {
                // Verification message for the admin
                if (MessageBox.Show("Are you sure to delete an entry?", "Deleting Entry", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Creating the query
                    String query = $"Delete from Employee where EMPLOYEE_ID = {employeeID}";
                    // Run the query
                    Database.runQuery(query);
                }
                else
                    e.Cancel = true; // Do not delete
            }
            else
                e.Cancel = true; // Do not delete
        }
        /*
         * Limiting the admin to enter only numeric values in the text box for numeric fields and float values
         * for float fields
         */
        private void employeeInfoDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var currentCol = employeeInfoDataGridView.CurrentCell.ColumnIndex;
            // When column is BRANCH_ID, Phone number
            if (currentCol == 1 || currentCol == 4)
            {
                e.Control.KeyPress += numericTextBox_KeyPress; // Allowing non-decimal numbers
            }
            // When column is Amount 
            else if (currentCol == 6)
            {
                e.Control.KeyPress += checkForANumber; // Allowing decimal values
            }
            // When it is any other column other than phone number
            else
            {
                e.Control.KeyPress -= numericTextBox_KeyPress;
                e.Control.KeyPress -= checkForANumber;
            }
        }

        /*
         * If any cell changes, a check is performed to see which column does the cell lie in, and
         * queries are ran based on the column
         */
        private void employeeInfoDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (employeeInfoDataGridView.CurrentRow != null)
            {
                DataGridViewRow row = employeeInfoDataGridView.CurrentRow; // Current Row

                int currentColIndex = employeeInfoDataGridView.CurrentCell.ColumnIndex; // Index of modified column
                var update = employeeInfoDataGridView.CurrentCell.Value; // Value in the modified cell
                var ID = row.Cells["EMPLOYEE_ID"].Value; // Value of Employee ID

                // Change Branch ID
                if (currentColIndex == 1)
                {
                    string query = $"UPDATE Employee SET BRANCH_ID = '{update}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change First Name
                else if (currentColIndex == 2)
                {
                    string query = $"UPDATE Employee SET First_Name = '{update}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Last Name
                else if (currentColIndex == 3)
                {
                    string query = $"UPDATE Employee SET Last_Name = '{update}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Phone Number
                else if (currentColIndex == 4)
                {
                    string query = $"UPDATE Employee SET Phone_Number = '{update}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Email
                else if (currentColIndex == 5)
                {
                    string query = $"UPDATE Employee SET Email = '{update}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Salary
                else if (currentColIndex == 6)
                {
                    string query = $"UPDATE Employee SET Salary = '{update}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Position
                else if (currentColIndex == 7)
                {
                    string query = $"UPDATE Employee SET Position = '{update}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Status // Active or In Active
                else if (currentColIndex == 8)
                {
                    string query = $"UPDATE Employee SET Status = '{update}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Employment Type
                else if (currentColIndex == 9)
                {
                    string query = $"UPDATE Employee SET Employment_Type = '{update}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Birthday
                else if (currentColIndex == 10)
                {
                    string query = $"UPDATE Employee SET Birthday = '{update}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change SIN
                else if (currentColIndex == 11)
                {
                    string query = $"UPDATE Employee SET SIN = '{update}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Password
                else if (currentColIndex == 12)
                {
                    // Hashing password first
                    string hashedPass = Login.HashPassword(update.ToString());
                    string query = $"UPDATE Employee SET Password = '{hashedPass}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Street_Address
                else if (currentColIndex == 13)
                {
                    string query = $"UPDATE Employee SET Street_Address = '{update}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change City
                else if (currentColIndex == 14)
                {
                    string query = $"UPDATE Employee SET City = '{update}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Province
                else if (currentColIndex == 15)
                {
                    string query = $"UPDATE Employee SET Province = '{update}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
                // Change Country
                else if (currentColIndex == 16)
                {
                    string query = $"UPDATE Employee SET Country = '{update}' WHERE EMPLOYEE_ID = {ID};";
                    Database.runQuery(query);
                }
            }

        }
    }
}
