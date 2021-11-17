using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.Mangment;

namespace Uppgift_1_CodePattern.Models.Managment
{
    //Test
    internal class SeeOwnerFirstName : IPrintCustomerInfo
    {
        public void SeeAllCustomers(List<ICustomer> clients)
        {
            Console.WriteLine(clients[0].firstName);
        }
    }
}
