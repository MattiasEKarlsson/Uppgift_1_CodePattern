using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces.Tools;

namespace Uppgift_1_CodePattern.Models.Tools
{
    internal class AskForInput : IAskForInput
    {
        IValidations _validate;
        ITools _tools;

        public AskForInput(IValidations validate, ITools tools)
        {
            _validate = validate;
            _tools = tools;
        }

        string IAskForInput.AskForInput(string input, int inputLenth)
        {
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine($"Enter {input}");
                string userInput = Console.ReadLine();

                if (_validate.CheckIfValidString(userInput, inputLenth))
                {
                    validInput = true;
                    Console.Clear();
                    return userInput;
                }
                else
                {
                    _tools.ErrorMessageConsol("Invalid input");
                }
            }
            return null;
        }
    }
}
