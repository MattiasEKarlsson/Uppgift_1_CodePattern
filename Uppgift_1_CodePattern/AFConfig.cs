using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.CustomerManagment;
using Uppgift_1_CodePattern.Interfaces.DailyServices;
using Uppgift_1_CodePattern.Interfaces.ExtraServices;
using Uppgift_1_CodePattern.Interfaces.Mangment;
using Uppgift_1_CodePattern.Interfaces.PetMangment;
using Uppgift_1_CodePattern.Models;
using Uppgift_1_CodePattern.Models.DailyManagment;
using Uppgift_1_CodePattern.Models.Managment;
using Uppgift_1_CodePattern.Models.Pets;

namespace Uppgift_1_CodePattern
{
    internal class AFConfig
    {
        public static IContainer Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<ConsoleMenu>().As<IMainMenu>();
            builder.RegisterType<CreateOwner>().As<ICreateCustomer>();
            builder.RegisterType<CreateDog>().As<ICreatePet>();
            builder.RegisterType<SeeAllOwners>().As<IPrintCustomerInfo>();
            builder.RegisterType<SeeCheckedInPets>().As<ISeeCheckedInPets>();
            builder.RegisterType<SeeAllPets>().As<IPrintAllPets>();
            builder.RegisterType<SeeAllDogs>().As<IPrintAllDogs>();
            builder.RegisterType<SeeAllCats>().As<IPrintAllCats>();
            builder.RegisterType<CheckInAndOutPet>().As<ICheckInAndOutPet>();
            builder.RegisterType<Owner>().As<ICustomer>();
            builder.RegisterType<Dog>().As<IDog>();
            builder.RegisterType<CalculateBill_Dog>().As<ICalcBill>();





            return builder.Build();
        }
    }
}
