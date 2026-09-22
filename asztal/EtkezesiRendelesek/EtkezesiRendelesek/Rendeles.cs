using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtkezesiRendelesek
{
    public class Rendeles
    {
        private int rendelesId;
        private List<string> etelek;
        private int ar;

        public Rendeles(int rendelesId, List<string> etelek, int ar)
        {
            this.rendelesId = rendelesId;
            this.etelek = etelek;
            this.ar = ar;
        }

        public void EtelHozzaadasa(string Etel)
        {
            etelek.Add(Etel);
        }

        public override string ToString()
        {
            return $"Rendelés ID: {rendelesId}, Ételek: {string.Join(", ", etelek)}, Ár: {ar}";
        }
    }
}
