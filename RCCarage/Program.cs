using RCCarage.AppLogic;
using RCCarage.CLI;
using RCCarage.Database;
using RCCarage.Database.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCCarage
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new Menu();
            menu.Run();
        }
    }
}
