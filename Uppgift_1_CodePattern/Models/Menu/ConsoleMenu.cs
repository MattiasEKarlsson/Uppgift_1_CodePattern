using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.CustomerManagment;
using Uppgift_1_CodePattern.Interfaces.DailyServices;
using Uppgift_1_CodePattern.Interfaces.Mangment;
using Uppgift_1_CodePattern.Interfaces.PetMangment;


namespace Uppgift_1_CodePattern.Models
{
    internal class ConsoleMenu : IMainMenu
    {
        private readonly IPrintCustomerInfo _seeAllCustomers;
        private readonly IPrintAllPets _seeAllPets;
        private readonly ICreateCustomer _createCustomer;
        private readonly ICreatePet _createPet;
        private readonly ISeeCheckedInPets _seeCheckedInPets;
        private readonly ICheckInAndOutPet _checkInAndOutPet;

        public ConsoleMenu(IPrintCustomerInfo seeAllCustomers, IPrintAllPets seeAllPets, ICreateCustomer createCustomer, ICreatePet createPet, ISeeCheckedInPets seeCheckedInPets, ICheckInAndOutPet checkInAndOutPet)
        {
            _seeAllCustomers = seeAllCustomers;
            _seeAllPets = seeAllPets;
            _createCustomer = createCustomer;
            _createPet = createPet;
            _seeCheckedInPets = seeCheckedInPets;
            _checkInAndOutPet = checkInAndOutPet;
        }

        public void CreateMenu(List<ICustomer> customers, List<IPet> pets)
        {
            while (true)
            {
                Console.WriteLine("[1]Check in pet");
                Console.WriteLine("[2]Check out pet");
                Console.WriteLine("*************************");
                Console.WriteLine("[3]See pets at kennel");
                Console.WriteLine("[4]See all customers");
                Console.WriteLine("[5]See all pet");
                Console.WriteLine("*************************");
                Console.WriteLine("[6]Add customer");
                Console.WriteLine("[7]Add pet");
                Console.WriteLine("*************************");
                Console.WriteLine("[0]Exit application");

                var input = Console.ReadKey(true);
                string choice = input.KeyChar.ToString();
                if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5" && choice != "6" && choice != "7" && choice != "0" && choice != "8" && choice != "9")
                {
                    Console.Clear();

                }
                else
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Clear();
                            _checkInAndOutPet.CheckInPet(pets);

                            break;
                        case "2":
                            Console.Clear();
                            _checkInAndOutPet.CheckOutPet(pets);
                            break;
                        case "3":
                            Console.Clear();
                            _seeCheckedInPets.SeePetsAtKennel(pets);
                            break;
                        case "4":
                            Console.Clear();
                            _seeAllCustomers.SeeAllCustomers(customers);
                            break;
                        case "5":
                            Console.Clear();
                            _seeAllPets.PrintAllPets(pets);
                            break;
                        case "6":
                            Console.Clear();
                            customers.Add(_createCustomer.CreateCustomer());
                            break;
                        case "7":
                            Console.Clear();
                            pets.Add(_createPet.CreatePet(customers));
                            break;
                        case "0":
                            Environment.Exit(0);
                            break;
                        default:
                            
                            break;
                    }
                }
            }
        }
    }
}
