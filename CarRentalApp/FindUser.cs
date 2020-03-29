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
    public partial class FindUser : Form
    {
        public FindUser()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

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
         * When search button is clicked while searching by customer ID, an error check is
         * performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
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
                customerIDResultLabel.Text = "Running the query . . . ";
                customerIDResultLabel.ForeColor = Color.FromArgb(0, 192, 0); //dark green
                // run query
            }

        }

        /*
         * When search button is clicked while searching by name, an error check is
         * performed to ensure that both fields are filled with text.
         * The search is performed from the database if both fields contain text.
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
                nameResultLabel.Text = "Running the query . . . ";
                nameResultLabel.ForeColor = Color.FromArgb(0, 192, 0); //dark green
                //run query
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
                phoneNumResultLabel.Text = "Running the query . . . ";
                phoneNumResultLabel.ForeColor = Color.FromArgb(0, 192, 0); //dark green
                // run query
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
                emailResultLabel.Text = "Running the query . . . ";
                emailResultLabel.ForeColor = Color.FromArgb(0, 192, 0); //dark green
                // run query
            }
        }
        /*
         * 
         */
        private void updateButton_Click(object sender, EventArgs e)
        {

        }
        /*
         * 
         */
        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

    }
}
