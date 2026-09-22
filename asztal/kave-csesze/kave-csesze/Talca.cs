using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kave_csesze
{
    public class Talca
    {
        private int maxhely;
        private List<Kave> cseszek = new List<Kave>();

        public Talca (int maxhely)
        {
            this.maxhely = maxhely;
            
        }

        public bool ratesz(Kave k)
        {
            if (cseszek.Count + 1 <= maxhely)
            {
                cseszek.Add(k);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool levesz(Kave k)
        {
            return cseszek.Remove(k);
        }

        public override string ToString()
        {
            return $"{maxhely} hely-el rendelkező tálca, jelenlegi csészék rajta: \n" +
                $"{String.Join("\n\t", cseszek)}";
        }
    }

}
