using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceruza_tolltartó
{
    public class Tolltarto
    {
        private int maxhely;
        private List<Ceruza> ceruzak;
        private string marka;
        public Tolltarto(int maxhely, List<Ceruza> ceruzak, string marka)
        {
                this.maxhely = maxhely;
                this.ceruzak = ceruzak;
                this.marka = marka;
        }
        public Tolltarto(int maxhely, string marka)
        {
            this.maxhely = maxhely;
            this.ceruzak = new List<Ceruza>();
            this.marka = marka;
        }
        public  bool kivesz(Ceruza c)
        {
            return ceruzak.Remove(c);
        }

        public bool betesz(Ceruza c)
        {
            if(ceruzak.Count + 1 <= maxhely)
            { 
                ceruzak.Add(c);
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{marka}, {maxhely}db-os tolltartó. Jelenlegi ceruza lista: \n" +
                $"{String.Join("\n\t", ceruzak)}";
        }
    }
}
