using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.CustomerManagment;

namespace Uppgift_1_CodePattern.Models.Managment
{
    internal class CreateOwner : ICreateCustomer
    {
        public readonly ICustomer _customer;

        public CreateOwner(ICustomer customer)
        {
            _customer = customer;
        }

        public ICustomer CreateCustomer()
        {

            Console.WriteLine("Enter first name:");
            _customer.firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            _customer.lastName = Console.ReadLine();
            Console.WriteLine("Enter phonenumber:");
            _customer.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            _customer.email = Console.ReadLine();

            return _customer;
        }

       
    }
}
