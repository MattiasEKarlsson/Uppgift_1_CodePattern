using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.DailyServices;
using Uppgift_1_CodePattern.Interfaces.ExtraServices;

namespace Uppgift_1_CodePattern.Models.DailyManagment
{
    internal class CheckInAndOutPet : ICheckInAndOutPet
    {
        private readonly IDog _dog;
        private readonly ICalcBill _calcBill;

        public CheckInAndOutPet(IDog dog, ICalcBill calcBill)
        {
            _dog = dog;
            _calcBill = calcBill;
        }

        public void CheckInPet(List<IPet> pets)
        {
            Console.WriteLine("Enter name of pet to check in:");
            string inputName = Console.ReadLine();
            if (inputName != null)
            {
                IPet pet = pets.FirstOrDefault(name => name.name.ToLower() == inputName.ToLower());
                IDog dog = (IDog)pet;
                if (pet != null)
                {
                    dog.atKennel = true;
                    dog.clawTrim = _dog.AskForTrimClaws();
                    dog.doWash = _dog.AskForWash();
                    


                    Console.WriteLine($"Checked in {pet.name}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }

            }
        }

        public void CheckOutPet(List<IPet> pets)
        {
            Console.WriteLine("Enter name of pet to check out:");
            string inputName = Console.ReadLine();
            if (inputName != null)
            {
                IPet pet = pets.FirstOrDefault(name => name.name.ToLower() == inputName.ToLower());
                IDog dog = (IDog)pet;
                if (dog != null && dog.atKennel == true)
                {
                    dog.atKennel = false;
                    _calcBill.CalcTotal(dog);
                    //_checkOutPet.CalcTotal(pet);
                }
                else
                {
                    Console.WriteLine("Not found");
                }

            }
        }
    }
}
