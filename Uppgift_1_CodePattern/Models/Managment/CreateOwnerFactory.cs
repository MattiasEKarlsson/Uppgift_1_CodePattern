using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.CustomerManagment;
using Uppgift_1_CodePattern.Interfaces.Tools;
using Uppgift_1_CodePattern.Models.Customers;

namespace Uppgift_1_CodePattern.Models.Managment
{
    internal class CreateOwnerFactory : ICreateCustomer
    {
        private Owner.Factory _factory;
        private ITools _tools;



        public CreateOwnerFactory(Owner.Factory factory, ITools tools)
        {
            _factory = factory;
            _tools = tools;
        }

        public ICustomer CreateCustomer()
        {
            
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter phonenumber:");
            string phoneNumber = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            Console.Clear();

            ICustomer customer = _factory(firstName, lastName, phoneNumber, email);
            _tools.ConfirmAndClearConsol("Customer added.");
            
            return customer;
            
        }
        
    }
}
