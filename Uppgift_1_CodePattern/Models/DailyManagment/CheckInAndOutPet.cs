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
        

        public void CheckInPet(List<IPet> pets)
        {
            Console.WriteLine("Enter name of pet to check in:");
            string inputName = Console.ReadLine();
            if (inputName != null)
            {
                IPet pet = pets.FirstOrDefault(name => name.name.ToLower() == inputName.ToLower());
                if (pet != null)
                {
                    pet.atKennel = true;
                    
                    Console.WriteLine(pet.AskForTrimClaws()); 
                    
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
                if (pet != null && pet.atKennel == true)
                {
                    pet.atKennel = false;
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
