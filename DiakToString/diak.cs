using System;
using System.Collections.Generic;
using System.Text;

namespace DiakApp
{
    internal class Diak
    {
        public string Nev { get; set; }
        public double Atlag { get; set; }

        public Diak()
        {
            Nev = "Hokhi Zoltán";
            Atlag = 5.0;
        }
        public Diak(string nev,double atlag)
        {
            Nev = nev;
            Atlag = atlag;
            
        }
        public Diak(double atlag)
        {
            Nev = "Betherp Eszter";
            Atlag = 4.0;
        }
        public override string ToString()
        {
            return $"nev:{Nev}\t atlag :{Atlag}";
        }
    }
}
