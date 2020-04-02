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
    public partial class FindVehicle : Form
    {
        public FindVehicle()
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
         * When search button is clicked while searching by car ID, an error check is
         * performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
         */
        private void carIDSearchButton_Click(object sender, EventArgs e)
        {
            carIDResultLabel.Visible = true;
            makeModelResultLabel.Visible = false;
            licensePlateResultLabel.Visible = false;

            String carID = carIDTextbox.Text.TrimEnd();
            if (carID == "") // If the text field is empty
            {
                carIDResultLabel.Text = "Please enter something";
                carIDResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query = $"select * from Car where CAR_ID = {carID};";
                // Runs query and updates table
                Common.validTextboxEntry(carIDResultLabel, query, vehicleInfoDataGridView);
            }
        }

        /*
         * When search button is clicked while searching by model and make, an error check 
         * is performed to ensure that both fields are filled with text.
         * The search is performed from the database if both fields contain text.
         */
        private void makeModelSearchButton_Click(object sender, EventArgs e)
        {
            makeModelResultLabel.Visible = true;
            licensePlateResultLabel.Visible = false;
            carIDResultLabel.Visible = false;

            String make = makeTextBox.Text.TrimEnd();
            String model = modelTextBox.Text.TrimEnd();
            if (make == "" || model == "") // If any of the text fields are empty
            {
                makeModelResultLabel.Text = "Please search by both fields";
                makeModelResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query = $"select * from Car where Model = '{model}' and Make = '{make}';";
                // Runs query and updates table
                Common.validTextboxEntry(makeModelResultLabel, query, vehicleInfoDataGridView);
            }
        }

        /*
         * When search button is clicked while searching by License plate number, 
         * an error check is performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contains text.
         */
        private void licensePlateSearchButton_Click(object sender, EventArgs e)
        {
            licensePlateResultLabel.Visible = true;
            makeModelResultLabel.Visible = false;
            carIDResultLabel.Visible = false;

            String licensePlate = licensePlateNumTextBox.Text.TrimEnd();
            if (licensePlate == "") // If the text field is empty
            {
                licensePlateResultLabel.Text = "Please enter something";
                licensePlateResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Creating the query
                String query = $"select * from Car where License_Plate = '{licensePlate}';";
                // Runs query and updates table
                Common.validTextboxEntry(licensePlateResultLabel, query, vehicleInfoDataGridView);
            }
        }
        /*
         * If any cell changes, a check is performed to see which column does the cell lie in, and
         * queries are ran based on the column
         */
        private void vehicleInfoDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (vehicleInfoDataGridView.CurrentRow != null)
            {
                DataGridViewRow row = vehicleInfoDataGridView.CurrentRow; // Current Row

                int currentColIndex = vehicleInfoDataGridView.CurrentCell.ColumnIndex; // Index of modified column
                var update = vehicleInfoDataGridView.CurrentCell.Value; // Value in the modified cell
                var ID = row.Cells["CAR_ID"].Value; // Value of Car ID

                string query;
                string queryTable = "Car";

                switch (currentColIndex) // Column index of the change
                {
                    case 1: // Change BRANCH_ID
                        query = $"UPDATE {queryTable} SET BRANCH_ID = '{update}' WHERE CAR_ID = {ID};";
                        break;
                    case 2: // Change TYPE_NAME
                        query = $"UPDATE {queryTable} SET TYPE_NAME = '{update}' WHERE CAR_ID = {ID};";
                        break;
                    case 3: // Change Make
                        query = $"UPDATE {queryTable} SET Make = '{update}' WHERE CAR_ID = {ID};";
                        break;
                    case 4: // Change Model
                        query = $"UPDATE {queryTable} SET Model = '{update}' WHERE CAR_ID = {ID};";
                        break;
                    case 5: // Change Year
                        query = $"UPDATE {queryTable} SET Year = '{update}' WHERE CAR_ID = {ID};";
                        break;
                    case 6: // Change VIN
                        query = $"UPDATE {queryTable} SET VIN = '{update}' WHERE CAR_ID = {ID};";
                        break;
                    case 7: // Change License_Plate
                        query = $"UPDATE {queryTable} SET License_Plate = '{update}' WHERE CAR_ID = {ID};";
                        break;
                    case 8: // Change Insurance_Policy_Number
                        query = $"UPDATE {queryTable} SET Insurance_Policy_Number = '{update}' WHERE CAR_ID = {ID};";
                        break;
                    case 9: // Change In_Service
                        query = $"UPDATE {queryTable} SET In_Service = '{update}' WHERE CAR_ID = {ID};";
                        break;
                    case 10: // Change Fuel_Type
                        query = $"UPDATE {queryTable} SET Fuel_Type = '{update}' WHERE CAR_ID = {ID};";
                        break;
                    case 11: // Change Transmission
                        query = $"UPDATE {queryTable} SET Transmission = '{update}' WHERE CAR_ID = {ID};";
                        break;
                    case 12: // Change Capacity
                        query = $"UPDATE {queryTable} SET Capacity = '{update}' WHERE CAR_ID = {ID};";
                        break;
                    default:    // default statement sequence
                        return;
                }
                Database.runQuery(query); // Running the query
            }
        }
        /*
         * Limiting the admin to enter only numeric values in the text box 
         */
        private void vehicleInfoDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var colIndex = vehicleInfoDataGridView.CurrentCell.ColumnIndex;
            // When column is Branch_ID, Year or Capacity
            if (colIndex == 1 || colIndex == 5 || colIndex == 12)
            {
                e.Control.KeyPress += numericTextBox_KeyPress;
            }
            // When it is any other column other than the numeric columns
            else
            {
                e.Control.KeyPress -= numericTextBox_KeyPress;
            }
        }
    }
}
