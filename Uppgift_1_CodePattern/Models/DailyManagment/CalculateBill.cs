using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.DailyServices;

namespace Uppgift_1_CodePattern.Models.DailyManagment
{
    internal class CalculateBill : ICalcBill
    {
        public void CalcTotal(IPet pet)
        {
            int total = StaticDetails.PricePerAnimal;
            IDog dog = (IDog)pet;
            if (dog.clawTrim)
            {
                total += StaticDetails.PriceTrim;
                Console.WriteLine($"Clawtrim: {StaticDetails.PriceTrim} kr");
            }
            if (dog.doWash)
            {
                total += StaticDetails.PricePerWash;
                Console.WriteLine($"Wash: {StaticDetails.PricePerWash} kr");
            }
            Console.WriteLine($"Total:{total}");
            Console.WriteLine($"Checked out {dog.name}");
        }
    }
}
