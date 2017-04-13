using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamenty.Poliformizm
{
    public interface IPojazd
    {
        //string _marka = '';
        //string _model;
        //int _ileKol;
        //int _cena;
        string myProperty { get; set; }
        //     pojazd IPojazd(){}

        string Marka { get; set; }
        string Model { get; set; }

        int ileKol { get; set; }

        int Cena { get; set; }


        void Jedz();
    }
}
