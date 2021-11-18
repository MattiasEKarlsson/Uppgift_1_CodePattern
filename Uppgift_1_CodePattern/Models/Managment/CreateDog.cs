using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.PetMangment;
using Uppgift_1_CodePattern.Interfaces.Tools;

namespace Uppgift_1_CodePattern.Models.Managment
{
    internal class CreateDog : ICreatePet
    {
        private ITools _tools;

        public CreateDog(ITools tools)
        {
            _tools = tools;
        }

        public IPet CreatePet(List<ICustomer> customers)
        {
            IPet pet = new Dog();
            Console.WriteLine("Enter pets name:");
            pet.name = Console.ReadLine();
            Console.WriteLine("Enter owners phonenumber:");
            string input = Console.ReadLine();
            ICustomer owner = customers.FirstOrDefault(name => name.phoneNumber == input);
            if (owner != null)
            {
                pet.owner = owner;
                Console.WriteLine("Pet added!");
                _tools.ConfirmAndClearConsol("Pet successfully registered.");
                return pet;
            }
            else
            {
                _tools.ErrorMessageConsol("Could not find owner.");
            }
            return null;
        }
    }
}
