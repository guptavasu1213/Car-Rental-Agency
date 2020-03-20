﻿using System;
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
        public Main()
        {
            InitializeComponent();
            this.Text = "Car Rental Agency";
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
            customerLogin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startReservation startreservation = new startReservation();
            startreservation.ShowDialog();
        }
    }
}