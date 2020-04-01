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

        public Main()
        {
            InitializeComponent();
            this.Text = "Car Rental Agency";
            label2.Text = "Welcome, Guest!";
            
        }

        public void UpdateUser(Customer cx)
        {
            this.User = cx;
            label2.Text = "Welcome, " + User.FirstName + "!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "Hi " + inputName.Text + "!";
        }

        private void nameTextBoxEnter(object sender, EventArgs e)
        {
            if (inputName.Text == "Enter your name")
            {
                inputName.Text = "";
                inputName.ForeColor = Color.Black;
            } 
}

        private void nameTextBoxLeave(object sender, EventArgs e)
        {
            //inputName.Text = "Full Name";
            //inputName.ForeColor = Color.Silver;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CustomerLogin customerLogin = new CustomerLogin();
            var result = customerLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                UpdateUser(customerLogin.User);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartReservation startreservation = new StartReservation();
            startreservation.ShowDialog();
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            this.Hide(); // Hiding this window if we want come back to it
            adminLogin.Show();
        }
    }
}
