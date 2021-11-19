using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces.ExtraServices;

namespace Uppgift_1_CodePattern.Interfaces
{
    internal interface IPet 
    {
        
        string Name { get; set; }
        ICustomer Owner { get; set; }
        bool AtKennel { get; set; }
    }
}
