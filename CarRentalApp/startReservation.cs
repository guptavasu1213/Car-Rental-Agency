using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRentalApp
{

    public partial class StartReservation : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        Customer User;

        public StartReservation(Customer cx)
        {
            InitializeComponent();
            this.User = cx;
            if (cx == null)
            {
                this.User = new Customer();
                this.User.FirstName = "Guest";
            }
        }

        private void StartReservation_Load(object sender, EventArgs e)
        {

            con = new SqlConnection("" +
                "Data Source=142.59.80.79,5291; " +
                "Initial Catalog=CRA291;" +
                "User ID=SA;" +
                "Password=@291CRAsql$");

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "" +
                "SELECT distinct Country " +
                "FROM Branch";

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                pCountryComboBox.Items.Add(dr["Country"]);
                rCountryComboBox.Items.Add(dr["Country"]);
            }
            con.Close();
        }

        private void pCountryComboBoxIndexChanged(object sender, EventArgs e)
        {

            pProvinceComboBox.SelectedIndex = -1;
            pProvinceComboBox.Items.Clear();
            string pCountryComboBoxASelection = pCountryComboBox.Text;

            con = new SqlConnection("" +
                "Data Source=142.59.80.79,5291; " +
                "Initial Catalog=CRA291;" +
                "User ID=SA;" +
                "Password=@291CRAsql$");

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "" +
                "SELECT distinct Province " +
                "FROM Branch " +
                "WHERE Country = '" + pCountryComboBoxASelection + "'";

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                pProvinceComboBox.Items.Add(dr["Province"]);

            }
            con.Close();
        }

        private void pProvinceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            pCityComboBox.SelectedIndex = -1;
            pCityComboBox.Items.Clear();
            string pCountryComboBoxASelection = pCountryComboBox.Text;
            string pProvinceComboBoxSelection = pProvinceComboBox.Text;


            con = new SqlConnection("" +
                "Data Source=142.59.80.79,5291; " +
                "Initial Catalog=CRA291;" +
                "User ID=SA;" +
                "Password=@291CRAsql$");

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "" +
                "SELECT distinct City " +
                "FROM Branch " +
                "WHERE Country = '" + pCountryComboBoxASelection +
                "' and Province = '" + pProvinceComboBoxSelection + "'";

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                pCityComboBox.Items.Add(dr["City"]);
            }

            con.Close();

        }

        private void pCityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pBranchComboBox.SelectedIndex = -1;
            pBranchComboBox.Items.Clear();
            string pCountryComboBoxASelection = pCountryComboBox.Text;
            string pProvinceComboBoxSelection = pProvinceComboBox.Text;
            string pCityComboBoxSelection = pCityComboBox.Text;

            con = new SqlConnection("" +
                "Data Source=142.59.80.79,5291;" +
                "Initial Catalog=CRA291;" +
                "User ID=SA;" +
                "Password=@291CRAsql$");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "" +
                "SELECT distinct Name " +
                "FROM Branch " +
                "WHERE Country = '" + pCountryComboBoxASelection +
                "' and Province = '" + pProvinceComboBoxSelection +
                "' and City = '" + pCityComboBoxSelection + "'";

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                pBranchComboBox.Items.Add(dr["Name"]);

            }
            con.Close();
        }

        private void pBranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void rCountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rProvinceComboBox.SelectedIndex = -1;
            rProvinceComboBox.Items.Clear();
            string rCountryComboBoxASelection = rCountryComboBox.Text;

            con = new SqlConnection("" +
                "Data Source=142.59.80.79,5291; " +
                "Initial Catalog=CRA291;" +
                "User ID=SA;" +
                "Password=@291CRAsql$");

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "" +
                "SELECT distinct Province " +
                "FROM Branch " +
                "WHERE Country = '" + rCountryComboBoxASelection + "'";

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                rProvinceComboBox.Items.Add(dr["Province"]);

            }
            con.Close();
        }

        private void rProvinceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            rCityComboBox.SelectedIndex = -1;
            rCityComboBox.Items.Clear();
            string rCountryComboBoxASelection = rCountryComboBox.Text;
            string rProvinceComboBoxSelection = rProvinceComboBox.Text;


            con = new SqlConnection("" +
                "Data Source=142.59.80.79,5291; " +
                "Initial Catalog=CRA291;" +
                "User ID=SA;" +
                "Password=@291CRAsql$");

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "" +
                "SELECT distinct City " +
                "FROM Branch " +
                "WHERE Country = '" + rCountryComboBoxASelection +
                "' and Province = '" + rProvinceComboBoxSelection + "'";

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                rCityComboBox.Items.Add(dr["City"]);
            }

            con.Close();

        }

        private void rCityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            rBranchComboBox.SelectedIndex = -1;
            rBranchComboBox.Items.Clear();
            string rCountryComboBoxASelection = rCountryComboBox.Text;
            string rProvinceComboBoxSelection = rProvinceComboBox.Text;
            string rCityComboBoxSelection = rCityComboBox.Text;

            con = new SqlConnection("" +
                "Data Source=142.59.80.79,5291;" +
                "Initial Catalog=CRA291;" +
                "User ID=SA;" +
                "Password=@291CRAsql$");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "" +
                "SELECT distinct Name " +
                "FROM Branch " +
                "WHERE Country = '" + rCountryComboBoxASelection +
                "' and Province = '" + rProvinceComboBoxSelection +
                "' and City = '" + rCityComboBoxSelection + "'";

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                rBranchComboBox.Items.Add(dr["Name"]);

            }
            con.Close();
        }

        private void rBranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("" +
                "Data Source=142.59.80.79,5291;" +
                "Initial Catalog=CRA291;" +
                "User ID=SA;" +
                "Password=@291CRAsql$");
            cmd = new SqlCommand();
            con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TYPE_NAME as 'Type', Make, Model, Year, Fuel_Type as 'Fuel', Transmission, Capacity FROM Branch, Car WHERE Branch.BRANCH_ID = Car.BRANCH_ID and Branch.Name = " + "'" + pBranchComboBox.Text + "'", con);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            carResultDataGridView.DataSource = dataTable;
            carResultDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            carResultDataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            con.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {

        }



        private void carResultDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string rentalType;
            double rentalCost = 0;
            double dailyRate = 0;
            double weeklyRate = 0;
            double monthyRate = 0;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = carResultDataGridView.Rows[e.RowIndex];
                rentalType = row.Cells["Type"].Value.ToString();

                con = new SqlConnection("" +
                "Data Source=142.59.80.79,5291; " +
                "Initial Catalog=CRA291;" +
                "User ID=SA;" +
                "Password=@291CRAsql$");

                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "" +
                "SELECT Daily_Fee, Weekly_Fee, Monthly_Fee " +
                "FROM Type " +
                "WHERE TYPE_NAME = '" + rentalType + "'";

                dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    dailyRate = Convert.ToDouble(dr["Daily_Fee"]);
                    weeklyRate = Convert.ToDouble(dr["Weekly_Fee"]);
                    monthyRate = Convert.ToDouble(dr["Monthly_Fee"]);
                }

                con.Close();

                TimeSpan rentalTime = rDateTimePicker.Value.Subtract(dDateTimePicker.Value);
                int rentalDays = rentalTime.Days;
                int rentalMonths = 0;
                int rentalWeeks = 0;

                while (rentalDays >= 28)
                {
                    rentalCost += monthyRate;
                    rentalDays -= 28;
                    rentalMonths += 1;

                }

                while (rentalDays >= 7)
                {
                    rentalCost += weeklyRate;
                    rentalDays -= 7;
                    rentalWeeks += 1;
                }

                rentalCost += rentalDays * dailyRate;

                // displaying the rental summary here

                infoLabel.Text =
                row.Cells["Year"].Value.ToString() + " "
                + row.Cells["Make"].Value.ToString() + " "
                + row.Cells["Model"].Value.ToString() + " ("
                + row.Cells["Type"].Value.ToString() + "/"
                + row.Cells["Transmission"].Value.ToString() + "/"
                + row.Cells["Fuel"].Value.ToString() + "/"
                + row.Cells["Capacity"].Value.ToString() + " Seats)\n"
                + dDateTimePicker.Value.ToString("dddd, MMMM d, yyyy")
                + " — " + rDateTimePicker.Value.ToString("dddd, MMMM d, yyyy") + "\n"
                + "Breakdown: " + rentalTime.Days + " Days ==> " + rentalMonths + " Months + ($" + rentalMonths * monthyRate + ") +"
                + rentalWeeks + " Weeks ($" + rentalWeeks * weeklyRate + ") +"
                + rentalDays + " Days ($" + rentalDays * dailyRate + ")\n"
                + "Total: $" + rentalCost;


            }

        }
    }
}




