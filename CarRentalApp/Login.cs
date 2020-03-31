using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Data;

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
            string database = Database.ConnectionString;
            string sql = "SELECT Password FROM Customer WHERE Email = @email";

            SqlParameter pEmail = new SqlParameter("@email", inputEmail);
            SqlConnection connection = new SqlConnection(database);

            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.Add(pEmail);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    // sign in successful?
                    MessageBox.Show("Successful Sign In", "Success");
                    Console.WriteLine("Log in was successful");
                }
                else
                {
                    MessageBox.Show("Invalid Username and/or Password", "Invalid");
                    Console.WriteLine("Log in failed");
                }
            }

            connection.Close();
        }

        public static bool insertCustomer(Customer cx)
        {
            string dbstring = Database.ConnectionString;
            string sql = "INSERT INTO Customer (First_Name, Last_Name, Phone_Number, Email, Birthday, Insurance_Policy_Number, Drivers_License, Password, Street_Address, City, Province, Country, Membership_Status) ";
            string values = "VALUES (@fname, @lname, @phone, @email, @bday, @insurance, @license, @password, @address, @city, @province, @country, @status)";
            string insertvals = sql + values;

            using (SqlConnection connection = new SqlConnection(dbstring))
            using (SqlCommand command = new SqlCommand(insertvals, connection))
            {
                command.Parameters.Add("@fname", SqlDbType.VarChar).Value = cx.FirstName;
                command.Parameters.Add("@lname", SqlDbType.VarChar).Value = cx.LastName;
                command.Parameters.Add("@phone", SqlDbType.Decimal).Value = cx.PhoneNumber;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = cx.EmailAddress;
                command.Parameters.Add("@bday", SqlDbType.Date).Value = cx.BDay;
                command.Parameters.Add("@insurance", SqlDbType.VarChar).Value = cx.Insurance;
                command.Parameters.Add("@license", SqlDbType.VarChar).Value = cx.Drivers;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = cx.Password;
                command.Parameters.Add("@address", SqlDbType.VarChar).Value = cx.Address;
                command.Parameters.Add("@city", SqlDbType.VarChar).Value = cx.City;
                command.Parameters.Add("@province", SqlDbType.VarChar).Value = cx.Province;
                command.Parameters.Add("@country", SqlDbType.VarChar).Value = cx.Country;
                command.Parameters.Add("@status", SqlDbType.VarChar).Value = cx.Status;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        public static string HashPassword(string pass)
        {
            var bytes = new UTF8Encoding().GetBytes(pass);
            byte[] hashedBytes;
            using (var algorithm = new SHA256Managed())
            {
                hashedBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashedBytes);
        }

        private static bool VerifyPassword(string storedPassword, string enteredPassword)
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