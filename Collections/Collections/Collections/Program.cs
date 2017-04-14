
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
                #region TypyWyliczeniowe


                //Typy wyliczeniowe

                //int friday = (int)Enums.Days.Friday;

                //Console.WriteLine(friday);

                //Console.WriteLine(friday.GetType());

                //Console.ReadKey();
                #endregion

                #region Tablice




                //Tablice
                //deklaracja Tablicy

                //int[] numbersTab = new int[3];
                //int[] numbersTab2 = { 1, 2, 3 };

                //numbersTab[0] = 0;
                //numbersTab[1] = 1;
                //numbersTab[2] = 2;
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

                //Console.ReadKey();

                #endregion

                #region List

                //List:

                //List<int> numberList = new List<int>();

                //numberList.Add(0);
                //numberList.Add(1);
                //numberList.Add(2);
                //numberList.Add(3);

                //Console.WriteLine("List: ");
                //foreach(int number in numberList)
                //{
                //    Console.WriteLine(number);

                //}

                //Console.WriteLine("Rozmiar listy to:" + numberList.Count);

                //bool isIn = numberList.Contains(1);

                //Console.WriteLine("Czy lista zawiera liczbe 1? " + isIn);

                //numberList.Remove(1);

                //isIn = numberList.Contains(1);

                //Console.WriteLine("Czy lista zawiera liczbe 1? " + isIn);


                //Console.WriteLine("Rozmiar listy to:" + numberList.Count);
                //Console.ReadKey();

                #endregion

                #region Dictionary:

                //Dictionary<int, string> myDictionary = new Dictionary<int, string>();
                //myDictionary.Add(1, "Auto1");
                //myDictionary.Add(2, "Auto2");
                //myDictionary.Add(3, "Auto3");

                //bool isIn = myDictionary.ContainsKey(1);

                ////Console.WriteLine("Czy slownik zawiera klucz z numberem 1? " + isIn);

                ////isIn = myDictionary.ContainsValue("Auto1");

                ////Console.WriteLine("Czy slownik zawiera wartość auto1? " + isIn);


                ////Console.WriteLine("Pod kluczem 1 znajduje sie: " + myDictionary[1]);

                //myDictionary.Remove(1);

                //Console.WriteLine("Rozmiar Slownika wynosi: " + myDictionary.Count);


                //Console.ReadKey();
                #endregion


                #region KeyValuePair

                //KeyValuePair

                //KeyValuePair<int, string> myKeyValue = new KeyValuePair<int, string>(1, "auto1");
                //KeyValuePair<int, string> myKeyValue2 = new KeyValuePair<int, string>(2, "auto2");
                //KeyValuePair<int, string> myKeyValue3 = new KeyValuePair<int, string>(3, "auto3");

                //List<KeyValuePair<int, string>> myKeyValuePairList = new List<KeyValuePair<int, string>>();
                //myKeyValuePairList.Add(myKeyValue);
                //myKeyValuePairList.Add(myKeyValue2);
                //myKeyValuePairList.Add(myKeyValue3);

                //foreach (var element in myKeyValuePairList)
                //{
                //    Console.WriteLine(element);
                //}

                //Console.ReadKey();

                #endregion

                #region Stack

                //Stack

                //Stack<string> myStack = new Stack<string>();

                //myStack.Push("Pierwszy element");
                //myStack.Push("Drugi element");
                //myStack.Push("Trzeci element");
                //myStack.Push("Czwarty element");

                //string stackElement = myStack.Peek();

                //Console.WriteLine("Peek() zwraca: " + stackElement);


                //string stackElement2 = myStack.Pop();

                //Console.WriteLine("Pop() zwraca: " + stackElement2);

                //Console.WriteLine("Rozmiar stosu to: " + myStack.Count);

                //myStack.Pop();
                //myStack.Pop();
                //myStack.Pop();

                //Console.WriteLine("Rozmiar stosu to: " + myStack.Count);

                //Console.ReadLine();

                #endregion


                #region Queue


                //Queue:

                Queue<string> myQueue = new Queue<string>();


                myQueue.Enqueue("Pierwszy element");
                myQueue.Enqueue("Drugi element");
                myQueue.Enqueue("Trzeci element");
                myQueue.Enqueue("Czwarty element");

                //string queuelement = myQueue.Peek();

                //Console.WriteLine("Peek zwraca: " + queuelement);

                string getFirst = myQueue.Dequeue();
                string getSecond = myQueue.Dequeue();


                //Console.WriteLine("First Element: " + getFirst);
                //Console.WriteLine("Second Element: " + getSecond);

                //Console.WriteLine("Rozmiar kolejki to:" + myQueue.Count);

                myQueue.Clear();

                Console.WriteLine("Rozmiar kolejki to:" + myQueue.Count);




                Console.ReadKey();
                #endregion





            }
        }
    }

    
