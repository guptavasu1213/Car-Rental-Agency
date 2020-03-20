using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRentalApp
{
    internal class Login
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static void CustomerAuth(string inputEmail, string inputPassword)
        {
            string database = "DATABASE CONNECTION STRING -- UPDATE LATER";
            string sql = "SELECT * FROM Customers WHERE Email = @email AND Password = @pass";

            SqlParameter pEmail = new SqlParameter("@email", inputEmail);
            SqlParameter pPass = new SqlParameter("@pass", inputPassword);
            SqlConnection connection = new SqlConnection(database);

            connection.Open();
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add(pEmail);
            cmd.Parameters.Add(pPass);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    // sign in successful?
                    Console.WriteLine("Log in was successful");
                }
                else
                {
                    Console.WriteLine("Log in failed");
                }
            }
        }
    }
}