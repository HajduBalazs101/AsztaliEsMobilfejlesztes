using System.Linq.Expressions;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> jegyek = new List<int>();
        while(true)
        {
            Console.Clear();
            Console.WriteLine("1. Új jegy rögzítése");
            Console.WriteLine("2. Jegy törlése");
            Console.WriteLine("3. Átlag számítás");
            Console.WriteLine("4. Jegyek listázása");
            Console.WriteLine("5. Minden jegy törlése");
            Console.WriteLine("6. Kilépés");
            string valasztas = Console.ReadLine();
            switch (valasztas)
            {
                case "1":
                    Console.Clear();
                    
                    Console.Write("Adja meg a rögzítendő jegyet: ");
                    int szam;
                    if (int.TryParse(Console.ReadLine(), out szam) && szam >= 1 && szam <= 5)
                        jegyek.Add(szam);
                    else
                        Console.WriteLine("Nem megfelelő adatot adott meg! (1-5)");
                    break;

                case "2":
                    for(int i = 0; i < jegyek.Count; i++)
                    {
                        Console.Write($"({i}. {jegyek[i]})  ");
                    }
                    Console.Write("Adja meg a törlendő jegy indexét: ");
                    int index;
                    if (int.TryParse(Console.ReadLine(), out index) && index !< jegyek.Count()){
                        jegyek.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Nem megfelelő adatot adott meg! ");
                    }
                        break;

                case "3":
                    double atl = jegyek.Average();
                    Console.WriteLine($"Jegyek átlaga: {atl}");
                    break;

                case "4":
                    Console.WriteLine("Jegyek: ");
                    for(int i = 0;i < jegyek.Count;i++)
                    {
                        Console.Write($"{jegyek[i]} ");
                    }
                    break;

                case "5":
                    Console.WriteLine("Biztosan szeretnéd törölni az összes jegyet? (i/n)");
                    valasztas = Console.ReadLine();
                    if(valasztas == "i")
                    {
                        jegyek.Clear();
                    }
                    else {
                        break;
                    }
                    break;

                case "6":
                    return;
            }
                Console.ReadKey();
        }

    }
}