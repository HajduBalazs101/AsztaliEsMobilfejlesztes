using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoldsegFeladat
{
    public class Krumpli : Zoldseg
    {
        private string Fajta;

        public Krumpli(string fajta, double suly, double kiloar) : base("Krumpli", suly, kiloar)
        {
            this.Fajta = fajta;
        }

        public override string ToString()
        {
            return $"Zöldség neve: {Nev}, Zöldség súlya: {Suly} kg, Zöldség ára kilónként: {Kiloar} Ft/kg, Zöldség fajtája: {Fajta}, Ára: {Ar()} Ft";
        }
    }
}
