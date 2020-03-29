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
    public partial class FindVehicle : Form
    {
        public FindVehicle()
        {
            InitializeComponent();
        }

        /*
         * When search button is clicked while searching by car ID, an error check is
         * performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contain text.
         */
        private void carIDSearchButton_Click(object sender, EventArgs e)
        {
            carIDResultLabel.Visible = true;
            makeModelResultLabel.Visible = false;
            licensePlateResultLabel.Visible = false;

            String carID = carIDTextbox.Text.TrimEnd();
            if (carID == "") // If the text field is empty
            {
                carIDResultLabel.Text = "Please enter something";
                carIDResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                carIDResultLabel.Text = "Running the query . . . ";
                carIDResultLabel.ForeColor = Color.FromArgb(0, 192, 0); //dark green
                // run query
            }
        }

        /*
         * When search button is clicked while searching by model and make, an error check 
         * is performed to ensure that both fields are filled with text.
         * The search is performed from the database if both fields contain text.
         */
        private void makeModelSearchButton_Click(object sender, EventArgs e)
        {
            makeModelResultLabel.Visible = true;
            licensePlateResultLabel.Visible = false;
            carIDResultLabel.Visible = false;

            String make = makeTextBox.Text.TrimEnd();
            String model = modelTextBox.Text.TrimEnd();
            if (make == "" || model == "") // If any of the text fields are empty
            {
                makeModelResultLabel.Text = "Please search by both fields";
                makeModelResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                makeModelResultLabel.Text = "Running the query . . . ";
                makeModelResultLabel.ForeColor = Color.FromArgb(0, 192, 0); //dark green
                //run query
            }
        }
        /*
         * When search button is clicked while searching by License plate number, 
         * an error check is performed to ensure that the field is filled with text.
         * The search is performed from the database if the field contains text.
         */
        private void licensePlateSearchButton_Click(object sender, EventArgs e)
        {
            licensePlateResultLabel.Visible = true;
            makeModelResultLabel.Visible = false;
            carIDResultLabel.Visible = false;

            String licensePlate = licensePlateNumTextBox.Text.TrimEnd();
            if (licensePlate == "") // If the text field is empty
            {
                licensePlateResultLabel.Text = "Please enter something";
                licensePlateResultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                licensePlateResultLabel.Text = "Running the query . . . ";
                licensePlateResultLabel.ForeColor = Color.FromArgb(0, 192, 0); //dark green
                // run query
            }
        }
        /*
         * 
         */
        private void updateButton_Click(object sender, EventArgs e)
        {

        }
        /*
         * 
         */
        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
