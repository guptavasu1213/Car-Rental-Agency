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
            branchNameComboBox.Items.Add("Vasu"); // Remove
            branchNameComboBox.Items.Add("Alex"); // Remove
            carTypeComboBox.Items.Add("Ahsan"); // Remove
        }

        /*
         * When the Submit button is clicked and all entries are filled by the user, then entries are added
         * to the database
         * //https://www.youtube.com/watch?v=cdkDHkXyVFI ---------------SHOWS HOW TO POPULATE DROP DOWN FROM THE DATABASE
         */
        private void submitButton_Click(object sender, EventArgs e)
        {
            String carName = carNameTextBox.Text.TrimEnd();
            String make = makeTextBox.Text.TrimEnd();
            String model = modelTextBox.Text.TrimEnd(); 
            String year = yearTextBox.Text.TrimEnd(); //MAYBE AN INTEGER FIELD
            String vinNumber = VINTextBox.Text.TrimEnd();  
            String licensePlateNum = licensePlateTextBox.Text.TrimEnd();
            String registrationNum = registrationTextBox.Text.TrimEnd();
            String insuranceID = insuranceIDTextBox.Text.TrimEnd();

            // If any text field is empty or nothing is selected in the drop down list
            if (carName == "" || make == "" || model == "" || year == "" || vinNumber == "" ||
                licensePlateNum == "" || registrationNum == "" || insuranceID == "" || 
                !inServiceCheckBox.Checked || branchNameComboBox.SelectedIndex == -1 ||
                carTypeComboBox.SelectedIndex == -1)
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

                // RUN THE QUERY
            }
        }


    }
}
