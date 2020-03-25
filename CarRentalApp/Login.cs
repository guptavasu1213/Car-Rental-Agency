using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

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
            string database = Database.Connection("CRA");
            string sql = "SELECT Password FROM Customers WHERE Email = @email";

            SqlParameter pEmail = new SqlParameter("@email", inputEmail);
            SqlConnection connection = new SqlConnection(database);

            connection.Open();
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add(pEmail);

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

        private string HashPassword(string pass)
        {
            var bytes = new UTF8Encoding().GetBytes(pass);
            byte[] hashedBytes;
            using (var algorithm = new SHA256Managed())
            {
                hashedBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashedBytes);
        }

        private bool VerifyPassword(string storedPassword, string enteredPassword)
        {
            string hashedPassword = HashPassword(enteredPassword);
            if (hashedPassword == storedPassword)
            {
                return true;
            }
            return false;
        }
    }
}