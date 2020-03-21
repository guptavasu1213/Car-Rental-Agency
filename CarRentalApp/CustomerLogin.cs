using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRentalApp
{
    
    public partial class CustomerLogin : Form
    {
        Color hintColor;

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

        private void ageBox_Enter(object sender, EventArgs e)
        {
            RemoveText(ageBox, "Age", sender, e);
        }

        private void ageBox_Leave(object sender, EventArgs e)
        {
            AddText(ageBox, "Age", sender, e);
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
            RemoveText(driversBox, "Driver's License Class", sender, e);
        }

        private void driversBox_Leave(object sender, EventArgs e)
        {
            AddText(driversBox, "Driver's License Class", sender, e);
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

            Login.CustomerAuth(email, pass);
        }
    }
}
