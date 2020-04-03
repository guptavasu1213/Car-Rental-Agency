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
    public partial class PopularBranch : Form
    {
        public PopularBranch()
        {
            InitializeComponent();
        }

        /*
         * Error checks for the number of entries entered by the user. 
         * If the user enters in only one text field, then the function returns true
         * If the user enters nothing, the function returns false.
         * If the user enters in more than one text field the function returns false.
         */
        private bool errorCheckSpecificFields()
        {
            // If all fields are empty
            if (cityTextBox.Text.TrimEnd() == "" && provinceTextBox.Text.TrimEnd() == "" && 
                countryTextBox.Text.TrimEnd() == "")
            {
                specificSearchErrorLabel.Text = "Error: Please search by one parameter";
                return false;
            }
            // Counting the number of empty fields and if there are less than 2 empty fields,
            // the function returns false
            int count = 0;

            if (cityTextBox.Text.TrimEnd() == "") { count++; }
            if (provinceTextBox.Text.TrimEnd() == "") { count++; }
            if (countryTextBox.Text.TrimEnd() == "") { count++; }

            if (count < 2)
            {
                specificSearchErrorLabel.Text = "Error: Please search by only one parameter";
                return false;
            }
            return true;
        }
        /*
         * Returns query for finding all the top branches based on number of successful transactions and the parameters entered by the user
         */
        private string getTextBoxQuery(string searchParameter)
        {
            return 
            "select Branch.BRANCH_ID, Branch.Name, temp.TransactionCount, Branch.Street_Address, Branch.City, Branch.Province, Branch.Country" +
            " from Branch, " +
                    "(select Branch.BRANCH_ID, count(*) as 'TransactionCount' " +
                    "from [Transaction], Branch " +
                    "where [Transaction].PICKUP_BRANCH_ID = Branch.BRANCH_ID and[Transaction].Status = 'Success' " +
                            $"and {searchParameter} " +
                    "group by Branch.BRANCH_ID) as temp " +
            "where Branch.BRANCH_ID = temp.BRANCH_ID " +
            "order by temp.TransactionCount DESC;";
        }
        /*
         * When the admin searches for the most popular branch for a specific:
         * - City
         * - Province
         * - Country
         * The search only takes place by one text field. The function reports an error if the user 
         * enters in more than one text field.
         */
        private void searchSpecificButton_Click(object sender, EventArgs e)
        {
            everySearchErrorLabel.Visible = false; // Making the error label for every search invisible
            specificSearchErrorLabel.Visible = true; // Making the error label for specific search invisible
            string query;

            if (!errorCheckSpecificFields()) // Error checking for invalid number of input entries
            {
                specificSearchErrorLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
                return;
            } 

            if (cityTextBox.Text.TrimEnd() != "")
            {
                // query by city name
                // Finding all the transaction counts for the cities with the given name.
                query = getTextBoxQuery($"Branch.City = '{cityTextBox.Text.TrimEnd()}'");
            }
            else if (provinceTextBox.Text.TrimEnd() != "")
            {
                // query by province name
                // Finding all the transaction counts for the provinces with the given name.
                query = getTextBoxQuery($"Branch.Province = '{provinceTextBox.Text.TrimEnd()}'");
            }
            else if (countryTextBox.Text.TrimEnd() != "")
            {
                // query by country name
                // Finding all the transaction counts for the country with the given name.
                query = getTextBoxQuery($"Branch.Country = '{countryTextBox.Text.TrimEnd()}'");
            }
            else { return; }
            // Run query and update the table
            Common.validTextboxEntry(specificSearchErrorLabel, query, popularBranchesDataGridView);
        }
        /*
         * When a admin searches for the most popular branchs for
         * - Each City or 
         * - Each Province or 
         * - Each Country
         */
        private void searchEveryButton_Click(object sender, EventArgs e)
        {
            specificSearchErrorLabel.Visible = false; // Making the error label for specific search invisible

           if (cityRadio.Checked)
            {
                cityRadio.Checked = false; // Uncheck the button after the search
                everySearchErrorLabel.Visible = false;

                //run all cities query
            }
            else if (provinceRadio.Checked)
            {
                provinceRadio.Checked = false; // Uncheck the button after the search
                everySearchErrorLabel.Visible = false;

                //run all provinces query
            }
            else if (countryRadio.Checked)
            {
                countryRadio.Checked = false;// Uncheck the button after the search
                everySearchErrorLabel.Visible = false;

                //run all countries query
            }
            else
            {
                // You need to select an option
                everySearchErrorLabel.Visible = true;
            }
        }
    }
}
