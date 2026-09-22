using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceruza_tolltartó
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ceruza c1 = new Ceruza(false, 24, "grafit", "B2");
            Console.WriteLine(c1);
            Console.WriteLine(c1.Faragas(5)?"Sikeres faragás":"Nem lehet faragni");
            Console.WriteLine(c1.Iras()?"Sikeres írás":"Sikertelen írás");
            Console.WriteLine(c1.Faragas(5)?"Sikeres faragás":"Nem lehet faragni");
            Console.WriteLine(c1.Iras() ? "Sikeres írás" : "Sikertelen írás");
            Console.WriteLine(c1.Faragas(5)?"Sikeres faragás":"Nem lehet faragni");
            Console.WriteLine(c1.Iras() ? "Sikeres írás" : "Sikertelen írás");
            Console.WriteLine(c1.Faragas(5)?"Sikeres faragás":"Nem lehet faragni");
            Console.WriteLine(c1.Iras() ? "Sikeres írás" : "Sikertelen írás");
            Console.WriteLine(c1.Faragas(3) ? "Sikeres faragás" : "Nem lehet faragni");
            Console.WriteLine(c1.Iras() ? "Sikeres írás" : "Sikertelen írás");
            Console.WriteLine(c1);

            Ceruza c2 = new Ceruza("grafit", "B2");
            Console.WriteLine(c2.Equals(c1)?"Megegyezik":"Nem egyezik");
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine("null teszt: " + (c2.Equals(null)?"Megegyezik":"Nem egyezik"));
            Console.WriteLine("más teszt: " + (c2.Equals("ceruza")?"Megegyezik":"Nem egyezik"));


            Tolltarto t1 = new Tolltarto(10, "OEM");
            Console.WriteLine(t1.betesz(c1) ? "Sikeres" : "Sikertelen");
            Console.WriteLine(t1.betesz(c1) ? "Sikeres" : "Sikertelen");
            Console.WriteLine(t1.betesz(c2) ? "Sikeres" : "Sikertelen");
            Console.WriteLine(t1.kivesz(c2) ? "Sikeres" : "Sikertelen");
            Console.WriteLine(t1.kivesz(c1)? "Sikeres": "Sikertelen");
            Console.WriteLine();
            Console.WriteLine(t1);


        }
    }
}
