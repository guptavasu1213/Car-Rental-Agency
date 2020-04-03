using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRentalApp
{
    public static class Database
    {
        private static readonly string cString = "Data Source=142.59.80.79,5291; Initial Catalog=CRA291; User ID=SA; Password=@291CRAsql$";

        public static string ConnectionString { get { return cString; } }

        // SAME as getDataTableAfterRunningQuery()
        public static DataTable SqlQuery(string query)
        {
            SqlConnection connection = new SqlConnection(Database.ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);

            connection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            connection.Close();

            return table;
        }

        /*
         * Runs the query passed to the function to communicate with the current database
         */
        public static void runQuery(String query)
        {
            // Connection string
            string connectionString = Database.ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                // Creates your command with the query
                SqlCommand command = new SqlCommand(query, sqlCon);

                // Command execution
                SqlDataReader reader = command.ExecuteReader();
            }
        }

        /*
         * Returns back the Data table after connecting to the database and running the query 
         * passed a parameter to the function.
         */
        public static DataTable getDataTableAfterRunningQuery(String query)
        {
            // Connection string
            string connectionString = Database.ConnectionString;

            // Creating a data table
            DataTable table = new DataTable();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                // Creates your command with the query
                SqlCommand command = new SqlCommand(query, sqlCon);

                // Command execution
                SqlDataReader reader = command.ExecuteReader();

                // Loading the data table with the query result 
                table.Load(reader);
            }
            return table;
        }


        public static void SqlInsert(string query)
        {
            SqlDataReader dataReader;
            SqlCommand cmd;
            SqlConnection connection = new SqlConnection(Database.ConnectionString);

            try
            {
                connection.Open();
                cmd = new SqlCommand(query, connection);

                dataReader = cmd.ExecuteReader();
                while (dataReader.Read()) { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
