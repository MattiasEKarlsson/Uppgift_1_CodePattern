using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.DailyServices;
using Uppgift_1_CodePattern.Interfaces.ExtraServices;
using Uppgift_1_CodePattern.Interfaces.Tools;

namespace Uppgift_1_CodePattern.Models.DailyManagment
{
    internal class CheckInAndOutPet : ICheckInAndOutPet
    {
        private readonly IDog _dog;
        private readonly ICalcBill _calcBill;
        private readonly ITools _tools;

        public CheckInAndOutPet(IDog dog, ICalcBill calcBill, ITools tools)
        {
            _dog = dog;
            _calcBill = calcBill;
            _tools = tools;
        }

        public void CheckInPet(List<IPet> pets)
        {
            Console.WriteLine("Enter name of pet to check in:");
            string inputName = Console.ReadLine();
            
                IPet pet = pets.FirstOrDefault(name => name.Name.ToLower() == inputName.ToLower());
                IDog dog = (IDog)pet;
                Console.Clear();

                if (dog != null && dog.AtKennel == false)
                {
                    dog.AtKennel = true;
                    dog.ClawTrim = _dog.AskForTrimClaws();
                    dog.DoWash = _dog.AskForWash();
                     if (dog.ClawTrim)
                     {
                        Console.WriteLine("Added trim today.");
                     }
                     if (dog.DoWash)
                     {
                         Console.WriteLine("Added a wash today.");
                     }
                     _tools.ConfirmAndClearConsol($"Checked in {dog.Name}");
                
                }
                else
                {
                    _tools.ErrorMessageConsol("Not found or already here.");
                }
            


        }

        public void CheckOutPet(List<IPet> pets)
        {
            Console.WriteLine("Enter name of pet to check out:");
            string inputName = Console.ReadLine();
                Console.Clear();
                IPet pet = pets.FirstOrDefault(name => name.Name.ToLower() == inputName.ToLower());
                IDog dog = (IDog)pet;
                if (dog != null && dog.AtKennel == true)
                {
                    dog.AtKennel = false;
                    _calcBill.CalcTotal(dog);
                    _tools.ConfirmAndClearConsol($"Checked out {dog.Name}");
                }
                else
                {
                _tools.ErrorMessageConsol("Not Found");
                }
        }
    }
}
