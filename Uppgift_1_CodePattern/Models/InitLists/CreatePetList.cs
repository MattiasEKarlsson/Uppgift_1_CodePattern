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
              new Dog { name="Fido", owner = customer[0]},
              new Dog { name="Ludde", owner= customer[1], atKennel=true },
              new Dog { name="Max", owner= customer[2]  },
              new Dog { name="Sigge", owner= customer[3], atKennel=true   },
              new Dog { name="Rocky", owner= customer[4]  },
        };
            return pets;
        }
    }
}
