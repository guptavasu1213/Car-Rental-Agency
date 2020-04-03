using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp
{
    class Employee : Customer
    {
        public string Branch { get; set; }

        public decimal Salary { get; set; }

        public string EmploymentType { get; set; }

        public int SIN { get; set; }

        public string Position { get; set; }
        
        public Employee()
        {
            this.Status = "Active";
        }
    }
}
