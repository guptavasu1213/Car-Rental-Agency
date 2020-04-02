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
            DataTable table = Database.getDataTableAfterRunningQuery("SELECT Name FROM Branch");
            Common.fillComboBox(branchNameComboBox, "Name", table);
        }

        /*
         * When the Submit button is clicked and all entries are filled by the user, then entries are added
         * to the database
         */
        private void submitButton_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            string email = emailTextBox.Text.Trim();
            if (!Login.IsValidEmail(email))
            {
                resultLabel.Text = "Email address provided is invalid!";
                resultLabel.ForeColor = Color.FromArgb(0, 192, 0); // Dark Green
                resultLabel.Visible = true;
            }
            if (passwordBox.Text != confirmBox.Text)
            {
                resultLabel.Text = "Passwords do not match!";
                resultLabel.ForeColor = Color.FromArgb(0, 192, 0); // Dark Green
                resultLabel.Visible = true;
            }
            // If any text field is empty or nothing is selected in the drop down list
            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || phoneNumberTextBox.Text == "" || email == "" || salaryTextBox.Text == "" ||
                positionTextBox.Text == "" || employmentTypeTextBox.Text == "" || SINTextBox.Text == "" || branchNameComboBox.SelectedIndex == -1)
            {
                resultLabel.Text = "All fields are required";
                resultLabel.ForeColor = Color.FromArgb(192, 0, 0); // Dark Red
                resultLabel.Visible = true;
            }
            // Use try-catch in case the values are not going to be compatible (ie. letters entered in Age)
            try
            {
                emp.FirstName = firstNameTextBox.Text.Trim();
                emp.LastName = lastNameTextBox.Text.Trim();
                emp.BDay = dateOfBirthPicker.Value.ToShortDateString();
                emp.PhoneNumber = Decimal.Parse(phoneNumberTextBox.Text);
                emp.EmailAddress = email;
                emp.Password = Login.HashPassword(confirmBox.Text.Trim());
                emp.Address = addressBox.Text.Trim();
                emp.City = cityBox.Text.Trim();
                emp.Province = provinceBox.Text.Trim();
                emp.Country = countryBox.Text.Trim();
                emp.Salary = Decimal.Parse(salaryTextBox.Text.Trim());
                emp.EmploymentType = employmentTypeTextBox.Text.Trim();
                emp.SIN = Int32.Parse(SINTextBox.Text.Trim());
                emp.Position = positionTextBox.Text.Trim();
                emp.Branch = branchNameComboBox.GetItemText(branchNameComboBox.SelectedItem);
                if (Login.insertEmployee(emp))
                {
                    resultLabel.Text = "Added new Employee successfully to the database!";
                    resultLabel.ForeColor = Color.FromArgb(0, 192, 0); // Dark Green
                    resultLabel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        /*
         * Allowing only numerical values for Phone Number
         */
        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void salaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
