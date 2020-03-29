using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class AdminPortal : Form
    {
        public AdminPortal()
        {
            InitializeComponent();
        }

        private void UsersLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void findEmployeeLabel_Click(object sender, EventArgs e)
        {

        }

        /*Setting mouse hover functionality*/
        private void setBackgroundOnMouseHover(Label label)
        {
            label.BackColor = Color.FromArgb(63, 63, 63);
        }
        /*Setting mouse leave functionality*/
        private void setBackgroundOnMouseLeave(Label label)
        {
            label.BackColor = Color.FromArgb(43, 43, 43);
        }

        private void findUserLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(findUserLabel);
        }

        private void addUserLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(addNewUserLabel);
        }

        private void addEmployeeLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(addEmployeeLabel);
        }

        private void addEmployeeLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(addEmployeeLabel);
        }

        private void findUserLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(findUserLabel);
        }

        private void addUserLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(addNewUserLabel);
        }

        private void findEmployeeLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(findEmployeeLabel);
        }

        private void findEmployeeLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(findEmployeeLabel);
        }

        private void findVehicle_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(findVehicleLabel);
        }

        private void findVehicle_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(findVehicleLabel);
        }

        private void addVehicleTypeLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(addVehicleTypeLabel);
        }

        private void addVehicleTypeLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(addVehicleTypeLabel);
        }

        private void findBookingLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(findBookingLabel);
        }

        private void findBookingLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(findBookingLabel);
        }

        private void addBookingLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(addNewBookingLabel);
        }

        private void addBookingLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(addNewBookingLabel);
        }

        private void findBranchLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(findBranchLabel);
        }

        private void findBranchLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(findBranchLabel);
        }
        private void findVehicleTypeLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(findVehicleTypeLabel);
        }
        private void findVehicleTypeLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(findVehicleTypeLabel);
        }

        private void addBranchLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(addNewBranchLabel);
        }

        private void addBranchLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(addNewBranchLabel);
        }

        private void top10EmployeeLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(top10EmployeeLabel);
        }

        private void top10EmployeeLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(top10EmployeeLabel);
        }

        private void top100CustomersLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(top100CustomersLabel);
        }

        private void top100CustomersLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(top100CustomersLabel);
        }

        private void popularCarLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(popularCarLabel);
        }

        private void popularCarLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(popularCarLabel);
        }

        private void popularCarTypeLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(popularCarTypeLabel);
        }

        private void popularCarTypeLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(popularCarTypeLabel);
        }

        private void popularBranchLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(popularBranchLabel);
        }

        private void popularBranchLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(popularBranchLabel);
        }

        private void addVehicleLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(addNewVehicleLabel);
        }

        private void addVehicleLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(addNewVehicleLabel);
        }

        private void leftSidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
         /*
         * When the logout button is clicked, the user is taken back to the login screen
         */
        private void logoutButton_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            this.Close(); // Close this Form
            adminLogin.Show(); 
        }

        /* Purpose: Sets up the right hand side panel in the Portal with the form passed to the function
         * Parameter: The form to be set on the right hand side
         */
        private void settingUpRightSidePanel(Form form)
        {
            rightHandSidePanel.Controls.Clear(); // Clearing everything present in the panel
            form.TopLevel = false;
            rightHandSidePanel.Controls.Add(form); // Adding the form to the panel
            // Removes top bar (which has minimize, maximize and close) of the form 
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show(); // Showing the form on the panel
        }
        /*
         * When the Find User Label is clicked on, the form for searching for existing 
         * Users is loaded on the right hand side panel
         */
        private void findUserLabel_Click(object sender, EventArgs e)
        {
            FindUser findUserForm = new FindUser();
            settingUpRightSidePanel(findUserForm);
        }

        /*
         * When the Popular Car Label is clicked on, the form for searching for Popular 
         * Car is loaded on the right hand side panel
         */
        private void popularCarLabel_Click(object sender, EventArgs e)
        {
            PopularCar popularCarForm = new PopularCar(); // Creating the form 
            settingUpRightSidePanel(popularCarForm);
        }
       /*
         * When the Popular Car Type Label is clicked on, the form for searching for Popular 
         * Car Type is loaded on the right hand side panel
         */
        private void popularCarTypeLabel_Click(object sender, EventArgs e)
        {
            PopularCarType popularCarTypeForm = new PopularCarType();
            settingUpRightSidePanel(popularCarTypeForm);
        }
        /*
         * When the Top 10 Employees Label is clicked on, the form for searching for Top 10
         * Employees is loaded on the right hand side panel
         */
        private void top10EmployeeLabel_Click(object sender, EventArgs e)
        {
            Top10Employees top10EmployeesForm = new Top10Employees();
            settingUpRightSidePanel(top10EmployeesForm);
        }
        /*
         * When the Top 100 Customers Label is clicked on, the form for searching for Top 100
         * Customers is loaded on the right hand side panel
         */
        private void top100CustomersLabel_Click(object sender, EventArgs e)
        {
            FindTop100Customers findTop100CustomersForm = new FindTop100Customers();
            settingUpRightSidePanel(findTop100CustomersForm);
        }
        /*
         * When the Popular Branch Label is clicked on, the form for searching for Popular
         * Branches is loaded on the right hand side panel
         */
        private void popularBranchLabel_Click(object sender, EventArgs e)
        {
            PopularBranch popularBranchForm = new PopularBranch();
            settingUpRightSidePanel(popularBranchForm);
        }
        /*
         * When the Add Employee Label is clicked on, the form for adding new employees
         * is loaded on the right hand side panel
         */
        private void addNewEmployeeLabel_Click(object sender, EventArgs e)
        {
            AddNewEmployee addNewEmployeeForm = new AddNewEmployee();
            settingUpRightSidePanel(addNewEmployeeForm);
        }

        /*
         * When the Add New User Label is clicked on, the form for adding new users
         * is loaded on the right hand side panel
         */
        private void addNewUserLabel_Click(object sender, EventArgs e)
        {
            AddNewUser addNewUserForm = new AddNewUser();
            settingUpRightSidePanel(addNewUserForm);
        }
        /*
         * When the Add New Vehicle User Label is clicked on, the form for adding a new car
         * is loaded on the right hand side panel
         */
        private void addNewVehicleLabel_Click(object sender, EventArgs e)
        {
            AddNewCar addNewCarForm = new AddNewCar();
            settingUpRightSidePanel(addNewCarForm);
        }
        /*
         * When the Add New Branch Label is clicked on, the form for adding a new branch
         * is loaded on the right hand side panel
         */
        private void addNewBranchLabel_Click(object sender, EventArgs e)
        {
            AddNewBranch addNewBranchForm = new AddNewBranch();
            settingUpRightSidePanel(addNewBranchForm);
        }
        /*
         * When the Add Vehicle Type Label is clicked on, the form for adding a new car
         * type is loaded on the right hand side panel
         */
        private void addVehicleTypeLabel_Click(object sender, EventArgs e)
        {
            AddNewCarType addNewCarType = new AddNewCarType();
            settingUpRightSidePanel(addNewCarType);
        }
        /*
         * When the Add New Booking Label is clicked on, the form for adding a new 
         * transaction is loaded on the right hand side panel
         */
        private void addNewBookingLabel_Click(object sender, EventArgs e)
        {
            AddNewBooking addNewBookingForm = new AddNewBooking();
            settingUpRightSidePanel(addNewBookingForm);
        }
    }
}
