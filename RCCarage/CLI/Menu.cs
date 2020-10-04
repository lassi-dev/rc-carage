using RCCarage.AppLogic;
using RCCarage.Database;
using RCCarage.Database.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCCarage.CLI
{
    class Menu : IMenu
    {
        private static ICarageDatabase Database = CarageDatabase.GetInstance();

        public void Run()
        {
            bool exitCode = false;

            while(!exitCode)
            {
                PrintMenu();
                exitCode = true;
                Console.ReadKey();
            }

        }

        private void PrintMenu()
        {
            foreach (Texts.MenuTexts text in Enum.GetValues(typeof(Texts.MenuTexts)).Cast<Texts.MenuTexts>())
            { 
                Console.WriteLine("[{0}] {1}", (int)text, Texts.getStringByText(text));
            }
        }

        private void PrintAllCars()
        {
            foreach (RCCar car in Database.GetAllCars())
            {
                Console.WriteLine(car.Name);
            }
        }
    }
}
