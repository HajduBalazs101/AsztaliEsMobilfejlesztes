using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtkezesiRendelesek
{
    public class ElvitelreRendeles : Rendeles
    {
        private string cim;
        private string futarneve;

        public ElvitelreRendeles(int rendelesId, List<string> etelek, int ar, string cim, string futarneve) : base(rendelesId, etelek, ar)
        {
            this.cim = cim;
            this.futarneve = futarneve;
        }

        public override string ToString()
        {
            return base.ToString() + $", Cím: {cim}, Futár neve: {futarneve}";
        }

    }
}
