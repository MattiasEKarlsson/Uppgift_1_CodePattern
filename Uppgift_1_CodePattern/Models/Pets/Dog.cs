using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.ExtraServices;

namespace Uppgift_1_CodePattern.Models
{
    internal class Dog : IDog
    {
        
        public string name { get; set; }
        public ICustomer owner { get; set; }
        public bool atKennel { get; set; }
        public bool doWash { get; set; }
        public bool clawTrim { get; set; }

        public bool AskForTrimClaws()
        {
            Console.WriteLine("Trim pet? Y/N");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {

                Console.WriteLine("Trim added.");
                return true;

            }
            else
            {
                Console.WriteLine("No trim today.");
                return false;
            }
        }

        public bool AskForWash()
        {
            Console.WriteLine("Wash pet? Y/N");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                this.doWash = true;
                Console.WriteLine("Wash added.");
                return true;
            }
            else
            {
                Console.WriteLine("No wash today.");
                return false;
            }
        }
    }
}
