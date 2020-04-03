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
    public partial class FindBooking : Form
    {
        public FindBooking()
        {
            InitializeComponent();
        }
        /*
         * Allowing only numerical values for for numeric fields (integer like only)
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
        
        private void transactionIDSearchButton_Click(object sender, EventArgs e)
        {
            branchIDResultLabel.Visible = false;
            customerIDResultLabel.Visible = false;
            transactionResultLabel.Visible = true;

            String transactionID = transactionIDTextBox.Text.TrimEnd();
            if (transactionID == "") // If the text field is empty
            {
                transactionResultLabel.Text = "Please enter something";
                transactionResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query = $"select * from [Transaction] where TRANSACTION_ID = {transactionID};";
                // Runs query and updates table
                Common.validTextboxEntry(transactionResultLabel, query, transactionInfoDataGridView);
            }
        }

        /*
         * When search button is clicked while searching for all transactions by customer ID,
         * an error check is performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
         */
        private void customerIDSearchButton_Click(object sender, EventArgs e)
        {
            branchIDResultLabel.Visible = false;
            customerIDResultLabel.Visible = true;
            transactionResultLabel.Visible = false;

            String customerID = customerIDTextbox.Text.TrimEnd();
            if (customerID == "") // If the text field is empty
            {
                customerIDResultLabel.Text = "Please enter something";
                customerIDResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query = $"select * from [Transaction] where CUSTOMER_ID = {customerID};";
                // Runs query and updates table
                Common.validTextboxEntry(customerIDResultLabel, query, transactionInfoDataGridView);
            }
        }
        /*
         * When search button is clicked while searching for all transactions by branch ID,
         * an error check is performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
         */
        private void branchIDSearchButton_Click(object sender, EventArgs e)
        {
            branchIDResultLabel.Visible = true;
            customerIDResultLabel.Visible = false;
            transactionResultLabel.Visible = false;


            String branchID = branchIDTextBox.Text.TrimEnd();
            if (branchID == "") // If the text field is empty
            {
                branchIDResultLabel.Text = "Please enter something";
                branchIDResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query =  $"select * from [Transaction] where PICKUP_BRANCH_ID = {branchID} " +
                                $"or DROP_BRANCH_ID = {branchID};";
                // Runs query and updates table
                Common.validTextboxEntry(branchIDResultLabel, query, transactionInfoDataGridView);
            }

        }
        /*
         * If any cell changes, a check is performed to see which column does the cell lie in, and
         * queries are ran based on the column
         */
        private void transactionInfoDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (transactionInfoDataGridView.CurrentRow != null)
            {
                DataGridViewRow row = transactionInfoDataGridView.CurrentRow; // Current Row

                int currentColIndex = transactionInfoDataGridView.CurrentCell.ColumnIndex; // Index of modified column
                var update = transactionInfoDataGridView.CurrentCell.Value; // Value in the modified cell

                string query;
                string queryTable = "[Transaction]"; // Table to query from
                string keyName = "TRANSACTION_ID"; // Key Name

                var ID = row.Cells[keyName].Value; // Value of Transaction ID

                switch (currentColIndex) // Column index of the change
                {
                    case 1: // Change CUSTOMER_ID
                        query = $"UPDATE {queryTable} SET CUSTOMER_ID = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 2: // Change CAR_ID
                        query = $"UPDATE {queryTable} SET CAR_ID = {update} WHERE {keyName} = {ID};";
                        break;
                    case 3: // Change DROP_EMPLOYEE_ID
                        query = $"UPDATE {queryTable} SET DROP_EMPLOYEE_ID = {update} WHERE {keyName} = {ID};";
                        break;
                    case 4: // Change PICKUP_EMPLOYEE_ID
                        query = $"UPDATE {queryTable} SET PICKUP_EMPLOYEE_ID = {update} WHERE {keyName} = {ID};";
                        break;
                    case 5: // Change PICKUP_BRANCH_ID
                        query = $"UPDATE {queryTable} SET PICKUP_BRANCH_ID = {update} WHERE {keyName} = {ID};";
                        break;
                    case 6: // Change DROP_BRANCH_ID
                        query = $"UPDATE {queryTable} SET DROP_BRANCH_ID = {update} WHERE {keyName} = {ID};";
                        break;
                    case 7: // Change Pickup_Date_Time
                        query = $"UPDATE {queryTable} SET Pickup_Date_Time = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 8: // Change Return_Date_Time
                        query = $"UPDATE {queryTable} SET Return_Date_Time = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 9: // Change Amount
                        query = $"UPDATE {queryTable} SET Amount = {update} WHERE {keyName} = {ID};";
                        break;
                    case 10: // Change Card_Number
                        query = $"UPDATE {queryTable} SET Card_Number = {update} WHERE {keyName} = {ID};";
                        break;
                    case 11: // Change Card_Type
                        query = $"UPDATE {queryTable} SET Card_Type = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 12: // Change Payment_Method
                        query = $"UPDATE {queryTable} SET Payment_Method = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 13: // Status
                        query = $"UPDATE {queryTable} SET Status = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 14: // Transaction_Date_Time
                        query = $"UPDATE {queryTable} SET Transaction_Date_Time = '{update}' WHERE {keyName} = {ID};";
                        break;
                    default:    // default statement sequence
                        return;
                }
                Database.runQuery(query); // Running the query
            }
        }

        private void transactionInfoDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var currentCol = transactionInfoDataGridView.CurrentCell.ColumnIndex;
            // When column is any of the FK or is a Card number
            if ((currentCol >=1 && currentCol <= 6) || currentCol == 10)
            {
                e.Control.KeyPress += numericTextBox_KeyPress; // Allowing non-decimal numbers
            }
            // When column is Amount 
            else if (currentCol == 9)
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

    }
}
