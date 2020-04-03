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
    public partial class TopEmployees : Form
    {
        public TopEmployees()
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
            if (branchTextBox.Text.TrimEnd() == "" && cityTextBox.Text.TrimEnd() == "" &&
                    provinceTextBox.Text.TrimEnd() == "" && countryTextBox.Text.TrimEnd() == "")
            {
                specificSearchErrorLabel.Text = "Error: Please search by one parameter";
                specificSearchErrorLabel.Visible = true;
                return false;
            }
            // Counting the number of empty fields and if there are less than 3 empty fields,
            // the function returns false
            int count = 0;

            if (branchTextBox.Text.TrimEnd() == "") { count++; }
            if (cityTextBox.Text.TrimEnd() == "") { count++; }
            if (provinceTextBox.Text.TrimEnd() == "") { count++; }
            if (countryTextBox.Text.TrimEnd() == "") { count++; }

            if (count < 3)
            {
                specificSearchErrorLabel.Text = "Error: Please search by only one parameter";
                specificSearchErrorLabel.Visible = true;
                return false;
            }
            return true;
        }
        /*
         * Getting the query to get the list of employees with most number of successful transactions and the parameter passed
         */
        private string getTextBoxQuery(string parameter)
        {
            return
                "select Employee.EMPLOYEE_ID, Employee.First_Name, Employee.Last_Name, Employee.Email, temp.TransactionCount " +
                "from Employee, " +
                    "(select Employee.EMPLOYEE_ID, count(*) as 'TransactionCount' " +
                    "from [Transaction], Branch, Employee " +
                    "where [Transaction].PICKUP_BRANCH_ID = Branch.BRANCH_ID and " +
                    "[Transaction].PICKUP_EMPLOYEE_ID = Employee.EMPLOYEE_ID and " +
                    "[Transaction].Status = 'Success' and " +
                    $"{parameter} " +
                    "group by Employee.EMPLOYEE_ID) as temp " +
                "where Employee.EMPLOYEE_ID = temp.EMPLOYEE_ID " +
                "order by temp.TransactionCount DESC;";
        }

        /*
         * When the admin searches for the most popular car for a specific:
         * - Branch
         * - City
         * - Province
         * - Country
         * The search only takes place by one text field. The function reports an error if the user 
         * enters in more than one text field.
         */
        private void searchSpecificButton_Click(object sender, EventArgs e)
        {
            specificSearchErrorLabel.Visible = true; // Making the error label for specific search invisible
            string query;

            if (!errorCheckSpecificFields()) // Error checking for invalid number of input entries
            {
                specificSearchErrorLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
                return;
            }

            if (branchTextBox.Text.TrimEnd() != "")
            {
                // query by the branch name
                query = getTextBoxQuery($"Branch.Name = '{branchTextBox.Text.TrimEnd()}'");
            }
            else if (cityTextBox.Text.TrimEnd() != "")
            {
                // query by city name
                query = getTextBoxQuery($"Branch.City = '{cityTextBox.Text.TrimEnd()}'");
            }
            else if (provinceTextBox.Text.TrimEnd() != "")
            {
                // query by province name
                query = getTextBoxQuery($"Branch.Province = '{provinceTextBox.Text.TrimEnd()}'");
            }
            else if (countryTextBox.Text.TrimEnd() != "")
            {
                // query by country name
                query = getTextBoxQuery($"Branch.Country = '{countryTextBox.Text.TrimEnd()}'");
            }
            else { return; }
            // Run query and update the table
            Common.validTextboxEntry(specificSearchErrorLabel, query, topEmployeeDataGridView);
        }
    }
}
