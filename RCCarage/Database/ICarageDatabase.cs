using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCCarage.Database
{
    interface ICarageDatabase
    {
        IList<RCCar> GetAllCars();
    }
}
