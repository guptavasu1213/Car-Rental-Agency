using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp
{
    public class Customer
    {
        public int ID { get; set; }

        public bool SelfServer { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string BDay { get; set; }

        public decimal PhoneNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string Country { get; set; }

        public string Insurance { get; set; }

        public string Drivers { get; set; }

        public string Status { get; set; }

        public string cardNumber { get; set; }

        public string cardType { get; set; }

        // password stored is hashed
        public string Password { get; set; }

        public Customer()
        {
            this.SelfServer = true;
        }
    }
}
