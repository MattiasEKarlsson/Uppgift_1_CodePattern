using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.PetMangment;
using Uppgift_1_CodePattern.Interfaces.Tools;
using Uppgift_1_CodePattern.Models.Pets;

namespace Uppgift_1_CodePattern.Models.Managment
{
    internal class CreateDogFactory : ICreatePet
    {
        private ITools _tools;
        private Dog.Factory _factory;
        private IAskForInput _askForInput;

        public CreateDogFactory(ITools tools, Dog.Factory factory, IAskForInput askForInput)
        {
            _tools = tools;
            _factory = factory;
            _askForInput = askForInput;
        }

        public IPet CreatePet(List<ICustomer> customers)
        {
            string petName = _askForInput.AskForInput("pets name:", 3);
            string input = _askForInput.AskForInput("owners phonenumber:", 4);
            
            ICustomer owner = customers.FirstOrDefault(name => name.PhoneNumber == input);
            if (owner != null)
            {
                ICustomer customer = owner;
                _tools.ConfirmAndClearConsol("Pet successfully registered.");
                return _factory(petName, customer, false, false, false);
            }
            else
            {
                _tools.ErrorMessageConsol("Could not find owner.");
            }
            return null;
        }
    }
}
