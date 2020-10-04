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
            ICarageDatabase database = CarageDatabase.GetInstance();

            foreach (RCCar car in database.GetAllCars())
            {
                Console.WriteLine(car.Name);
            }
            
            Console.ReadKey();
        }
    }
}
