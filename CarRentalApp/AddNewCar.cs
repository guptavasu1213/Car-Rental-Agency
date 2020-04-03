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
    public partial class AddNewCar : Form
    {
        public AddNewCar()
        {
            InitializeComponent();

            // Filling branch combo box
            string query = "select Name from Branch;";
            DataTable table = Database.getDataTableAfterRunningQuery(query);
            Common.fillComboBox(branchNameComboBox, "Name",  table);

            // Filling TYPE_NAME combo box
            query = "select TYPE_NAME from Type;";
            table = Database.getDataTableAfterRunningQuery(query);
            Common.fillComboBox(carTypeComboBox, "TYPE_NAME", table);
        }
        
        /*
         * When the Submit button is clicked and all entries are filled by the user, then entries are added
         * to the database
         */
        private void submitButton_Click(object sender, EventArgs e)
        {
            String carName = fuelTypeTextBox.Text.TrimEnd();
            String make = makeTextBox.Text.TrimEnd();
            String model = modelTextBox.Text.TrimEnd(); 
            String year = yearTextBox.Text.TrimEnd(); 
            String vinNumber = VINTextBox.Text.TrimEnd();  
            String licensePlateNum = licensePlateTextBox.Text.TrimEnd();
            String insuranceID = insuranceIDTextBox.Text.TrimEnd();
            String fuelType = fuelTypeTextBox.Text.TrimEnd();
            String transmission = transmissionTextBox.Text.TrimEnd();
            String capacity = capacityTextBox.Text.TrimEnd();
            String inService = inServiceCheckBox.Checked.ToString();

            // If any text field is empty or nothing is selected in the drop down list
            if (carName == "" || make == "" || model == "" || year == "" || vinNumber == "" ||
                licensePlateNum == "" || insuranceID == "" || 
                fuelType == "" || transmission == "" || capacity == "" ||
                branchNameComboBox.SelectedIndex == -1 || carTypeComboBox.SelectedIndex == -1
                )
            {
                resultLabel.Text = "All fields are required";
                resultLabel.ForeColor = Color.FromArgb(192, 0, 0); // Dark Red
                resultLabel.Visible = true;
            }
            // Adding all the fields for the employee to the database
            else
            {
                resultLabel.Text = "Added successfully to the database!";
                resultLabel.ForeColor = Color.FromArgb(0, 192, 0); // Dark Green
                resultLabel.Visible = true;

                string branchName = branchNameComboBox.SelectedItem.ToString();
                string typeName = carTypeComboBox.SelectedItem.ToString();

                // Finding the BRANCH ID for the Name in the drop down
                string query = $"select BRANCH_ID from Branch where Name = '{branchName}';";
                DataTable table = Database.getDataTableAfterRunningQuery(query);

                var branchID = (table.Rows[0]["BRANCH_ID"]);

                //// Create the query
                query = "INSERT INTO Car(BRANCH_ID, TYPE_NAME, Make, Model, Year, VIN, License_Plate, Insurance_Policy_Number, In_Service, Fuel_Type, Transmission, Capacity) " +
                    $"VALUES('{branchID}', '{typeName}', '{make}', '{model}', {year}, '{vinNumber}', '{licensePlateNum}', '{insuranceID}', '{inService}', '{fuelType}', '{transmission}', '{capacity}')";
                Database.runQuery(query);
            }
        }
        /*
         * Allowing only numerical values for Year
         */
        private void yearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
