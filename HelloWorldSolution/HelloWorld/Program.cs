using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamenty
{
    class Program
    {
        static void Main(string[] args)
        {

            #region referencje

            
            int myValue = 10;
            int yourValue;
            yourValue = myValue;

            myValue = 5;

            Console.WriteLine("obraz Daniela: " + myValue);
            Console.WriteLine("Mój Obraz: " + yourValue);

            string carName = "Mój samochód Seat ALTEA XL";

            Car nataliaCar = new Car();
            nataliaCar.Color = "Red";
            Car maciejCar = new Car();
            maciejCar.Color = "Black";

            Console.WriteLine("Natalia Car: " + nataliaCar.Color);
            Console.WriteLine("Maciej Car: " + maciejCar.Color);

            nataliaCar = maciejCar;
            Console.WriteLine("Natalia car: " + nataliaCar.Color);



            nataliaCar.Color = "White";

            #endregion

            #region instukcje warunkowe


            double temperature = 30;
            if (temperature > 30)
            {
                Console.WriteLine("Gorąco");
            }
            else if(temperature == 30)
            {
                Console.WriteLine("Idealnie");
            }
        
            else
            {
                Console.WriteLine("Zimno");
            }
            Console.ReadKey();


            int value = 20;
            switch(value)
            {
                case 10:
                    Console.WriteLine("Value: " + value);
                    break;
                case 20:
                    Console.WriteLine("Value: " + value);
                    break;
                default:
                    Console.WriteLine("Value: " + value);
                    break;
            }
            


            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Iteruje: " + i);
            }
            List<string> lista = new List<string>();
            lista.Add("name1");
            lista.Add("name2");
            lista.Add("name3");
            lista.Add("name4");

            foreach (string name in lista)
            {
                Console.WriteLine(name);
            }


            int value1 = 1;
            while(value<10)
                {
                Console.WriteLine("Value: " + value1);
                value1++;
            }


            do
            {
                Console.WriteLine("Value: " + value1);
                value++;
            }
            while (value1 < 10);

            Console.ReadKey();
            #endregion
        }
    }
}
