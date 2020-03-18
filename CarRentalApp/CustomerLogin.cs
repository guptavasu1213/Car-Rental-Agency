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
            header.Location = new Point(x, header.Location.Y);
            inputEmail.Location = new Point(x, header.Location.Y + 70);
            inputPassword.Location = new Point(x, inputEmail.Location.Y + inputEmail.Size.Height + 20);

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
    }
}
