using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces.ExtraServices;

namespace Uppgift_1_CodePattern.Interfaces
{
    internal interface IDog : IPet, ITrim, IWash
    {
        bool doWash { get; set; }
        bool clawTrim { get; set; }
    }
}
