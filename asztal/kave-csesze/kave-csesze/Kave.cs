using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kave_csesze
{
    public class Kave
    {
        private double kaveMennyiseg; //ml
        private string kaveTipus;
        private double homerseklet; //fok
        private double maxkapacitas; //ml
        private bool tele;
        
        public Kave(double kaveMennyiseg, string kaveTipus, double homerseklet)
        {
            this.kaveMennyiseg = kaveMennyiseg;
            this.kaveTipus = kaveTipus;
            this.homerseklet = homerseklet;
            this.maxkapacitas = 100;
        }
        public Kave(string kaveTipus)
        {
            this.kaveMennyiseg = 150;
            this.kaveTipus = kaveTipus;
            this.homerseklet = 75.0;
        }

        public override string ToString()
        {
            return $"{kaveTipus} {kaveMennyiseg}ml, {homerseklet}fok";
        }
        public bool Ivas(double korty)
        {
            if (kaveMennyiseg-korty >= 0 && homerseklet >= 30) //hidegen nem iszunk kv-t
            {
                kaveMennyiseg -= korty;
                homerseklet -= 5;
                tele = false;
                return true;
            }
            return false;
        }

        public bool Ujratoltes(double ml, double ujHomerseklet)
        {
            if (ml <= 0 || tele == true) return false;
            if (kaveMennyiseg + ml > maxkapacitas) //ha meghaladná a max kapacitást akkor nem töltjük bele mindet
            {
                kaveMennyiseg = maxkapacitas;
            }
            else
            {
                kaveMennyiseg += ml; 
            }
            //de mindenképpen tele töltjük
            homerseklet = ujHomerseklet;
            if(kaveMennyiseg >= maxkapacitas)
            {
                tele = true;
            }
            return true;
        }

        public override bool Equals(object masik)
        {
            if (masik != null && masik is Kave)
            {
                Kave masikceruza = (Kave)masik;
                return this.kaveTipus == masikceruza.kaveTipus && this.homerseklet == masikceruza.homerseklet;
            }
            else
            {
                return false;
            }
        }
    }
}
