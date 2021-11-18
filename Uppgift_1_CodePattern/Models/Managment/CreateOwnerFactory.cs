using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.CustomerManagment;
using Uppgift_1_CodePattern.Models.Customers;

namespace Uppgift_1_CodePattern.Models.Managment
{
    internal class CreateOwnerFactory : ICreateCustomer
    {
        private OwnerFactory.Factory _factory;

        public CreateOwnerFactory(OwnerFactory.Factory factory)
        {
            _factory = factory;
        }

        public ICustomer CreateCustomer()
        {
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter phonenumber:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();

            ICustomer cus = _factory(firstName, lastName, phoneNumber, email);
            Console.Clear();
            Console.WriteLine("Customer added.");
            Thread.Sleep(2000);
            Console.Clear();
            return cus;
        }
    }
}
