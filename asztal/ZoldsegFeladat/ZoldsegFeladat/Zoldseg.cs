using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoldsegFeladat
{
    public class Zoldseg
    {
        protected string Nev { get; private set; }
        protected double Suly { get; private set; }
        protected double Kiloar { get; private set; }

        public Zoldseg(string nev, double suly, double kiloar)
        {
            Nev = nev;
            Suly = suly;
            Kiloar = kiloar;
        }
        public double Ar()
        {
            return Suly * Kiloar;
        }

        public override string ToString()
        {
            return $"Zöldség neve: {Nev}, Zöldség súlya: {Suly} kg, Zöldség ára kilónként: {Kiloar} Ft/kg, Ára: {Ar()} Ft";
        }

    }
}
