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
    public partial class FindBooking : Form
    {
        public FindBooking()
        {
            InitializeComponent();
        }
        /*
         * When search button is clicked while searching for all transactions by customer ID,
         * an error check is performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
         */
        private void customerIDSearchButton_Click(object sender, EventArgs e)
        {
            branchIDResultLabel.Visible = false;
            customerIDResultLabel.Visible = true;

            String customerID = customerIDTextbox.Text.TrimEnd();
            if (customerID == "") // If the text field is empty
            {
                customerIDResultLabel.Text = "Please enter something";
                customerIDResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                customerIDResultLabel.Text = "Searching for all transactions\nby customer #" + customerID;
                customerIDResultLabel.ForeColor = Color.FromArgb(0, 192, 0); //dark green
                // run query
            }
        }
        /*
         * When search button is clicked while searching for all transactions by branch ID,
         * an error check is performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
         */
        private void branchIDSearchButton_Click(object sender, EventArgs e)
        {
            branchIDResultLabel.Visible = true;
            customerIDResultLabel.Visible = false;

            String branchID = branchIDTextBox.Text.TrimEnd();
            if (branchID == "") // If the text field is empty
            {
                branchIDResultLabel.Text = "Please enter something";
                branchIDResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                branchIDResultLabel.Text = "Searching for all transactions\nby Branch #" + branchID;
                branchIDResultLabel.ForeColor = Color.FromArgb(0, 192, 0); //dark green
                // run query
            }

        }
        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
