using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda
{
    class Program
    {
        private static readonly object cars;

        static void Main(string[] args)

        {


            {
                Car myNewCar = new Car();
                myNewCar.Drive();
                myNewCar.Color = "White";
                myNewCar.Brand = "Mercedes";

                Console.WriteLine(myNewCar);
            }

            List<Car> cars = NewMethod();



            // var bmws = from car in cars
            //            where car.Brand == "BMW"
            //            select car;

            // Console.WriteLine("BMW Collection")


            // foreach (var bmw in bmws)
            // {
            //     Console.WriteLine("Color = {0}, Year = {1}", bmw.Color, bemYear);
            // }

            var selected = cars.Where(p => p.Year == 2014);

            Console.WriteLine("My Collectios:");
            foreach (var mySelected in selected)
            {
                Console.WriteLine("Color = {0},Year = {1}", mySelected.Color, mySelected.Year);

            }

            Console.ReadKey();
        }

        private static List<Car> NewMethod()
        {
            return new List<Car>
           {
               new Car{Brand = "BMW", Color ="White", Year = 2014},
               new Car{Brand = "BMW", Color ="Red", Year = 2015},
               new Car{Brand = "AUDI", Color ="Green", Year = 2012},
               new Car{Brand = "AUDI", Color ="Grey", Year = 2014},

           };
        }
    }
}
