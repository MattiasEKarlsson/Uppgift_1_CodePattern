using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.Mangment;

namespace Uppgift_1_CodePattern.Models.Managment
{
    internal class SeeAllCats : IPrintAllCats
    {
        public void PrintAllCats(List<IPet> pets)
        {
            Console.WriteLine("All Cats");
            Console.WriteLine("---------------------");
            IEnumerable<IPet> cats = pets.Where(x => x.GetType().Name.ToString() == "Cat").ToList();
            
            foreach (var cat in cats)
            {
                Console.WriteLine($"{cat.name} Owner: {cat.owner.firstName} Phone: {cat.owner.phoneNumber} AtKennel: {cat.atKennel}");
            }
        }
    }
}
