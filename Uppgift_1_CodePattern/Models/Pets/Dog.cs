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
            this.Name = name;
            this.Owner = owner;
            this.AtKennel = atKennel;
            this.DoWash = doWash;
            this.ClawTrim = clawTrim;
        }

        public Dog()
        {

        }
        public delegate Dog Factory(string name, ICustomer owner, bool atKennel, bool doWash, bool clawTrim);

        
        public string Name { get; set; }
        public ICustomer Owner { get; set; }
        public bool AtKennel { get; set; }
        public bool DoWash { get; set; }
        public bool ClawTrim { get; set; }

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
                
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
