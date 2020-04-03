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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        /* 
         * Validates username and password in the database.
         * Returns True when username and password are found. False when no such entry in the database
         */
        private bool Validate_Password(String username, String password)
        {
            string emailQuery = $"select Password from Employee where Email = '{username}';";
            DataTable resultTable = Database.getDataTableAfterRunningQuery(emailQuery);

            // To check if the email exists
            // If: Resulting table after the query is empty
            if (resultTable.Rows.Count == 0)
            {
                MessageBox.Show("Incorrect Email!");
            }
            // Else: Valid email
            else
            {   // Computing the hash of user entered password 
                string userPassHash = Login.HashPassword(password);
                string correctPassHash = resultTable.Rows[0]["Password"].ToString();

                // Comparing the user entered password hash with the hash stored in the database
                if (userPassHash == correctPassHash) { return true; }
                else { MessageBox.Show("Incorrect Password!"); }
            }
            return false; 
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            String username = username_field.Text;
            String password = password_field.Text;

            // Validating the username and password
            if (Validate_Password(username, password))
            {   // Opening the Admin Portal
                AdminPortal adminPortal = new AdminPortal();
                this.Hide();
                adminPortal.Show();
                this.Close();
            }
        }
    }
}
