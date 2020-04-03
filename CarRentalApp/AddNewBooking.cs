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
    public partial class AddNewBooking : Form
    {
        public AddNewBooking()
        {
            InitializeComponent();
        }

        /*
         * When submit button is clicked, the mandatory fields are checked if they are filled.
         * If all the mandatory fields are selected, then we check for all the optional fields 
         * and make the queries as per the condition.
         */
        private void submitButton_Click(object sender, EventArgs e)
        {
            resultLabel.Visible = true;

            String customerID = customerIDTextBox.Text.TrimEnd(); // Value in textbox
            if (customerID == "") // If the text field is empty
            {
                resultLabel.Text = "Please enter something";
                resultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Changing the result label
                resultLabel.Text = "Running the query . . . ";
                resultLabel.ForeColor = Color.FromArgb(0, 192, 0); //dark green

                // Creating the query
                String query = $"select CUSTOMER_ID, First_Name, Membership_Status, Card_Type, Card_Number from Customer where CUSTOMER_ID = '{customerID}'";
                // Runs query and updates table
                DataTable table = Database.getDataTableAfterRunningQuery(query);

                Customer user;

                user = new Customer();
                user.ID = Int32.Parse(table.Rows[0][0].ToString());
                user.FirstName = table.Rows[0][1].ToString();
                user.Status = table.Rows[0][2].ToString();
                user.cardType = table.Rows[0][3].ToString();
                user.cardNumber = table.Rows[0][4].ToString();

                StartReservation startreservation = new StartReservation(user);
                startreservation.ShowDialog();

            }
        }
    }
}

//// Load user details from database
//string query = String.Format("SELECT CUSTOMER_ID, First_Name, Membership_Status, Card_Type, Card_Number FROM Customer WHERE Email = '{0}';", email);
//DataTable table = Database.SqlQuery(query);
//                this.User = new Customer();
//                this.User.ID = Int32.Parse(table.Rows[0][0].ToString());
//                this.User.FirstName = table.Rows[0][1].ToString();
//                this.User.Status = table.Rows[0][2].ToString();
//                this.User.cardType = table.Rows[0][3].ToString();
//                this.User.cardNumber = table.Rows[0][4].ToString();

//                Console.WriteLine("" +
//                    "ID = {0}, " +
//                    "FirstName = {1}, " +
//                    "Status = {2}, " +
//                    "Card Type = {3}, " +
//                    "Card Number = {4}",
//                    this.User.ID,
//                    this.User.FirstName,
//                    this.User.Status,
//                    this.User.cardType,
//                    this.User.cardNumber);

//                this.Close();

//StartReservation startreservation = new StartReservation(this.User);
//                this.Opacity = 0.0;
//                startreservation.ShowDialog();
//                this.Opacity = 100.0;

