using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myNewCar = new Car();
            myNewCar.Drive();
            myNewCar.Color = "White";
            myNewCar.Brand = "Mercedes";






        //    var cars = new List<Car>
        //            {
        //                new Car { Brand = "BMW", COLOR = "Black", Year = 1990 };
        //    new Car { Brand = "BMW", COLOR = "Red", Year = 1992 };
        //    new Car { Brand = "Audi", COLOR = "Blue", Year = 1998 };
        //    new Car { Brand = "Ford", COLOR = "Black", Year = 1990 };
        

        //var bmws = from car in cars
        //           where car.Brand == "BMW"


            Console.ReadKey();
        }
        

}
}
