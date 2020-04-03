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
    public partial class FindBranch : Form
    {
        public FindBranch()
        {
            InitializeComponent();
        }

        /*
         * When search button is clicked while searching for all branches by branch ID,
         * an error check is performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
         */
        private void branchIDSearchButton_Click(object sender, EventArgs e)
        {
            branchIDResultLabel.Visible = true;
            branchNameResultLabel.Visible = false;

            String branchID = branchIDTextbox.Text.TrimEnd();
            if (branchID == "") // If the text field is empty
            {
                branchIDResultLabel.Text = "Please enter something";
                branchIDResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query = $"select * from Branch where BRANCH_ID = {branchID};";
                // Runs query and updates table
                Common.validTextboxEntry(branchIDResultLabel, query, branchInfoDataGridView);
            }

        }
        /*
         * When search button is clicked while searching for all branches by Names,
         * an error check is performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
         */
        private void branchNameSearchButton_Click(object sender, EventArgs e)
        {
            branchIDResultLabel.Visible = false;
            branchNameResultLabel.Visible = true;

            String branchName = branchNameTextBox.Text.TrimEnd();
            if (branchName == "") // If the text field is empty
            {
                branchNameResultLabel.Text = "Please enter something";
                branchNameResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query = $"select * from Branch where Name = '{branchName}';";
                // Runs query and updates table
                Common.validTextboxEntry(branchIDResultLabel, query, branchInfoDataGridView);
            }
        }

        private void branchInfoDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (branchInfoDataGridView.CurrentRow != null)
            {
                DataGridViewRow row = branchInfoDataGridView.CurrentRow; // Current Row

                int currentColIndex = branchInfoDataGridView.CurrentCell.ColumnIndex; // Index of modified column
                var update = branchInfoDataGridView.CurrentCell.Value; // Value in the modified cell

                string query;
                string queryTable = "Branch"; // Table to query from
                string keyName = "BRANCH_ID"; // Key Name

                var ID = row.Cells[keyName].Value; // Value of Branch ID

                switch (currentColIndex) // Column index of the change
                {
                    case 1: // Change Name
                        query = $"UPDATE {queryTable} SET Name = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 2: // Change City
                        query = $"UPDATE {queryTable} SET City = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 3: // Change Province
                        query = $"UPDATE {queryTable} SET Province = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 4: // Change Country
                        query = $"UPDATE {queryTable} SET Country = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 5: // Change Street_Address
                        query = $"UPDATE {queryTable} SET Street_Address = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 6: // Change Phone
                        query = $"UPDATE {queryTable} SET Phone = {update} WHERE {keyName} = {ID};";
                        break;
                    case 7: // Change Email
                        query = $"UPDATE {queryTable} SET Email = '{update}' WHERE {keyName} = {ID};";
                        break;
                    case 8: // Change Status
                        query = $"UPDATE {queryTable} SET Status = '{update}' WHERE {keyName} = {ID};";
                        break;
                    default:    // default statement sequence
                        return;
                }
                Database.runQuery(query); // Running the query
            }
        }
        /*
         * Allowing only numerical values for the textbox
         */
        private void numericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void branchInfoDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var colIndex = branchInfoDataGridView.CurrentCell.ColumnIndex;
            // When column is Phone Number
            if (colIndex == 6)
            {
                e.Control.KeyPress += numericTextBox_KeyPress;
            }
            // When it is any other column other than the numeric columns
            else
            {
                e.Control.KeyPress -= numericTextBox_KeyPress;
            }
        }

        private void branchIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}