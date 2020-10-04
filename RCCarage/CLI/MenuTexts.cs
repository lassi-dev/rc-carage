using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCCarage.CLI
{
    class Texts
    {
        public enum MenuTexts
        {
            SaveCar,
            GetAllCars
        }

        public enum GeneralTexts
        {
            InputCarName
        }

        private static readonly Dictionary<MenuTexts, string> MenuTextDictionary =
            new Dictionary<MenuTexts, string>()
            {
                { MenuTexts.SaveCar, "Store a car." },
                { MenuTexts.GetAllCars, "List all cars." }
            };

        public static string getStringByText(MenuTexts text)
        {
            return MenuTextDictionary[text];
        }
    }
}
