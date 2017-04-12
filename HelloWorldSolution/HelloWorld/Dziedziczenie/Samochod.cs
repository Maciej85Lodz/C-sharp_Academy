using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Dziedziczenie
{
    class Samochod:Pojazd
    {
        private string _jakiePaliwo;
        public Samochod(string marka, string model, int ileKol, int cena, string jakiePaliwo)
            : base(marka, model, ileKol, cena)
        {
            JakiePaliwo = jakiePaliwo;
        }
        //public Samochod(){}
        public string JakiePaliwo()
        {
            get
            {
                return _jakiePaliwo;
            }
            set
            {
                _jakiePaliwo = Value;
            }
        }



        public override void Jedz()
        {
            Console.WriteLine("Samochod jedzie i spala 8litrów/100kn...");
        }
    }
