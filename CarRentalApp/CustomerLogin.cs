using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace CarRentalApp
{
    
    public partial class CustomerLogin : Form
    {
        public Customer User { get; set; }

        public CustomerLogin()
        {
            InitializeComponent();

            BDay.MinDate = new DateTime(1900, 1, 1);
            BDay.MaxDate = new DateTime(2002, 1, 1);
            BDay.Value = new DateTime(1990, 1, 1);
        }

        public void RemoveText(TextBox text, String hint, object sender, EventArgs e)
        {
            if (text.Text == hint)
            {
                if (hint.ToUpper().Contains("PASSWORD"))
                {
                    text.UseSystemPasswordChar = true;
                }
                text.Text = "";
            }
            text.ForeColor = Color.Black;
        }

        private void existingCxButton_Click(object sender, EventArgs e)
        {
            string email = inputEmail.Text;
            if (!Login.IsValidEmail(email))
            {
                MessageBox.Show("Error: Email address provided is invalid", "Error");
                return;
            }
            string pass = inputPassword.Text;

            if (Login.CustomerAuth(email, pass))
            {
                this.DialogResult = DialogResult.OK;

                // Load user details from database
                string query = String.Format("SELECT CUSTOMER_ID, First_Name, Membership_Status, Card_Type, Card_Number FROM Customer WHERE Email = '{0}';", email);
                DataTable table = Database.SqlQuery(query);
                this.User = new Customer();
                this.User.ID = Int32.Parse(table.Rows[0][0].ToString());
                this.User.FirstName = table.Rows[0][1].ToString();
                this.User.Status = table.Rows[0][2].ToString();
                this.User.cardType = table.Rows[0][3].ToString();
                this.User.cardNumber = table.Rows[0][4].ToString();

                Console.WriteLine("" +
                    "ID = {0}, " +
                    "FirstName = {1}, " +
                    "Status = {2}, " +
                    "Card Type = {3}, " +
                    "Card Number = {4}", 
                    this.User.ID, 
                    this.User.FirstName, 
                    this.User.Status,
                    this.User.cardType,
                    this.User.cardNumber);

                this.Close();

                StartReservation startreservation = new StartReservation(this.User);
                this.Opacity = 0.0;
                startreservation.ShowDialog();
                this.Opacity = 100.0;

            }
        }

        private void newCxButton_Click(object sender, EventArgs e)
        {
            Customer cx = new Customer();

            string email = EmailBox.Text.Trim();
            if (!Login.IsValidEmail(email))
            {
                MessageBox.Show("Error: Email address provided is invalid", "Password Error");
                return;
            }
            if (passwordBox.Text != confirmBox.Text)
            {
                MessageBox.Show("Error: Passwords do not match", "Password Error");
                return;
            }

            Match match = Regex.Match(cardNoBox.Text, @"[0-9]{16}");

            if (!match.Success)
            {
                MessageBox.Show("Error: Card number should be 16 numeric digits", "Invalid Card");
                return;
            }

            if (cardTypeCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a credit card type", "Error");
                return;
            }

            // Use try-catch in case the values are not going to be compatible (ie. letters entered in Age)
            try
            {
                cx.FirstName = fNameBox.Text.Trim();
                cx.LastName = lNameBox.Text.Trim();
                cx.BDay = BDay.Value.ToShortDateString();
                cx.Insurance = insuranceBox.Text.Trim();
                cx.Drivers = driversBox.Text.Trim();
                cx.PhoneNumber = Decimal.Parse(phoneBox.Text);
                cx.EmailAddress = email;
                cx.Password = Login.HashPassword(confirmBox.Text.Trim());
                cx.Address = addressBox.Text.Trim();
                cx.City = cityBox.Text.Trim();
                cx.Province = provinceBox.Text.Trim();
                cx.Country = countryBox.Text.Trim();
                cx.CardNumber = cardNoBox.Text;
                cx.CardType = cardTypeCombo.GetItemText(cardTypeCombo.SelectedItem);
                cx.Status = "Basic";
                if (Login.insertCustomer(cx))
                {
                    MessageBox.Show("Successfully Registered as a new Customer", "Success");
                    this.DialogResult = DialogResult.OK;
                    this.User = cx;
                    this.Close();

                    StartReservation startreservation = new StartReservation(this.User);
                    this.Opacity = 0.0;
                    startreservation.ShowDialog();
                    this.Opacity = 100.0;
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
        private void allowOnlyNumericalValues(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
