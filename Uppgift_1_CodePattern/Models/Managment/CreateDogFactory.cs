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

        public CreateDogFactory(ITools tools, Dog.Factory factory)
        {
            _tools = tools;
            _factory = factory;
        }

        public IPet CreatePet(List<ICustomer> customers)
        {
           
            Console.WriteLine("Enter pets name:");
            string petName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter owners phonenumber:");
            string input = Console.ReadLine();
            Console.Clear();
            ICustomer owner = customers.FirstOrDefault(name => name.phoneNumber == input);
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
