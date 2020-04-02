using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CarRentalApp
{
    
    public partial class CustomerLogin : Form
    {
        Color hintColor;

        public Customer User { get; set; }

        public CustomerLogin()
        {
            InitializeComponent();
            int x = (this.Size.Width - header.Size.Width) / 2;
            int third = (this.Size.Width / 3);
            int leftAlign = third / 2 - (inputEmail.Width / 2) + 5;
            int rightAlign = third * 2;
            header.Location = new Point(x, header.Location.Y);
            inputEmail.Location = new Point(leftAlign, inputEmail.Location.Y);
            inputPassword.Location = new Point(leftAlign, inputEmail.Location.Y + 46);
            existingCxLabel.Location = new Point(leftAlign, inputEmail.Location.Y - 46);
            existingCxButton.Location = new Point(third / 2 - (existingCxButton.Width / 2) + 5, inputPassword.Location.Y + 56);
            newCxLabel.Location = new Point(rightAlign - (newCxLabel.Width/2), existingCxLabel.Location.Y);
            newCxButton.Location = new Point(newCxLabel.Location.X, newCxButton.Location.Y);
            vSeparator1.Location = new Point(third+10, vSeparator1.Location.Y);

            BDay.MinDate = new DateTime(1900, 1, 1);
            BDay.MaxDate = new DateTime(2002, 1, 1);
            BDay.Value = new DateTime(1990, 1, 1);

            hintColor = inputEmail.ForeColor;
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

        public void AddText( TextBox text, String hint, object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text.Text))
            {
                text.UseSystemPasswordChar = false;
                text.ForeColor = hintColor;
                text.Text = hint;
            }
        }

        private void inputEmail_Enter(object sender, EventArgs e)
        {
            RemoveText(inputEmail, "Email", sender, e);
        }

        private void inputEmail_Leave(object sender, EventArgs e)
        {
            AddText(inputEmail, "Email", sender, e);
        }

        private void inputPassword_Enter(object sender, EventArgs e)
        {
            RemoveText(inputPassword, "Password", sender, e);
        }

        private void inputPassword_Leave(object sender, EventArgs e)
        {
            AddText(inputPassword, "Password", sender, e);
        }

        private void fNameBox_Enter(object sender, EventArgs e)
        {
            RemoveText(fNameBox, "First Name", sender, e);
        }

        private void fNameBox_Leave(object sender, EventArgs e)
        {
            AddText(fNameBox, "First Name", sender, e);
        }

        private void lNameBox_Enter(object sender, EventArgs e)
        {
            RemoveText(lNameBox, "Last Name", sender, e);
        }

        private void lNameBox_Leave(object sender, EventArgs e)
        {
            AddText(lNameBox, "Last Name", sender, e);
        }

        private void phoneBox_Enter(object sender, EventArgs e)
        {
            RemoveText(phoneBox, "Phone Number", sender, e);
        }

        private void phoneBox_Leave(object sender, EventArgs e)
        {
            AddText(phoneBox, "Phone Number", sender, e);
        }

        private void insuranceBox_Enter(object sender, EventArgs e)
        {
            RemoveText(insuranceBox, "Insurance Number", sender, e);
        }

        private void insuranceBox_Leave(object sender, EventArgs e)
        {
            AddText(insuranceBox, "Insurance Number", sender, e);
        }

        private void driversBox_Enter(object sender, EventArgs e)
        {
            RemoveText(driversBox, "Driver's License", sender, e);
        }

        private void driversBox_Leave(object sender, EventArgs e)
        {
            AddText(driversBox, "Driver's License", sender, e);
        }

        private void EmailBox_Enter(object sender, EventArgs e)
        {
            RemoveText(EmailBox, "Email", sender, e);
        }

        private void EmailBox_Leave(object sender, EventArgs e)
        {
            AddText(EmailBox, "Email", sender, e);
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            RemoveText(passwordBox, "New Password", sender, e);
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            AddText(passwordBox, "New Password", sender, e);
            if (passwordBox.Text.Length < 8)
            {
                warningText.Text = "Warning: We recommend a longer password for security";
            }
        }

        private void confirmBox_Enter(object sender, EventArgs e)
        {
            RemoveText(confirmBox, "Confirm Password", sender, e);
        }

        private void confirmBox_Leave(object sender, EventArgs e)
        {
            AddText(confirmBox, "Confirm Password", sender, e);
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
                string query = String.Format("SELECT CUSTOMER_ID, First_Name, Membership_Status FROM Customer WHERE Email = '{0}';", email);
                DataTable table = Database.SqlQuery(query);
                this.User = new Customer();
                this.User.ID = Int32.Parse(table.Rows[0][0].ToString());
                this.User.FirstName = table.Rows[0][1].ToString();
                this.User.Status = table.Rows[0][2].ToString();


                Console.WriteLine("ID = {0}, FirstName = {1}, Status {2}", this.User.ID, this.User.FirstName, this.User.Status);

                this.Close();
            }
        }

        private void newCxButton_Click(object sender, EventArgs e)
        {
            Customer cx = new Customer();
            PhoneNumber phNum = new PhoneNumber(); // is this used anywhere?

            string email = EmailBox.Text;
            if (!Login.IsValidEmail(email))
            {
                MessageBox.Show("Error: Email address provided is invalid", "Error");
                return;
            }
            if (passwordBox.Text != confirmBox.Text)
            {
                MessageBox.Show("Error: Passwords do not match", "Error");
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
                cx.Status = "Basic";
                if (Login.insertCustomer(cx))
                {
                    MessageBox.Show("Successfully Registered as a new Customer", "Success");
                    this.DialogResult = DialogResult.OK;
                    this.User = cx;
                    this.Close();
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

        private void cityBox_Enter(object sender, EventArgs e)
        {
            RemoveText(cityBox, "City", sender, e);
        }

        private void cityBox_Leave(object sender, EventArgs e)
        {
            AddText(cityBox, "City", sender, e);
        }


        private void provinceBox_Enter(object sender, EventArgs e)
        {
            RemoveText(provinceBox, "Province", sender, e);
        }

        private void provinceBox_Leave(object sender, EventArgs e)
        {
            AddText(provinceBox, "Province", sender, e);
        }

        private void countryBox_Enter(object sender, EventArgs e)
        {
            RemoveText(countryBox, "Country", sender, e);
        }

        private void countryBox_Leave(object sender, EventArgs e)
        {
            AddText(countryBox, "Country", sender, e);
        }

        private void addressBox_Enter(object sender, EventArgs e)
        {
            RemoveText(addressBox, "Street Address", sender, e);
        }

        private void addressBox_Leave(object sender, EventArgs e)
        {
            AddText(addressBox, "Street Address", sender, e);
        }
    }
}
