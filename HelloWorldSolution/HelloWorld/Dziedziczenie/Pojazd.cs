using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Dziedziczenie
{
    class Pojazd
    {
        private string _marka;
        private string _model;
        private int _ileKol;
        private int _cena;


        public string Marka
        {
            get
            {
                return _marka;
            }
            set
            {
                _marka = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public int IleKol
        {
            get
            {
                return _ileKol;
            }
            set
            {
                _ileKol = value;
            }
        }
        public int Cena
        {
            get
            {
                return _cena;
            }
            set
            {
                _cena = value;
            }
        }

        public Pojazd(string marka,string model)
        {
            Marka = marka;
            Model = model;
        }

        public Pojazd(string marka, string model, int ileKol, int cena)
        {
            Marka = marka;
            Model = model;
            IleKol = ileKol;
            Cena = cena;
        }

        public Pojazd() { }

        public Pojazd(string marka, int ileKol, int cena)
        {
            Marka = marka;
            IleKol = ileKol;
            Cena = cena;
        }

        public virtual void Jedz()
        {
            Console.WriteLine("Pojazd Jedzie...");
        }
    }
}
