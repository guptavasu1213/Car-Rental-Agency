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
        int carID = 0;

        public StartReservation(Customer cx)
        {
            InitializeComponent();
            this.User = cx;
            if (cx == null)
            {
                this.User = new Customer();
                this.User.FirstName = "Guest";
            }
            if (this.User.Status == "Gold")
            {
                welcomeLabel.ForeColor = Color.Gold;
                welcomeLabel.Text = "★ Welcome Gold Member " + User.FirstName + " ★";
            }
            else welcomeLabel.Text = "Welcome " + User.FirstName;
            pDateTimePicker.Value = DateTime.Now;
            rDateTimePicker.Value = DateTime.Now;

        }


        private void StartReservation_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Status: " + User.Status);
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

            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";

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

            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";


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

            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";

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
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void rCountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rProvinceComboBox.SelectedIndex = -1;
            rProvinceComboBox.Items.Clear();

            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";

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

            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";

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

            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";

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
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = ""; ;
            TimeSpan rentalTime = rDateTimePicker.Value.Subtract(pDateTimePicker.Value);
            int rentalDays = rentalTime.Days;

            StringBuilder whereTypeString = new StringBuilder("");
            StringBuilder whereCapacityString = new StringBuilder("");
            StringBuilder whereFuelString = new StringBuilder("");
            StringBuilder whereTransmissionString = new StringBuilder("");

            int typeSelected = 0;
            int capacitySelected = 0;
            int fuelSelected = 0;
            int transmissionSelect = 0;

            whereTypeString.Append("AND ( ");

            if (sedanCheckBox.Checked)
            {
                whereTypeString.Append("TYPE_NAME = 'Sedan' ");
                typeSelected += 1;
            }

            if (coupeCheckBox.Checked)
            {
                if (typeSelected > 0) { whereTypeString.Append("OR TYPE_NAME = 'Coupe' "); }
                else whereTypeString.Append("TYPE_NAME = 'Coupe' ");
                typeSelected += 1;
            }

            if (suvCheckBox.Checked)
            {
                if (typeSelected > 0) { whereTypeString.Append("OR TYPE_NAME = 'SUV' "); }
                else whereTypeString.Append("TYPE_NAME = 'SUV' ");
                typeSelected += 1;
            }

            if (minivanCheckBox.Checked)
            {
                if (typeSelected > 0) { whereTypeString.Append("OR TYPE_NAME = 'Minivan' "); }
                else whereTypeString.Append("TYPE_NAME = 'Minivan' ");
                typeSelected += 1;
            }

            if (hatchbackCheckBox.Checked)
            {
                if (typeSelected > 0) { whereTypeString.Append("OR TYPE_NAME = 'Hatchback' "); }
                else whereTypeString.Append("TYPE_NAME = 'Hatchback' ");
                typeSelected += 1;
            }

            whereTypeString.Append(")");

            if (typeSelected == 0) { whereTypeString.Replace("AND ( )", ""); }

            whereCapacityString.Append("AND ( ");

            if (twoCheckBox.Checked)
            {
                whereCapacityString.Append("Capacity = 2 ");
                capacitySelected += 1;
            }

            if (fourCheckBox.Checked)
            {
                if (capacitySelected > 0) { whereCapacityString.Append("OR Capacity = 4 "); }
                else whereCapacityString.Append("Capacity = 4 ");
                capacitySelected += 1;
            }

            if (fiveCheckBox.Checked)
            {
                if (capacitySelected > 0) { whereCapacityString.Append("OR Capacity = 5 "); }
                else whereCapacityString.Append("Capacity = 5 ");
                capacitySelected += 1;
            }

            if (sevenCheckBox.Checked)
            {
                if (capacitySelected > 0) { whereCapacityString.Append("OR Capacity = 7 "); }
                else whereCapacityString.Append("Capacity = 7 ");
                capacitySelected += 1;
            }

            if (eightCheckBox.Checked)
            {
                if (capacitySelected > 0) { whereCapacityString.Append("OR Capacity = 8 "); }
                else whereCapacityString.Append("Capacity = 8 ");
                capacitySelected += 1;
            }

            whereCapacityString.Append(")");

            if (capacitySelected == 0) { whereCapacityString.Replace("AND ( )", ""); }

            whereFuelString.Append("AND ( ");

            if (gasolineCheckBox.Checked)
            {
                whereFuelString.Append("Fuel_Type = 'Gasoline' ");
                fuelSelected += 1;
            }

            if (dieselCheckBox.Checked)
            {
                if (fuelSelected > 0) { whereFuelString.Append("OR Fuel_Type = 'Diesel' "); }
                else whereFuelString.Append("Fuel_Type = 'Diesel' ");
                fuelSelected += 1;
            }

            if (electricCheckBox.Checked)
            {
                if (fuelSelected > 0) { whereFuelString.Append("OR Fuel_Type = 'Electric' "); }
                else whereFuelString.Append("Fuel_Type = 'Electric' ");
                fuelSelected += 1;
            }
            whereFuelString.Append(")");

            if (fuelSelected == 0) { whereFuelString.Replace("AND ( )", ""); }

            whereTransmissionString.Append("AND ( ");

            if (automaticCheckBox.Checked)
            {
                whereTransmissionString.Append("Transmission = 'Automatic' ");
                transmissionSelect += 1;
            }

            if (manualCheckBox.Checked)
            {
                if (transmissionSelect > 0) { whereTransmissionString.Append("OR Transmission = 'Manual' "); }
                else whereTransmissionString.Append("Transmission = 'Manual' ");
                transmissionSelect += 1;
            }

            whereTransmissionString.Append(")");

            if (transmissionSelect == 0) { whereTransmissionString.Replace("AND ( )", ""); }

            if (pCountryComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Pickup Information Missing: Please select pickup Country";
            }

            else if (pProvinceComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Pickup Information Missing: Please select pickup Province";
            }

            else if (pCityComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Pickup Information Missing: Please select pickup City";
            }

            else if (pBranchComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Pickup Information Missing: Please select pickup Branch";
            }
            else if (rCountryComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Pickup Information Missing: Please select return Country";
            }

            else if (rProvinceComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Pickup Information Missing: Please select return Province";
            }

            else if (rCityComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Pickup Information Missing: Please select return City";
            }
            else if (rBranchComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Pickup Information Missing: Please select return Branch";
            }
            else if (rentalDays < 1)
            {
                errorLabel.Text = "Minimum car rental of 1 day is Required";
            }
            else
            {
                con = new SqlConnection("" +
                "Data Source=142.59.80.79,5291;" +
                "Initial Catalog=CRA291;" +
                "User ID=SA;" +
                "Password=@291CRAsql$");
                cmd = new SqlCommand();
                con.Open();

                string sqlstring = "" +
                    "SELECT CAR_ID as 'Car #', TYPE_NAME as 'Type', Make, Model, Year, Fuel_Type as 'Fuel', Transmission, Capacity " +
                    "FROM Branch, Car " +
                    "WHERE Branch.BRANCH_ID = Car.BRANCH_ID " +
                    "and Branch.Name = " + "'" + pBranchComboBox.Text + "' " +
                    "" + whereTypeString.ToString() + " " + whereCapacityString.ToString() + " " + whereFuelString.ToString() + " " + whereTransmissionString.ToString();

                Console.WriteLine(sqlstring);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlstring, con);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                carResultDataGridView.DataSource = dataTable;
                carResultDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                carResultDataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                con.Close();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            StartReservation NewForm = new StartReservation(User);
            NewForm.Show();
            this.Dispose(false);
        }

        private void carResultDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string rentalType;
            double rentalCost = 0;
            double dailyRate = 0;
            double weeklyRate = 0;
            double monthyRate = 0;
            double differentBranchFee = 29.99;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = carResultDataGridView.Rows[e.RowIndex];
                carID = Convert.ToInt32(row.Cells["Car #"].Value);
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

                TimeSpan rentalTime = rDateTimePicker.Value.Subtract(pDateTimePicker.Value);
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

                string summary = row.Cells["Year"].Value.ToString() + " "
                + row.Cells["Make"].Value.ToString() + " "
                + row.Cells["Model"].Value.ToString() + " ("
                + row.Cells["Type"].Value.ToString() + "/"
                + row.Cells["Transmission"].Value.ToString() + "/"
                + row.Cells["Fuel"].Value.ToString() + "/"
                + row.Cells["Capacity"].Value.ToString() + " Seats)\n"
                + pDateTimePicker.Value.ToString("dddd, MMMM d, yyyy")
                + " — " + rDateTimePicker.Value.ToString("dddd, MMMM d, yyyy") + "\n"
                + "Breakdown: " + rentalTime.Days + " Days ==> " + rentalMonths + " Months + ($" + rentalMonths * monthyRate + ") + "
                + rentalWeeks + " Weeks ($" + rentalWeeks * weeklyRate + ") + "
                + rentalDays + " Days ($" + rentalDays * dailyRate + ")\n";

                double rentalSubtotal = rentalCost;

                if (rBranchComboBox.Text != pBranchComboBox.Text && User.Status != "Gold")
                {
                    rentalCost += differentBranchFee;
                    infoLabel.Text = summary
                        + "Subtotal: $" + rentalSubtotal
                        + " + Additional Fee for Different Branch Return: $" + differentBranchFee + " = Total: " + rentalCost;
                }
                else infoLabel.Text = summary + "Total: " + rentalCost;
            }

        }

        private void dDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void rDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void sedanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void coupeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void suvCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void minivanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void hatchbackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void twoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void fourCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void fiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void sevenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void eightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void gasolineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void dieselCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void electricCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void automaticCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void manualCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            carResultDataGridView.DataSource = null;
            infoLabel.Text = "Waiting for Selection...";
            errorLabel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            infoLabel.Text = "cuID:" + User.ID.ToString() + " caID: " + carID;

        }
    }
}




