using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionsAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myTab = new int[2];
                myTab[0] = 1;
                myTab[1] = 2;
                int element = myTab[10];
            }

            catch(IndexOutOfRangeException exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            catch(Exception exception)
            {
                Console.WriteLine("Other exception: " + exception.Message);
            }
            Console.ReadKey();
        }
    }
}
