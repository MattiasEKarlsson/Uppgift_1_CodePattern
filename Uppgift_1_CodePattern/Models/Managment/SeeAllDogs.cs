using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.Mangment;

namespace Uppgift_1_CodePattern.Models.Managment
{
    internal class SeeAllDogs : IPrintAllDogs
    {
        public void PrintAllDogs(List<IPet> pets)
        {
            Console.WriteLine("All Dogs");
            Console.WriteLine("---------------------");
            IEnumerable<IPet> dogs = pets.Where(x => x.GetType().Name.ToString() == "Dog").ToList();      
            foreach (var dog in dogs)
            {
                Console.WriteLine($"{dog.name} Owner: {dog.owner.firstName} Phone: {dog.owner.phoneNumber} AtKennel: {dog.atKennel}");
            }
        }
    }
}
