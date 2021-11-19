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
    internal class SeeAllPets : IPrintAllPets
    {
        private readonly ITools _tools;
        public SeeAllPets(ITools tools)
        {
            _tools = tools;
        }
        public void PrintAllPets(List<IPet> pets)
        {
            Console.WriteLine("All Pets");
            Console.WriteLine("******************");

            foreach (var pet in pets)
            {
                Console.WriteLine($"{pet.Name} -- Owner: {pet.Owner.FirstName} {pet.Owner.LastName} -- Phone number: {pet.Owner.PhoneNumber}");
            }
            _tools.WaitForKeyPress();
        }
    }
}
