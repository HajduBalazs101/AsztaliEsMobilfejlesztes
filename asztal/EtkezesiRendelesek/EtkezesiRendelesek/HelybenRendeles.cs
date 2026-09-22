using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtkezesiRendelesek 
{
    public class HelybenRendeles : Rendeles
    {
        private int asztalSzam;
        
        public HelybenRendeles(int rendelesId, List<string> etelek, int ar, int asztalSzam) : base(rendelesId, etelek, ar)
        {
            this.asztalSzam = asztalSzam;
        }
        public override string ToString()
        {
            return base.ToString() + $", Asztal Szám: {asztalSzam}";
        }   
        
    }
}
