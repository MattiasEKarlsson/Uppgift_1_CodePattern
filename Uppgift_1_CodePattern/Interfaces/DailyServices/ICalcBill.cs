using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1_CodePattern.Interfaces.DailyServices
{
    internal interface ICalcBill
    {
        void CalcTotal(IPet pet);
    }
}
