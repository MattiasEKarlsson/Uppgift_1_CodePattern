using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.DailyServices;

namespace Uppgift_1_CodePattern.Models.DailyManagment
{
    internal class SeeCheckedInPets : ISeeCheckedInPets
    {
        public void SeePetsAtKennel(List<IPet> pets)
        {
            IEnumerable<IPet> query = pets.Where(animal => animal.atKennel == true);
            Console.WriteLine($"{query.Count()} animals is at the kennel.");
            foreach (IPet pet in query)
            {
                Console.WriteLine($"{pet.name} Owner:{pet.owner.firstName} Owners phonnumber: {pet.owner.phoneNumber}");
            }
        }
    }
}
