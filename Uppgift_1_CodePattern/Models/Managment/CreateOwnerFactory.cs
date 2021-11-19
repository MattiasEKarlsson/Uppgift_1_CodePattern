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
        private IAskForInput _askForInput;



        public CreateOwnerFactory(Owner.Factory factory, ITools tools, IAskForInput askForInput)
        {
            _factory = factory;
            _tools = tools;
            _askForInput = askForInput;
        }

        public ICustomer CreateCustomer()
        {
            string firstName = _askForInput.AskForInput("first name:", 3);
            string lastName = _askForInput.AskForInput("last name:", 3);
            string phoneNumber = _askForInput.AskForInput("phonenumber:",8);
            string email = _askForInput.AskForInput("email address:", 5);

            ICustomer customer = _factory(firstName, lastName, phoneNumber, email);
            _tools.ConfirmAndClearConsol("Customer added.");
            
            return customer;
            
        }
        
    }
}
