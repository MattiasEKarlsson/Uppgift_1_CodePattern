using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Models.Pets;

namespace Uppgift_1_CodePattern.Models.InitLists
{
    internal class CreatePetList
    {
        public static List<IPet> CreatePets(List<ICustomer> customer)
        {
            List<IPet> pets = new List<IPet>
        {
              new Dog { Name="Fido", Owner = customer[0]},
              new Dog { Name="Ludde", Owner= customer[1], AtKennel=true },
              new Dog { Name="Max", Owner= customer[2]  },
              new Dog { Name="Sigge", Owner= customer[3], AtKennel=true   },
              new Dog { Name="Rocky", Owner= customer[4]  },
        };
            return pets;
        }
    }
}
