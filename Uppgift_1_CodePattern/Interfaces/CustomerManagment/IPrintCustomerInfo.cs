using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1_CodePattern.Interfaces.Mangment
{
    internal interface IPrintCustomerInfo
    {
        void SeeAllCustomers(List<ICustomer> clients);
    }
}
