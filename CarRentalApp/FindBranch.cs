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
    public partial class FindBranch : Form
    {
        public FindBranch()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        /*
         * When search button is clicked while searching for all branches by branch ID,
         * an error check is performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
         */
        private void branchIDSearchButton_Click(object sender, EventArgs e)
        {
            branchIDResultLabel.Visible = true;
            branchNameResultLabel.Visible = false;

            String branchID = branchIDTextbox.Text.TrimEnd();
            if (branchID == "") // If the text field is empty
            {
                branchIDResultLabel.Text = "Please enter something";
                branchIDResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                branchIDResultLabel.Text = "Running the query . . . ";
                branchIDResultLabel.ForeColor = Color.FromArgb(0, 192, 0); //dark green
                // run query
            }

        }
        /*
         * When search button is clicked while searching for all branches by Names,
         * an error check is performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
         */
        private void branchNameSearchButton_Click(object sender, EventArgs e)
        {
            branchIDResultLabel.Visible = false;
            branchNameResultLabel.Visible = true;

            String branchName = branchNameTextBox.Text.TrimEnd();
            if (branchName == "") // If the text field is empty
            {
                branchNameResultLabel.Text = "Please enter something";
                branchNameResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                branchNameResultLabel.Text = "Running the query . . . ";
                branchNameResultLabel.ForeColor = Color.FromArgb(0, 192, 0); //dark green
                // run query
            }
        }
    }
}
