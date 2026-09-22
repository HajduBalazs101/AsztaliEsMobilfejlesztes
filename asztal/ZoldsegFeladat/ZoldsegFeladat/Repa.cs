using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoldsegFeladat
{
    public class Repa : Zoldseg
    {

        private double Hossz;
        public Repa(double suly, double kiloar, double hossz) : base("Répa", suly, kiloar)
        {
            this.Hossz = hossz;
        }
        public override string ToString()
        {

            return $"Zöldség neve: {Nev}, Zöldség súlya: {Suly} kg, Zöldség ára kilónként: {Kiloar} Ft/kg, Zöldség hossza: {Hossz} cm, Ára: {Ar()} Ft";
        }
    }
}
