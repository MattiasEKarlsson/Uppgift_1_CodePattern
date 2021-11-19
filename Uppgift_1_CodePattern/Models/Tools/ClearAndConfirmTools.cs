using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces.Tools;

namespace Uppgift_1_CodePattern.Models.Tools
{
    internal class ClearAndConfirmTools : ITools
    {
        public void ConfirmAndClearConsol(string message)
        {
            
            Console.WriteLine(message);
            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public void ErrorMessageConsol(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public void WaitForKeyPress()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
