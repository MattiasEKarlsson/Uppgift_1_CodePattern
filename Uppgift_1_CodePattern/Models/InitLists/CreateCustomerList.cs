using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Models.Customers;

namespace Uppgift_1_CodePattern.Models.InitLists
{
    internal class CreateCustomerList
    {
        public static List<ICustomer> CreateCustomers()
        {
            List<ICustomer> customers = new List<ICustomer>
        {
              new Owner { FirstName="Gustaf", LastName="Larsson", PhoneNumber="1111", Email="a@a.com" },
              new Owner { FirstName="Sven", LastName="Karlsson", PhoneNumber="2222", Email="b@a.com"  },
              new Owner { FirstName="Adolf", LastName="Andersson", PhoneNumber="3333", Email="c@a.com"},
              new Owner{ FirstName="Karl", LastName="Gustafsson", PhoneNumber="4444", Email="d@a.com" },
              new Owner { FirstName="Bert", LastName="Svensson", PhoneNumber="5555", Email="e@a.com" },
              new Owner { FirstName="John", LastName="Johnsson", PhoneNumber="6666", Email="f@a.com" }

        };
            return customers;
        }
    }
}
