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
        private static readonly string cString = "Data Source=\"142.59.80.79, 5291\";Initial Catalog=CRA291;Persist Security Info=True;User ID=SA";

        public static string ConnectionString { get { return cString; } }

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
