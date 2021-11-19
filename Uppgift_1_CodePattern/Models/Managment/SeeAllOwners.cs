using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.Mangment;
using Uppgift_1_CodePattern.Interfaces.Tools;

namespace Uppgift_1_CodePattern.Models.Managment
{
    internal class SeeAllOwners : IPrintCustomerInfo
    {
        ITools _tools;

        public SeeAllOwners(ITools tools)
        {
            _tools = tools;
        }

        public void SeeAllCustomers(List<ICustomer> clients)
        {
            Console.WriteLine($"{clients.Count()} customers registered");
            Console.WriteLine("**********************");
            foreach (var client in clients)
            {
                Console.WriteLine($"{client.FirstName} {client.LastName} -- PhoneNumber:{client.PhoneNumber} -- Email: {client.Email}");
            }
            _tools.WaitForKeyPress();
        }
    }
}
