using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCCarage.Database.Implementation
{
    class CarageDatabase : ICarageDatabase
    {
        private IList<RCCar> Cars;
        private static CarageDatabase Instance;

        public static ICarageDatabase GetInstance()
        {
            if (Instance == null)
            {
                Instance = new CarageDatabase();
            }
            return Instance;
        }

        public IList<RCCar> GetAllCars()
        {
            return Cars;
        }

        private CarageDatabase()
        {
            this.Cars = new List<RCCar>() { new RCCar("A car") };
        }
    }
}
