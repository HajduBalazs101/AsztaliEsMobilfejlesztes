using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        //int egesz = 0;
        //Console.WriteLine("Int típus maximum értéke: " + int.MaxValue);
        //Console.WriteLine("Int típus minimum értéke: " + int.MinValue);

        //char ch = 'a';
        //Console.WriteLine($"'a' karakter sorszáma: {(int)ch} {ch}");
        //long hosszuegesz = 10_000_000_000_000;
        //Console.WriteLine($"Long típus maximum értéke: {long.MaxValue}");
        //Console.WriteLine($"Long típus minimum értéke: {long.MinValue}");


        //int eredmeny = ((egesz+2-4)*5+1) / 2; //hányszor van meg benne?
        //int maradek = ((egesz + 2 - 4) * 5 + 1) % 2; //mennyi lesz a maradék ha 2-vel osztjuk?

        //Console.WriteLine($"Eredmény: {eredmeny}");
        //Console.WriteLine($"Maradék: {maradek}");
        //Console.WriteLine();




        //bool logikaiA = true, logikaiB = false;
        //Console.WriteLine($"Logikai: {logikaiA}, {logikaiB}");
        //Console.WriteLine(!logikaiA); //negálás
        //Console.WriteLine("Vagy " + (logikaiA || logikaiB)); //vagy, bármelyik true, akkor true az eredmény
        //Console.WriteLine("És " + (logikaiA && logikaiB)); //és, bármelyik false, akkor false az eredmény
        //Console.WriteLine("XOR " + (logikaiA ^ logikaiB)); //XOR, ha különbözőek, akkor true az eredmény

        ////valós típusok

        //float kisvalos = (float)3.14;
        //double nagyvalos = 5.12;
        //Console.WriteLine(kisvalos);
        //Console.WriteLine(nagyvalos);

        //String szoveg = "Almafán alma terem";
        //Console.WriteLine($"{szoveg}");
        //Console.WriteLine($"{szoveg.Length}"); //kiírja a szöveg hosszát
        //Console.WriteLine($"{szoveg.Substring(8)}"); //8. karaktertől kezdve kiírja a szöveget
        //Console.WriteLine($"{szoveg.Substring(8, 4)}"); //8. karaktertől kezdve 4 karaktert ír ki
        //Console.WriteLine($"{szoveg.ToLower()}"); //kisbetűsre alakítja
        //Console.WriteLine($"{szoveg.Replace("a", "").Replace("A", "")}"); //az összes 'a' és 'A' betűt eltávolítja
        //Console.WriteLine($"Az 'a' betű első helye: {szoveg.IndexOf("a")}"); //kiírja az első 'a' betű helyét
        //Console.WriteLine($"{szoveg.Contains("a")}");
        //Console.WriteLine();
        //Console.WriteLine();

        //string[] szavak = szoveg.Split(" ");
        //for (int i = 0; i < szavak.Length; i++)
        //    Console.WriteLine($"{szavak[i]}");
        //Console.WriteLine();
        //Console.WriteLine(szoveg.Remove(8));
        //Console.WriteLine(szoveg.Remove(8, 4));
        //Console.WriteLine(szoveg.Remove(8, 4).Insert(8, "körte"));
        //Console.WriteLine(szoveg[0]);

        //1. Olvass be egy nevet, jelenítsd meg a monogrammot!
        Console.WriteLine("Írd be a nevedet! (Veznév, Knév)");
        string nev = Console.ReadLine();
        string[] nevek = nev.Split(" ");
        string monogram = "";
        for (int i = 0; i < nevek.Length; i++)
        {
            monogram += nevek[i][0];
        }
        Console.WriteLine($"A {nev} monogramja: {monogram[0]}.{monogram[1]}");

        //2.A beolvasott név legyen nagybetűs szóköz nélkül, és írd ki hány szóból áll
        Console.WriteLine($"{nev.ToUpper().Replace(" ", "")}, {nevek.Length} szóból áll");

        //3. A beolvasott névnek jelenítsd meg az első 5 karakterét, jelenítsd meg az ASCII kódját is a betűknek
        int hossz = Math.Min(5, nev.Length);
        Console.WriteLine($"{nev} első 5 karaktere: {nev.Substring(0, hossz)}");
        string nev1 = nevek[0];
        string nev2 = nevek[1];
        Console.WriteLine("Vezetéknév betűinek értékei:");
        for (int i = 0; i < nev1.Length; i++)
        {
            Console.Write($"{nev1[i]}-");
            Console.Write($"{(int)nev1[i]} ");
        }
        Console.WriteLine();
        Console.WriteLine("Keresztnév betűinek értékei: ");
        for (int i = 0; i < nev2.Length; i++)
        {
            Console.Write($"{nev2[i]}-");
            Console.Write($"{(int)nev2[i]} ");



        }
    }
}