using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.DailyServices;
using Uppgift_1_CodePattern.Interfaces.Tools;

namespace Uppgift_1_CodePattern.Models.DailyManagment
{
    internal class CalculateBill_Dog : ICalcBill
    {
        ITools _tools;

        public CalculateBill_Dog(ITools tools)
        {
            _tools = tools;
        }

        public void CalcTotal(IPet pet)
        {
            int total = StaticDetails.PricePerAnimal;
            IDog dog = (IDog)pet;

            Console.WriteLine($"Daily stay: {StaticDetails.PricePerAnimal} kr");
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
            Console.WriteLine($"---Total:{total}---");
        }
    }
}
