using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Data;
using System.Linq;

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

        public static bool CustomerAuth(string inputEmail, string inputPassword)
        {
            string database = Database.ConnectionString;
            string sql = "SELECT Password FROM Customer WHERE Email = @email";

            SqlParameter pEmail = new SqlParameter("@email", inputEmail);
            SqlConnection connection = new SqlConnection(database);

            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.Add(pEmail);

            // check if there are any rows in the database with this email first
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    // get the password from the column as a string
                    string password = reader.GetString(0);

                    // verify hashes are equal
                    if (VerifyPassword(password, inputPassword))
                    {
                        MessageBox.Show("Successful Sign In", "Success");
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid password, please try again", "Invalid Password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username", "Invalid Username");
                    Console.WriteLine("Log in failed");
                }
            }

            connection.Close();
            return false;
        }

        public static bool insertCustomer(Customer cx)
        {
            string dbstring = Database.ConnectionString;
            string sql = "INSERT INTO Customer (First_Name, Last_Name, Phone_Number, Email, Birthday, Insurance_Policy_Number, Drivers_License, Password, Street_Address, City, Province, Country, Membership_Status) ";
            string values = "VALUES (@fname, @lname, @phone, @email, @bday, @insurance, @license, @password, @address, @city, @province, @country, @status);";
            string insertvals = sql + values;
            Random random = new Random();

            using (SqlConnection connection = new SqlConnection(dbstring))
            using (SqlCommand command = new SqlCommand(insertvals, connection))
            {
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = Login.HashPassword(random.Next(0, 1000000000).ToString());

                command.Parameters.Add("@fname", SqlDbType.VarChar).Value = cx.FirstName;
                command.Parameters.Add("@lname", SqlDbType.VarChar).Value = cx.LastName;
                command.Parameters.Add("@phone", SqlDbType.Decimal).Value = cx.PhoneNumber;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = cx.EmailAddress;
                command.Parameters.Add("@bday", SqlDbType.Date).Value = cx.BDay;
                command.Parameters.Add("@insurance", SqlDbType.VarChar).Value = cx.Insurance;
                command.Parameters.Add("@license", SqlDbType.VarChar).Value = cx.Drivers;
                command.Parameters.Add("@address", SqlDbType.VarChar).Value = cx.Address;
                command.Parameters.Add("@city", SqlDbType.VarChar).Value = cx.City;
                command.Parameters.Add("@province", SqlDbType.VarChar).Value = cx.Province;
                command.Parameters.Add("@country", SqlDbType.VarChar).Value = cx.Country;
                command.Parameters.Add("@status", SqlDbType.VarChar).Value = cx.Status;
                
                if (cx.SelfServer)
                {
                    command.Parameters.Add("@password", SqlDbType.VarChar).Value = cx.Password;
                }

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        public static bool insertEmployee(Employee emp)
        {
            string dbstring = Database.ConnectionString;
            string sql = "INSERT INTO Employee (First_Name, Last_Name, Phone_Number, Email, Birthday, Password, Street_Address, City, Province, Country, Status, SIN, Salary, Position, BRANCH_ID, Employment_Type) ";
            string values = "VALUES (@fname, @lname, @phone, @email, @bday, @password, @address, @city, @province, @country, @status, @sin, @salary, @position, @branch, @time);";
            string insertvals = sql + values;
            Random random = new Random();
            DataTable branchTable = Database.getDataTableAfterRunningQuery(String.Format("SELECT BRANCH_ID, Name FROM Branch WHERE Name = '{0}'", emp.Branch));

            using (SqlConnection connection = new SqlConnection(dbstring))
            using (SqlCommand command = new SqlCommand(insertvals, connection))
            {
                command.Parameters.Add("@fname", SqlDbType.VarChar).Value = emp.FirstName;
                command.Parameters.Add("@lname", SqlDbType.VarChar).Value = emp.LastName;
                command.Parameters.Add("@phone", SqlDbType.Decimal).Value = emp.PhoneNumber;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = emp.EmailAddress;
                command.Parameters.Add("@bday", SqlDbType.Date).Value = emp.BDay;
                command.Parameters.Add("@address", SqlDbType.VarChar).Value = emp.Address;
                command.Parameters.Add("@city", SqlDbType.VarChar).Value = emp.City;
                command.Parameters.Add("@province", SqlDbType.VarChar).Value = emp.Province;
                command.Parameters.Add("@country", SqlDbType.VarChar).Value = emp.Country;
                command.Parameters.Add("@status", SqlDbType.VarChar).Value = emp.Status;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = emp.Password;
                command.Parameters.Add("@sin", SqlDbType.VarChar).Value = emp.SIN;
                command.Parameters.Add("@salary", SqlDbType.VarChar).Value = emp.Salary;
                command.Parameters.Add("@position", SqlDbType.VarChar).Value = emp.Position;
                command.Parameters.Add("@branch", SqlDbType.VarChar).Value = branchTable.Rows[0].Field<int>("BRANCH_ID");
                command.Parameters.Add("@time", SqlDbType.VarChar).Value = emp.EmploymentType;

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

            if (hashedPassword.Equals(storedPassword))
            {
                return true;
            }
            return false;
        }
    }
}