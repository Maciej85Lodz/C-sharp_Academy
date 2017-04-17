using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                Name = "Car1"
            };

            car.NameChanged = new NameChangedDelegate(Car_NameChanged);

            car.Name = "Car2";

            Console.ReadKey();
        }

        private static void Car_NameChanged(string oldName, string newName)
        {
            Console.WriteLine("Zmianna z {0} na {1}", oldName, newName);
        }
    }
}
