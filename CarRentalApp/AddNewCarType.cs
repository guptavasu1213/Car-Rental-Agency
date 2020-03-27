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
    public partial class AddNewCarType : Form
    {
        public AddNewCarType()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }
        /*
         * The function checks if the user entered value is a number (integer, or a float).
         * The digit is not typed in the textbox if the digit is not an integer or a float
         */
        private void checkForANumber(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
