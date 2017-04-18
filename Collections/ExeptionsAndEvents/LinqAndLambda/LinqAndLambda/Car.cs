using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda
{
    class Car
    {
        private string _brand;
        private string _color;
        private int _year;

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                if (value != null)
                    _brand = value;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (value != null)
                    _color = value;
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (_year != 0)
                    _year = value;
            }
        }
        public Car() { }
        public Car(string brand, string color)
        {
            Brand = brand;
            Color = color;
        }
        /// <summary>
        /// Metoda która wprowadza w ruch auto
        /// </summary>
        public void Drive()
        {
            Console.WriteLine("Auto jedzie");
            checkOil();
        }
        //TODO: można rozszerzyć tę metodę o dokładne szczegóły dotyczące oleju
        
        private void checkOil()
        {
            Console.WriteLine("Sprawdzam stan oleju..., OK");
        }


    }
}
