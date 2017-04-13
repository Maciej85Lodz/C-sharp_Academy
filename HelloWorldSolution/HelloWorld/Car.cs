using Fundamenty.Poliformizm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamenty
{
    class Car:IPojazd
    {
        public string Color { get; set; }
        string IPojazd.myProperty
        { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IPojazd.Marka { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IPojazd.Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IPojazd.ileKol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IPojazd.Cena { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IPojazd.Jedz()
        {
            throw new NotImplementedException();
        }
    }
}
