using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces.Tools;

namespace Uppgift_1_CodePattern.Models.Tools
{
    internal class Validate : IValidations
    {
        public bool CheckIfValidString(string input, int inputLenth)
        {
            if (input.Length < inputLenth)
            {
                return false;
            }
            return true;
        }
    }
}
