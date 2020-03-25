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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /* 
         * Validates username and password in the database.
         * Returns True when username and password are found. False when no such entry in the database
         */
        private bool Validate_Password(String username, String password)
        {
            if (username == "291" && password == "Win")
            {
                return true;
            }
            return false;
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            String username = username_field.Text;
            String password = password_field.Text;

            if (Validate_Password(username, password))
            {
                //    admin_login_result_label.Text = "Correct Password! Yayy!";
                //    admin_login_result_label.ForeColor = Color.ForestGreen;
                //    admin_login_result_label.Visible = true;

                AdminPortal adminPortal = new AdminPortal();
                this.Hide();
                adminPortal.Show();
            }
            else
            {
                admin_login_result_label.Text = "Error: Incorrect username or password.";
                admin_login_result_label.Visible = true;
                admin_login_result_label.ForeColor = Color.Red;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
