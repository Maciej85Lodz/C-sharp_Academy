using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //Typy wyliczeniowe

            //int friday = (int)Enums.Days.Friday;

            //Console.WriteLine(friday);

            //Console.WriteLine(friday.GetType());

            //Console.ReadKey();



            //Tablice
           //deklaracja Tablicy

            int[] numbersTab = new int[3];
            int[] numbersTab2 = { 1, 2, 3 };

            numbersTab[0] = 0;
            numbersTab[1] = 1;
            numbersTab[2] = 2;
            //numbersTab[3] = 3;

            //Console.WriteLine("Tab: ");
            //foreach (int number in numbersTab)
            //{
            //    Console.WriteLine(number);
            //}


            //Console.WriteLine("Index liczby 1 to: " + Array.BinarySearch(numbersTab, 1));

            //Array.Clear(numbersTab, 0, numbersTab.Length);

            //Console.WriteLine("ROZMIAR: " + numbersTab.Length);

            //Console.WriteLine("Element o indeksie 2 to: " + numbersTab[2]);

            //int index = Array.IndexOf(numbersTab, 2);
            //Console.WriteLine("Liczba 2 znajduje sie na indeksie z number: " + index);

            Console.ReadKey();
        }
    }
}
