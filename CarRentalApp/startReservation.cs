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
    public partial class StartReservation : Form
    {
        public StartReservation()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pickupLocation = textBox1.Text;
            string returnLocation = textBox2.Text;
            string pickupDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string pickupTime = dateTimePicker1.Value.ToString("hh:ss tt");
            string returnDate = dateTimePicker2.Value.ToString("dd-MM-yyyy");
            string returnTime = dateTimePicker2.Value.ToString("hh:ss tt");
            string renterAge = textBox3.Text;
            string promotionCode = textBox4.Text;
            Boolean carsChecked = checkBox1.Checked;
            Boolean suvsChecked = checkBox2.Checked;
            Boolean trucksCehcked = checkBox3.Checked;
            Boolean vansChecked = checkBox4.Checked;
            Boolean twoChecked = checkBox5.Checked;
            Boolean fourChecked = checkBox6.Checked;
            Boolean fiveChecked = checkBox7.Checked;
            Boolean sevenChecked = checkBox8.Checked;
            Boolean eightChecked = checkBox9.Checked;
            string summary = "You are looking to go from " + pickupLocation + " to " + returnLocation + "\n" +
                "Your pickup date and time is: " + pickupDate + " " + pickupTime + "\n" +
                "Your return date and time is: " + returnDate + " " + returnTime + "\n";


            label10.Text = summary;


        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
