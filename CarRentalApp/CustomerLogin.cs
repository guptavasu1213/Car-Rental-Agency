using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRentalApp
{
    
    public partial class CustomerLogin : Form
    {
        private static String database = "server=cra291.database.windows.net;database=cra291;UID=server_login;password=1234";
        private SqlConnection connection = new SqlConnection(database);
        Color hintColor;

        public CustomerLogin()
        {
            InitializeComponent();
            int x = (this.Size.Width - header.Size.Width) / 2;
            int third = (this.Size.Width / 3);
            header.Location = new Point(x, header.Location.Y);
            //inputEmail.Location = new Point(x, header.Location.Y + 70);
            //inputPassword.Location = new Point(x, inputEmail.Location.Y + inputEmail.Size.Height + 20);
            vSeparator1.Location = new Point(third, vSeparator1.Location.Y);

            hintColor = inputEmail.ForeColor;
        }

        public void RemoveText(TextBox text, object sender, EventArgs e)
        {
            if (text.Text != "")
            {
                text.Text = "";
            }
            text.ForeColor = Color.Black;
        }

        public void AddText( TextBox text, String hint, object sender, EventArgs e)
        {
            text.ForeColor = hintColor;
            if (string.IsNullOrWhiteSpace(text.Text))
                text.Text = hint;
        }

        private void inputEmail_Enter(object sender, EventArgs e)
        {
            RemoveText(inputEmail, sender, e);
        }

        private void inputEmail_Leave(object sender, EventArgs e)
        {
            AddText(inputEmail, "Email...", sender, e);
        }

        private void inputPassword_Enter(object sender, EventArgs e)
        {
            RemoveText(inputPassword, sender, e);
        }

        private void inputPassword_Leave(object sender, EventArgs e)
        {
            AddText(inputPassword, "Password...", sender, e);
        }

        private void fNameBox_Enter(object sender, EventArgs e)
        {
            RemoveText(fNameBox, sender, e);
        }

        private void fNameBox_Leave(object sender, EventArgs e)
        {
            AddText(fNameBox, "First Name...", sender, e);
        }

        private void lNameBox_Enter(object sender, EventArgs e)
        {
            RemoveText(lNameBox, sender, e);
        }

        private void lNameBox_Leave(object sender, EventArgs e)
        {
            AddText(lNameBox, "Last Name...", sender, e);
        }

        private void phoneBox_Enter(object sender, EventArgs e)
        {
            RemoveText(phoneBox, sender, e);
        }

        private void phoneBox_Leave(object sender, EventArgs e)
        {
            AddText(phoneBox, "Phone Number...", sender, e);
        }

        private void ageBox_Enter(object sender, EventArgs e)
        {
            RemoveText(ageBox, sender, e);
        }

        private void ageBox_Leave(object sender, EventArgs e)
        {
            AddText(ageBox, "Age...", sender, e);
        }

        private void insuranceBox_Enter(object sender, EventArgs e)
        {
            RemoveText(insuranceBox, sender, e);
        }

        private void insuranceBox_Leave(object sender, EventArgs e)
        {
            AddText(insuranceBox, "Insurance Number...", sender, e);
        }

        private void driversBox_Enter(object sender, EventArgs e)
        {
            RemoveText(driversBox, sender, e);
        }

        private void driversBox_Leave(object sender, EventArgs e)
        {
            AddText(driversBox, "Driver's License Class...", sender, e);
        }

        private void EmailBox_Enter(object sender, EventArgs e)
        {
            RemoveText(EmailBox, sender, e);
        }

        private void EmailBox_Leave(object sender, EventArgs e)
        {
            AddText(EmailBox, "Email...", sender, e);
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            RemoveText(passwordBox, sender, e);
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            AddText(passwordBox, "Password...", sender, e);
        }

        private void confirmBox_Enter(object sender, EventArgs e)
        {
            RemoveText(confirmBox, sender, e);
        }

        private void confirmBox_Leave(object sender, EventArgs e)
        {
            AddText(confirmBox, "Confirm Password...", sender, e);
        }
    }
}
