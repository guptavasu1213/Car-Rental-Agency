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
    public partial class AddNewEmployee : Form
    {
        public AddNewEmployee()
        {
            InitializeComponent();
        }

        /*
         * When the Submit button is clicked and all entries are filled by the user, then entries are added
         * to the database
         */
        private void submitButton_Click(object sender, EventArgs e)
        {
            String firstName = firstNameTextBox.Text.TrimEnd();
            String lastName = lastNameTextBox.Text.TrimEnd();
            String phoneNumber = phoneNumberTextBox.Text.TrimEnd(); //MAYBE AN INTEGER FIELD
            String email = emailTextBox.Text.TrimEnd();
            String salary = salaryTextBox.Text.TrimEnd();  //MAYBE AN INTEGER FIELD
            String position = positionTextBox.Text.TrimEnd();
            String employmentType = employmentTypeTextBox.Text.TrimEnd();
            String sinNumber = SINTextBox.Text.TrimEnd();

            // Check to ensure all the fields have text
            if (firstName == "" || lastName == "" || phoneNumber == "" || email == "" || salary == "" ||
                position == "" || employmentType == "" || sinNumber == "")
            {
                resultLabel.Text = "All fields are required";
                resultLabel.ForeColor = Color.FromArgb(192, 0, 0); // dark red
                resultLabel.Visible = true;
            }
            else
            {
                resultLabel.Text = "Added successfully to the database!";
                resultLabel.ForeColor = Color.FromArgb(0, 192, 0); // Dark Green
                resultLabel.Visible = true;

                // RUN THE QUERY

                //Also put the date time value in the table
            }
        }
    }
}
