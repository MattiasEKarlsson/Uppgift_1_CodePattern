using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;

namespace Uppgift_1_CodePattern.Models.Customers
{
    internal class OwnerFactory : ICustomer
    {
        public OwnerFactory(string firstName, string lastName, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public delegate OwnerFactory Factory(string firstName, string lastName, string phoneNumber, string email);


        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
    }
}
