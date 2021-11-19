using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;

namespace Uppgift_1_CodePattern.Models.Pets
{
    internal class Dog : IDog
    {
        public Dog(string name, ICustomer owner, bool atKennel, bool doWash, bool clawTrim)
        {
            this.name = name;
            this.owner = owner;
            this.atKennel = atKennel;
            this.doWash = doWash;
            this.clawTrim = clawTrim;
        }

        public Dog()
        {

        }
        public delegate Dog Factory(string name, ICustomer owner, bool atKennel, bool doWash, bool clawTrim);

        //STOPP
        public string name { get; set; }
        public ICustomer owner { get; set; }
        public bool atKennel { get; set; }
        public bool doWash { get; set; }
        public bool clawTrim { get; set; }

        public bool AskForTrimClaws()
        {
            Console.WriteLine("Trim pet? Y/N");
            string input = Console.ReadLine().ToLower();
            Console.Clear();
            if (input == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AskForWash()
        {
            Console.WriteLine("Wash pet? Y/N");
            string input = Console.ReadLine().ToLower();
            Console.Clear();
            if (input == "y")
            {
                this.doWash = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
