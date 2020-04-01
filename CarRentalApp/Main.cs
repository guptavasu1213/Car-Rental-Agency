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
    public partial class Main : Form
    {
        private Customer User;
        private bool loggedIn;

        public Main()
        {
            InitializeComponent();
            this.Text = "Car Rental Agency";
            label2.Text = "Welcome, Guest!";
            loggedIn = false;
        }

        public void UpdateUser(Customer cx)
        {
            this.User = cx;
            label2.Text = "Welcome, " + User.FirstName + "!";
            loggedIn = true;
            button1.Text = "Log Out";
        }

        private void nameTextBoxLeave(object sender, EventArgs e)
        {
            //inputName.Text = "Full Name";
            //inputName.ForeColor = Color.Silver;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (loggedIn)
            {
                this.User = null;
                this.loggedIn = false;
                label2.Text = "Welcome, Guest!";
                button1.Text = "Login for a Customized Solution";
            }
            else
            {
                CustomerLogin customerLogin = new CustomerLogin();
                var result = customerLogin.ShowDialog();
                if (result == DialogResult.OK)
                    UpdateUser(customerLogin.User);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartReservation startreservation = new StartReservation(this.User);
            this.Opacity = 0.0;
            startreservation.ShowDialog();
            this.Opacity = 100.0;
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            this.Hide(); // Hiding this window if we want come back to it
            adminLogin.Show();
        }
    }
}
