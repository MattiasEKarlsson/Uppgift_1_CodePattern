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
        private readonly IPrintAllDogs _seeAllDogs;
        private readonly IPrintAllCats _seeAllCats;
        private readonly IPrintAllPets _seeAllPets;
        private readonly ICreateCustomer _createCustomer;
        private readonly ICreatePet _createPet;
        private readonly ISeeCheckedInPets _seeCheckedInPets;
        private readonly ICheckInAndOutPet _checkInAndOutPet;

        public ConsoleMenu(IPrintCustomerInfo seeAllCustomers, IPrintAllDogs seeAllDogs, IPrintAllCats seeAllCats, IPrintAllPets seeAllPets, ICreateCustomer createCustomer, ICreatePet createPet, ISeeCheckedInPets seeCheckedInPets, ICheckInAndOutPet checkInAndOutPet)
        {
            _seeAllCustomers = seeAllCustomers;
            _seeAllDogs = seeAllDogs;
            _seeAllCats = seeAllCats;
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
                Console.WriteLine("[1]Check in animal");
                Console.WriteLine("[2]Check out animal");
                Console.WriteLine(" ");
                Console.WriteLine("[3]See animals at kennel");
                Console.WriteLine("[4]See all clients");
                Console.WriteLine("[5]See all Pets");
                Console.WriteLine("[6]See all Dogs");
                Console.WriteLine("[7]See all Cats");
                Console.WriteLine(" ");
                Console.WriteLine("[8]Add client");
                Console.WriteLine("[9]Add animal");
                Console.WriteLine("[0]Exit application");

                string choise = Console.ReadLine();
                if (choise != "1" && choise != "2" && choise != "3" && choise != "4" && choise != "5" && choise != "6" && choise != "7" && choise != "0" && choise != "8" && choise != "9")
                {
                    Console.WriteLine("Invalid option");

                }
                else
                {
                    switch (choise)
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
                            _seeAllDogs.PrintAllDogs(pets);
                            break;
                        case "7":
                            Console.Clear();
                            _seeAllCats.PrintAllCats(pets);
                            break;
                        case "8":
                            Console.Clear();
                            customers.Add(_createCustomer.CreateCustomer());
                            break;
                        case "9":
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
