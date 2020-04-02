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
    public partial class FindVehicleType : Form
    {
        public FindVehicleType()
        {
            InitializeComponent();
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
         * When search button is clicked while searching by type Name, an error check is
         * performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
         */
        private void typeSearchButton_Click(object sender, EventArgs e)
        {
            typeResultLabel.Visible = true;
            branchNameResultLabel.Visible = false;

            String typeName = typeTextbox.Text.TrimEnd(); // Value in textbox
            if (typeName == "") // If the text field is empty
            {
                typeResultLabel.Text = "Please enter something";
                typeResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query = $"select * from Type where TYPE_NAME = '{typeName}'";
                // Runs query and updates table
                Common.validTextboxEntry(typeResultLabel, query, vehicleTypeInfoDataGridView);
            }

        }
        /*
         * When search button is clicked while searching for type names at a particular
         * branch, an error check is performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
         */
        private void branchNameSearchButton_Click(object sender, EventArgs e)
        {
            typeResultLabel.Visible = false;
            branchNameResultLabel.Visible = true;

            String branchName = branchNameTextBox.Text.TrimEnd();
            if (branchName == "") // If the text field is empty
            {
                branchNameResultLabel.Text = "Please enter something";
                branchNameResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the sub query 
                string subQuery = 
                    $"(select distinct TYPE_NAME " +
                    $"from Car, Branch " +
                    $"where Car.BRANCH_ID = Branch.BRANCH_ID and Branch.Name = '{branchName}')";
                // Creating the main query 
                string mainQuery = 
                    $"select Type.TYPE_NAME, Daily_Fee, Weekly_Fee, Monthly_Fee " +
                    $"from Type, {subQuery} as temp " +
                    $"where Type.TYPE_NAME = temp.TYPE_NAME;";

                // Runs query and updates table
                Common.validTextboxEntry(branchNameResultLabel, mainQuery, vehicleTypeInfoDataGridView);
            }
        }

        /*
         * Whenever a cell value is changed in the table, then a query is run
         */
        private void vehicleTypeInfoDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (vehicleTypeInfoDataGridView.CurrentRow != null)
            {
                DataGridViewRow row = vehicleTypeInfoDataGridView.CurrentRow; // Current Row

                int currentColIndex = vehicleTypeInfoDataGridView.CurrentCell.ColumnIndex; // Index of modified column
                var update = vehicleTypeInfoDataGridView.CurrentCell.Value; // Value in the modified cell
                var typeName = row.Cells["TYPE_NAME"].Value; // Value of TYPE NAME

                string query;
                string queryTable = "Type"; // Table to query from

                switch (currentColIndex) // Column index of the change
                { // Setting up the query
                    case 1: // Change Daily Fee Value
                        query = $"UPDATE {queryTable} SET Daily_Fee = {update} WHERE TYPE_NAME = '{typeName}';";
                        break;
                    case 2: // Change Weekly Fee Value
                        query = $"UPDATE {queryTable} SET Weekly_Fee = {update} WHERE TYPE_NAME = '{typeName}';";
                        break;
                    case 3: // Change Monthly Fee Value
                        query = $"UPDATE {queryTable} SET Monthly_Fee = {update} WHERE TYPE_NAME = '{typeName}';";
                        break;
                    default:    // default statement sequence
                        return;
                }
                Database.runQuery(query); // Running the query
            }
        }
        /*
         * Limiting the admin to enter only float values in the Fee Fields
         */
        private void vehicleTypeInfoDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // When column is any of the Fee Values
            if (vehicleTypeInfoDataGridView.CurrentCell.ColumnIndex != 0)
            {
                e.Control.KeyPress += checkForANumber;
            }
            // When column is the ID
            else
            {
                e.Control.KeyPress -= checkForANumber;
            }
        }
    }
}
