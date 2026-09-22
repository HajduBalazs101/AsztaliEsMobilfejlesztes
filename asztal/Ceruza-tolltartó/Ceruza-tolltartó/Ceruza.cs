using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceruza_tolltartó
{
    public class Ceruza
    {
        private bool hegyes { get; set; }
        private double hossz {  get; set; }
        private string szin { get; set; }
        private string kemenyseg { get; set; }

        public Ceruza(bool hegyes, double hossz, string szin, string kemenyseg)
        {
            this.hegyes = hegyes;
            this.hossz = hossz;
            this.szin = szin;
            this.kemenyseg = kemenyseg;
        }
        public Ceruza(string szin, string kemenyseg)
        {
            this.hegyes = true;
            this.hossz = 18;
            this.szin = szin;
            this.kemenyseg = kemenyseg;
        }

        public override string ToString()
        {
            return $"{szin} {kemenyseg} {hossz}cm {(hegyes?"hegyes":"tompa")}";
        }

        public bool Iras()
        {
            if (hegyes && hossz > 2)
            {
                hegyes = false;
                return true;
            }
            else
            {
                //nem használható
                return false ;
            }
        }

        public bool Faragas(int farag)
        {
            if (hossz-farag <= 2)
            {
                return false;
            }
            else
            {
                if(hegyes)
                    return true;
                else 
                { 
                    hossz -= farag;
                    hegyes = true;
                    return true;
                }
            }
        }

        public override bool Equals(object masik)
        {
            if(masik != null && masik is Ceruza)
            {
                Ceruza masikceruza = (Ceruza) masik;
                return this.kemenyseg == masikceruza.kemenyseg && this.szin == masikceruza.szin;
            }
            else 
            {
                return false;
            }
        }
    }
}
