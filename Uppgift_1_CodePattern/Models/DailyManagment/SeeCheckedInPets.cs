﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.DailyServices;
using Uppgift_1_CodePattern.Interfaces.Tools;

namespace Uppgift_1_CodePattern.Models.DailyManagment
{
    internal class SeeCheckedInPets : ISeeCheckedInPets
    {
        ITools _tools;
        public SeeCheckedInPets(ITools tools)
        {
            _tools = tools;
        }

        public void SeePetsAtKennel(List<IPet> pets)
        {
            IEnumerable<IPet> query = pets.Where(animal => animal.atKennel == true);
            Console.WriteLine($"{query.Count()} animals is at the kennel.");
            Console.WriteLine("**********************");
            foreach (IPet pet in query)
            {
                Console.WriteLine($"{pet.name} Owner:{pet.owner.firstName} Owners phonnumber: {pet.owner.phoneNumber}");
            }
            _tools.WaitForKeyPress();
        }
    }
}
