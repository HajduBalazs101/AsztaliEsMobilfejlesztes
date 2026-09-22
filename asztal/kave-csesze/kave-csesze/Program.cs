using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kave_csesze
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kave k1 = new Kave(70, "espresso", 70);
            Console.WriteLine(k1);
            Console.WriteLine((k1.Ivas(30) ? "Sikeres ivás" : "Sikertelen Ivás"));
            Console.WriteLine(k1);
            Console.WriteLine((k1.Ivas(30) ? "Sikeres ivás" : "Sikertelen Ivás"));
            Console.WriteLine(k1);
            Console.WriteLine((k1.Ivas(30) ? "Sikeres ivás" : "Sikertelen Ivás"));
            Console.WriteLine(k1);
            Console.WriteLine();
            

            Console.WriteLine((k1.Ujratoltes(40, 70) ? "Sikeres újratöltés" : "Sikertelen újratöltés"));
            Console.WriteLine(k1);
            Console.WriteLine((k1.Ujratoltes(40, 70) ? "Sikeres újratöltés" : "Sikertelen újratöltés"));
            Console.WriteLine(k1);
            Console.WriteLine((k1.Ujratoltes(40, 70) ? "Sikeres újratöltés" : "Sikertelen újratöltés"));
            Console.WriteLine(k1);
            Console.WriteLine((k1.Ujratoltes(40, 70) ? "Sikeres újratöltés" : "Sikertelen újratöltés"));
            Console.WriteLine(k1);
            Console.WriteLine();


            Talca t1 = new Talca(3);
            Console.WriteLine(t1.ratesz(k1) ? "Sikeres": "Sikertelen");
            Console.WriteLine(t1);
            Console.WriteLine(t1.ratesz(k1) ? "Sikeres": "Sikertelen");
            Console.WriteLine(t1);
            Console.WriteLine(t1.ratesz(k1) ? "Sikeres": "Sikertelen");
            Console.WriteLine(t1);
            Console.WriteLine(t1.ratesz(k1) ? "Sikeres" : "Sikertelen");
            Console.WriteLine(t1);
            Console.WriteLine(t1.levesz(k1) ? "Sikeres": "Sikertelen");
            Console.WriteLine(t1);
            Console.WriteLine(t1.ratesz(k1) ? "Sikeres" : "Sikertelen");
            Console.WriteLine(t1);
            Console.WriteLine();

            Kave k2 = new Kave(70, "espresso", 70);
            Console.WriteLine(k2.Equals(k1)?"Megegyezik":"Nem egyezik meg");
            Kave k3 = new Kave("olcsó");
            Console.WriteLine(k3.Equals(k1)?"Megyegyezik":"Nem egyezik meg");


        }
    }
}
