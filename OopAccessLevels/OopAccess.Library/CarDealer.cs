using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAccessLevels.Library
{
    public class CarDealer
    {
        void DealerPrintInventory()
        { 
            Car car = new Car();
            //private nu ma lasa
            //Console.WriteLine(car.manufacturer);

            //protected 
            //Console.WriteLine(car.model);
        }
    }
}
