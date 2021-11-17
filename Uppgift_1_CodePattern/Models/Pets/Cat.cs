using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;

namespace Uppgift_1_CodePattern.Models.Pets
{
    internal class Cat : IPet
    {
        
        public string name { get; set; }
        public ICustomer owner { get; set; }
        public bool atKennel { get; set; }

        public int clawLeanth { get; set; }

        public bool AskForTrimClaws()
        {
            return true;
        }
    }
}
