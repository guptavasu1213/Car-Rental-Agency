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

        int entryCustomerID;
        int entryCarID = 5921;
        int entryPickupBranchID;
        int entryDropBranchID;
        DateTime entryPickupDateTime;
        DateTime entryReturnDateTime;
        double entryAmount;
        string entryCardNumber;
        string entryCardType;
        string entryPaymentMethod;
        string entryStatus;
        string entryMembership;
        int successfulTransactionFlag = 0;
        DateTime entryTransactionDateTime;

        public StartReservation(Customer cx)
        {
            InitializeComponent();
            this.User = cx;
            if (cx == null)
            {
                this.User = new Customer();
                this.User.FirstName = "Guest";
            }

            con = new SqlConnection("" +
            "Data Source=142.59.80.79,5291; " +
            "Initial Catalog=CRA291;" +
            "User ID=SA;" +
            "Password=@291CRAsql$");

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "" +
                "select Membership_Status " +
                "from Customer " +
                "where CUSTOMER_ID = " + this.User.ID;


            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                entryMembership = dr["Membership_Status"].ToString();
            }

            if (entryMembership == "Gold")
            {
                welcomeLabel.ForeColor = Color.Gold;
                welcomeLabel.Text = "★ Welcome Gold Member " + User.FirstName + " ★";
            }
            else welcomeLabel.Text = "Welcome " + User.FirstName;

            entryCustomerID = this.User.ID;
            entryCardType = this.User.cardType;
            entryCardNumber = this.User.cardNumber;
            entryPaymentMethod = "Online";
            entryStatus = "Success";

            pDateTimePicker.Value = DateTime.Now;
            rDateTimePicker.Value = DateTime.Now;

        }

        private void StartReservation_Load(object sender, EventArgs e)
        {
        }

        private void pCountryComboBox_DropDown(object sender, EventArgs e)
        {
            pCountryComboBox.Items.Clear();
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
                "' and City = '" + pCityComboBoxSelection + "' and Status = 'Active'";

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

        private void rCountryComboBox_DropDown(object sender, EventArgs e)
        {
            rCountryComboBox.Items.Clear();
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
                rCountryComboBox.Items.Add(dr["Country"]);
            }
            con.Close();
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
                "' and City = '" + rCityComboBoxSelection + "' and Status = 'Active'";

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
                    "SELECT CAR_ID as 'Car ID', TYPE_NAME as 'Type', Make, Model, Year, Fuel_Type as 'Fuel', Transmission, Capacity " +
                    "FROM Branch, Car " +
                    "WHERE Branch.BRANCH_ID = Car.BRANCH_ID " +
                    "and Branch.Name = " + "'" + pBranchComboBox.Text + "' and Car.In_Service = 1 " +
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
            this.Close();
            NewForm.Show();
        }
        /*
 * Runs the query to validate if the user pickup date and drop date are valid for a given car.
 * Returns true if the pickup and dropoff time are valid; else return false
 */
        private bool validatePickupAndDropDateTime(int carID, string pickupDateTime, string dropDateTime)
        {

            string query =
                "select * " +
                "from [Transaction] " +
                $"where CAR_ID = {carID} " +
                    "and [Transaction].Status = 'Success' " +
                    $"and (('{pickupDateTime}' between Pickup_Date_Time and Return_Date_Time) " +
                    $"or ('{dropDateTime}' between Pickup_Date_Time and Return_Date_Time) " +
                    $"or ('{pickupDateTime}' < Pickup_Date_Time and '{dropDateTime}' > Return_Date_Time));";

            // fill the table with the value retrieved
            DataTable table = Database.getDataTableAfterRunningQuery(query);
            // If: Resulting table after the query is empty
            if (table.Rows.Count == 0) { return true; }
            else { return false; }
        }
        /*
         * Finds any other car at the given branch with a car price higher than the current price point.
         * If a higher price car ain't available, then the we look for same price point car
         */
        private DataTable findOtherCars(Double dailyRate, Double weeklyRate, Double monthyRate, string pickupDateTime, string dropDateTime)
        {
            string pickupBranch = pBranchComboBox.Text;
            string query =
                "select * " +
                "from Car, Branch, Type " +
                $"where Car.BRANCH_ID = Branch.BRANCH_ID " +
                    $"and Car.TYPE_NAME = Type.TYPE_NAME " +
                    $"and Branch.Name = '{pickupBranch}' " +
                    $"and(Type.Daily_Fee > {dailyRate} or Type.Weekly_Fee > {weeklyRate} or Type.Monthly_Fee > {monthyRate}) " +
                    "and not exists ( " +
                        "select CAR_ID " +
                        "from [Transaction] " +
                        "where Car.CAR_ID = [Transaction].CAR_ID " +
                        $"and (('{pickupDateTime}' between Pickup_Date_Time and Return_Date_Time) " +
                        $"or('{dropDateTime}' between Pickup_Date_Time and Return_Date_Time) " +
                        $"or('{pickupDateTime}' < Pickup_Date_Time and '{dropDateTime}' > Return_Date_Time)));";

            // fill the table with the value retrieved
            DataTable table = Database.getDataTableAfterRunningQuery(query);
            // If: Resulting table after the query is empty
            if (table.Rows.Count == 0) { return null; }
            else
            {
                return table;
            }
        }
        private void carResultDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            successfulTransactionFlag = 0;
            string summary = "";
            string rentalType;
            double rentalCost = 0;
            double dailyRate = 0;
            double weeklyRate = 0;
            double monthyRate = 0;
            double differentBranchFee = 29.99;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = carResultDataGridView.Rows[e.RowIndex];
                //entryCarID = Convert.ToInt32(row.Cells["Car ID"].Value);
                rentalType = row.Cells["Type"].Value.ToString();
                string typeVal = row.Cells["Type"].Value.ToString();
                string fuelVal = row.Cells["Fuel"].Value.ToString();

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

                entryCarID = Convert.ToInt32(row.Cells["Car ID"].Value);
                string pickupDateTime = pDateTimePicker.Value.ToString();
                string returnDateTime = rDateTimePicker.Value.ToString();

                // If the pickup or drop off datetime are invalid
                if (!validatePickupAndDropDateTime(entryCarID, pickupDateTime, returnDateTime))
                {
                    if (entryMembership != "Gold")
                    {
                        infoLabel.Text = "The car is not available at the given date. Upgrading is not allowed for Basic membership";
                        return;
                    }

                    summary = "The car you found is not available during the selected time! Looking for other cars . . \n";
                    //infoLabel.Text = sum;
                    DataTable table = findOtherCars(dailyRate, weeklyRate, monthyRate, pickupDateTime, returnDateTime);

                    if (table == null)
                    {
                        infoLabel.Text = "Sorry Gold Member, No cars found! Try another Branch!";
                        return;
                    }

                    garbageDataView.DataSource = table;
                    row = garbageDataView.Rows[0];

                    entryCarID = Convert.ToInt32(row.Cells["Car_ID"].Value);
                    typeVal = row.Cells["TYPE_NAME"].Value.ToString();
                    fuelVal = row.Cells["Fuel_Type"].Value.ToString();
                }


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

                summary += row.Cells["Year"].Value.ToString() + " "
                + row.Cells["Make"].Value.ToString() + " "
                + row.Cells["Model"].Value.ToString() + " ("
                + typeVal + "/"
                + row.Cells["Transmission"].Value.ToString() + "/"
                + fuelVal + "/"
                + row.Cells["Capacity"].Value.ToString() + " Seats)\n"
                + pDateTimePicker.Value.ToString("dddd, MMMM d, yyyy")
                + " — " + rDateTimePicker.Value.ToString("dddd, MMMM d, yyyy") + "\n"
                + "Breakdown: " + rentalTime.Days + " Days ==> " + rentalMonths + " Months + ($" + rentalMonths * monthyRate + ") + "
                + rentalWeeks + " Weeks ($" + rentalWeeks * weeklyRate + ") + "
                + rentalDays + " Days ($" + rentalDays * dailyRate + ")\n";

                double rentalSubtotal = rentalCost;

                if (rBranchComboBox.Text != pBranchComboBox.Text && entryMembership != "Gold")
                {
                    rentalCost += differentBranchFee;
                    infoLabel.Text = summary
                        + "Subtotal: $" + rentalSubtotal
                        + " + Additional Fee for Different Branch Return: $" + differentBranchFee + " = Total: " + rentalCost;
                }
                else infoLabel.Text = summary + "Total: " + rentalCost;
            }
            entryAmount = rentalCost;
            successfulTransactionFlag = 1;
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

        private void rentCarButton_Click(object sender, EventArgs e)
        {
            if (successfulTransactionFlag == 0)
            {
                MessageBox.Show("No car rented!");
                return;
            }
            else // When the transaction is successful
            {
                successfulTransactionFlag = 0;
            }

            if (entryCarID == 5921)
            {
                carResultDataGridView.DataSource = null;
                errorLabel.Text = "Complete Search to Rent Car";
                infoLabel.Text = "Waiting for Selection...";
            }
            else if (entryCardNumber == "")
            {
                carResultDataGridView.DataSource = null;
                errorLabel.Text = "No Card on File";
            }
            else if (entryCardType == "")
            {
                carResultDataGridView.DataSource = null;
                errorLabel.Text = "No Card on File";
            }
            else
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
                "SELECT BRANCH_ID " +
                "FROM Branch " +
                "WHERE Name = '" + pBranchComboBox.Text + "'";

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entryPickupBranchID = Convert.ToInt32(dr["BRANCH_ID"].ToString());
                }

                con.Close();

                con = new SqlConnection("" +
                  "Data Source=142.59.80.79,5291; " +
                  "Initial Catalog=CRA291;" +
                  "User ID=SA;" +
                  "Password=@291CRAsql$");

                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "" +
                "SELECT BRANCH_ID " +
                "FROM Branch " +
                "WHERE Name = '" + rBranchComboBox.Text + "'";

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entryDropBranchID = Convert.ToInt32(dr["BRANCH_ID"].ToString());
                }

                con.Close();

                entryPickupDateTime = pDateTimePicker.Value;
                entryReturnDateTime = rDateTimePicker.Value;
                entryTransactionDateTime = DateTime.Now;

                carResultDataGridView.DataSource = null;

                // errorLabel.Text =
                //     "CU-ID = " + entryCustomerID + " " +
                //     "\nCA-ID = " + entryCarID + " " +
                //     "\nDE-ID = " + entryDropEmployeeID + " " +
                //     "\nPE-ID = " + entryPickupEmployeeID + " " +
                //     "\nPB-ID = " + entryPickupBranchID + " " +
                //     "\nDB-ID = " + entryDropBranchID + " " +
                //     "\nPDT = " + entryPickupDateTime + " " +
                //     "\nRDT = " + entryReturnDateTime + " " +
                //     "\nAMT = " + entryAmount + " " +
                //     "\nCNUM = " + entryCardNumber + " " +
                //     "\nCTYP = " + entryCardType + " " +
                //     "\nPMTD = " + entryPaymentMethod + " " +
                //     "\nPSTS = " + entryStatus + " " +
                //     "\nTDT = " + entryTransactionDateTime;


                string sql = "INSERT INTO [Transaction] (CUSTOMER_ID, CAR_ID, PICKUP_BRANCH_ID, DROP_BRANCH_ID, Pickup_Date_Time, Return_Date_Time, Amount, Card_Number, Card_Type, Payment_Method, Status, Transaction_Date_Time) ";
                string values = "VALUES (@eCUID, @eCAID, @ePBID, @eDBID, @ePDT, @eRDT, @eAMT, @eCNUM, @eCTYP, @ePMTD, @ePSTS, @eTDT);";
                string insertvals = sql + values;

                int returnStatus = 0;
                con = new SqlConnection("" +
                    "Data Source=142.59.80.79,5291; " +
                    "Initial Catalog=CRA291;" +
                    "User ID=SA;" +
                    "Password=@291CRAsql$");

                cmd = new SqlCommand(insertvals, con);

                cmd.Parameters.Add("@eCUID", SqlDbType.Int).Value = entryCustomerID;
                cmd.Parameters.Add("@eCAID", SqlDbType.Int).Value = entryCarID;
                //cmd.Parameters.Add("@eDEID", SqlDbType.Int).Value = entryDropEmployeeID;
                //cmd.Parameters.Add("@ePEID", SqlDbType.Int).Value = entryPickupEmployeeID;
                cmd.Parameters.Add("@ePBID", SqlDbType.Int).Value = entryPickupBranchID;
                cmd.Parameters.Add("@eDBID", SqlDbType.Int).Value = entryDropBranchID;
                cmd.Parameters.Add("@ePDT", SqlDbType.DateTime).Value = entryPickupDateTime;
                cmd.Parameters.Add("@eRDT", SqlDbType.DateTime).Value = entryReturnDateTime;
                cmd.Parameters.Add("@eAMT", SqlDbType.Decimal).Value = entryAmount;
                cmd.Parameters.Add("@eCNUM", SqlDbType.Decimal).Value = entryCardNumber;
                cmd.Parameters.Add("@eCTYP", SqlDbType.VarChar).Value = entryCardType;
                cmd.Parameters.Add("@ePMTD", SqlDbType.VarChar).Value = entryPaymentMethod;
                cmd.Parameters.Add("@ePSTS", SqlDbType.VarChar).Value = entryStatus;
                cmd.Parameters.Add("@eTDT", SqlDbType.DateTime).Value = entryTransactionDateTime;

                con.Open();
                returnStatus = cmd.ExecuteNonQuery();
                con.Close();

                if (returnStatus > 0)
                {

                    int customerTransations = 0;

                    con = new SqlConnection("" +
                        "Data Source=142.59.80.79,5291; " +
                        "Initial Catalog=CRA291;" +
                        "User ID=SA;" +
                        "Password=@291CRAsql$");

                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;

                    cmd.CommandText = "" +
                        "select COUNT(Customer.Customer_ID) as 'Number' " +
                        "from Customer, [Transaction] " +
                        "where Customer.CUSTOMER_ID = [Transaction].CUSTOMER_ID " +
                        "and Customer.CUSTOMER_ID = '" + entryCustomerID + "' " +
                        "and Status = 'Success' " +
                        "and YEAR(pickup_Date_Time) = YEAR(getdate())";


                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        customerTransations = Convert.ToInt32(dr["Number"]);
                    }

                    con.Close();

                    //errorLabel.Text = customerTransations.ToString() + " " + entryStatus ;

                    int rowUpdated = 0;
                    if (customerTransations == 3 && entryMembership == "Basic")
                    {
                        cmd = new SqlCommand();
                        con.Open();
                        cmd.Connection = con;

                        cmd.CommandText = "UPDATE Customer SET Membership_Status = 'Gold' Where Customer_ID = " + this.User.ID;

                        rowUpdated = cmd.ExecuteNonQuery();

                        con.Close();
                    }


                    if (rowUpdated > 0)
                    {
                        MessageBox.Show("Car Rental Successfull! YOU ARE NOW A GOLD MEMBER! ", "Success and New Membership");
                    }
                    else
                    {
                        MessageBox.Show("Car Rental Successfull!", "Success");
                    }
                    this.Close();
                }
            }
        }
    }
}