using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    class Common
    {

        /*
         * The function is called when the entry in the textbox is valid
         * PURPOSE:
         * - Changing the label to success
         * - Running the query
         * - If there is no entry found, the error message is displayed
         * - Else the table is updated
         */
        public static void validTextboxEntry(Label label, String query, DataGridView dataGridView)
        {
            // Changing the result label
            label.Text = "Running the query . . . ";
            label.ForeColor = Color.FromArgb(0, 192, 0); //dark green

            // fill the table with the value retrieved
            DataTable table = Database.getDataTableAfterRunningQuery(query);
            // If: Resulting table after the query is empty
            if (table.Rows.Count == 0)
            {
                dataGridView.DataSource = null; // Make table empty
                MessageBox.Show("No such entry found in the database!");
            }
            // Else: Populating the table with the query result
            else { dataGridView.DataSource = table; }
        }
        /*
         * Fills the comboBox with the values in the DataTable
         */
        public static void fillComboBox(ComboBox cb, string colName, DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string val = table.Rows[i][colName].ToString();
                cb.Items.Add(val);
            }
        }
    }
}
