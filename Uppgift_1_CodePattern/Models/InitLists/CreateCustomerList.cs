using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;

namespace Uppgift_1_CodePattern.Models.InitLists
{
    internal class CreateCustomerList
    {
        public static List<ICustomer> CreateCustomers()
        {
            List<ICustomer> customers = new List<ICustomer>
        {
              new Owner { firstName="Gustaf", lastName="Larsson", phoneNumber="1111", email="a@a.com" },
              new Owner { firstName="Sven", lastName="Karlsson", phoneNumber="2222", email="b@a.com"  },
              new Owner { firstName="Adolf", lastName="Andersson", phoneNumber="3333", email="c@a.com"},
              new Owner { firstName="Karl", lastName="Gustafsson", phoneNumber="4444", email="d@a.com" },
              new Owner { firstName="Bert", lastName="Svensson", phoneNumber="5555", email="e@a.com" },
              new Owner { firstName="John", lastName="Johnsson", phoneNumber="6666", email="f@a.com" }

        };
            return customers;
        }
    }
}
