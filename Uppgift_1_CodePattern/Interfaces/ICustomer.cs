using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1_CodePattern.Interfaces
{
    internal interface ICustomer
    {
        string firstName { get; set; }
        string lastName { get; set; }
        string phoneNumber { get; set; }
        string email { get; set; }
    }
}
