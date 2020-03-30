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
    public partial class FindVehicleType : Form
    {
        public FindVehicleType()
        {
            InitializeComponent();
        }
        /*
         * When search button is clicked while searching by type Name, an error check is
         * performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
         */
        private void typeSearchButton_Click(object sender, EventArgs e)
        {
            typeResultLabel.Visible = true;
            branchNameResultLabel.Visible = false;

            String typeName = typeTextbox.Text.TrimEnd();
            if (typeName == "") // If the text field is empty
            {
                typeResultLabel.Text = "Please enter something";
                typeResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                typeResultLabel.Text = "Running the query . . . ";
                typeResultLabel.ForeColor = Color.FromArgb(0, 192, 0); //dark green
                // run query
            }

        }
        /*
         * When search button is clicked while searching for type names at a particular
         * branch, an error check is performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
         */
        private void branchNameSearchButton_Click(object sender, EventArgs e)
        {
            typeResultLabel.Visible = false;
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

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
