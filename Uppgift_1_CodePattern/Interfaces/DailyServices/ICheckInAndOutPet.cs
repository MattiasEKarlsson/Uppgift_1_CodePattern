using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Models;

namespace Uppgift_1_CodePattern.Interfaces.DailyServices
{
    internal interface ICheckInAndOutPet
    {
        void CheckInPet(List<IPet> pets);
        void CheckOutPet(List<IPet> pets);
    }
}
