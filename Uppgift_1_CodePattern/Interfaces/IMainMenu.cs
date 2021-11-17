using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1_CodePattern.Interfaces
{
    internal interface IMainMenu
    {
        void CreateMenu(List<ICustomer> customers, List<IPet> pets);

    }
}
