using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.Mangment;

namespace Uppgift_1_CodePattern.Models.Managment
{
    internal class SeeAllOwners : IPrintCustomerInfo
    {
        public void SeeAllCustomers(List<ICustomer> clients)
        {
            foreach (var client in clients)
            {
                Console.WriteLine($"{client.firstName} PhoneNumber:{client.phoneNumber} Email: {client.email} {client.GetType().Name.ToString()}");
            }
        }
    }
}
