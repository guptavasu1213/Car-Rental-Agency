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

        private void addUserLabel_Click(object sender, EventArgs e)
        {

        }

        private void findEmployeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void addEmployeeLabel_Click(object sender, EventArgs e)
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
            setBackgroundOnMouseHover(addUserLabel);
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
            setBackgroundOnMouseLeave(addUserLabel);
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
            setBackgroundOnMouseHover(addBookingLabel);
        }

        private void addBookingLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(addBookingLabel);
        }

        private void findBranchLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(findBranchLabel);
        }

        private void findBranchLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(findBranchLabel);
        }

        private void addBranchLabel_MouseHover(object sender, EventArgs e)
        {
            setBackgroundOnMouseHover(addBranchLabel);
        }

        private void addBranchLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(addBranchLabel);
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
            setBackgroundOnMouseHover(addVehicleLabel);
        }

        private void addVehicleLabel_MouseLeave(object sender, EventArgs e)
        {
            setBackgroundOnMouseLeave(addVehicleLabel);
        }

        private void leftSidePanel_Paint(object sender, PaintEventArgs e)
        {

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

        private void popularCarLabel_Click(object sender, EventArgs e)
        {
            PopularCar popularCarForm = new PopularCar(); // Creating the form 
            settingUpRightSidePanel(popularCarForm);
        }

        private void findUserLabel_Click(object sender, EventArgs e)
        {
            AdminLogin loginForm = new AdminLogin(); // Creating the form 
            settingUpRightSidePanel(loginForm);
        }
    }
}
