using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.PetMangment;

namespace Uppgift_1_CodePattern.Models.Managment
{
    internal class SeeAllPets : IPrintAllPets
    {
        public void PrintAllPets(List<IPet> pets)
        {
            Console.WriteLine("All Pets");
            Console.WriteLine("---------------------");
            
            foreach (var pet in pets)
            {
                Console.WriteLine($"{pet.name} Owner: {pet.owner.firstName} Phone: {pet.owner.phoneNumber} AtKennel: {pet.atKennel}");
            }
        }
    }
}
