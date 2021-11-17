using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.ExtraServices;

namespace Uppgift_1_CodePattern.Models
{
    internal class Dog : IDog, ITrim
    {
        
        public string name { get; set; }
        public ICustomer owner { get; set; }
        public bool atKennel { get; set; }
        public bool doWash { get; set; }
        public bool clawTrim { get; set; }

        public bool AskForTrimClaws()
        {
            return true;
        }
    }
}
