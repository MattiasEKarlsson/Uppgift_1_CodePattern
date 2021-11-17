using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1_CodePattern.Interfaces.PetMangment
{
    internal interface IPrintAllPets
    {
        void PrintAllPets(List<IPet> pets);
    }
}
