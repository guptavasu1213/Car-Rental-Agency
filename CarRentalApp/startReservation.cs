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

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TYPE_NAME as ' Car Type', Make, Model, Year, Fuel_Type as 'Fuel Type', Transmission, Capacity FROM Branch, Car WHERE Branch.BRANCH_ID = Car.BRANCH_ID and Branch.Name = "+ "'" + pBranchComboBox.Text + "'", con);

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
    }
}




