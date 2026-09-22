using ZoldsegFeladat;

internal class Program
{
    private static void Main(string[] args)
    {
        Zoldseg z1 = new Zoldseg("Káposzta", 1.5, 300);
        Console.WriteLine(z1);
        Repa r1 = new Repa(0.3, 450, 20);
        Console.WriteLine(r1);
        Krumpli k1 = new Krumpli("Burgonya", 2, 250);
        Console.WriteLine(k1);

        List<Zoldseg> zoldsegek = new List<Zoldseg>();
        zoldsegek.Add(z1);
        zoldsegek.Add(r1);
        zoldsegek.Add(k1);
        double osszeg = 0;
        foreach(var z in zoldsegek)
        {
            osszeg += z.Ar();
        }
        Console.WriteLine($"Össz ár: {osszeg} Ft");

        Zoldseg Min = zoldsegek[0];
        foreach(var z in zoldsegek)
        {
            if(z.Ar() < Min.Ar())
            {
                Min = z;
            }
        }
        Console.WriteLine($"A legolcsóbb zöldség: {Min} Ft");
        int nemrepa = 0;
        foreach (var z in zoldsegek)
        {
            if (z is not Repa)
            {
                nemrepa++;
            }
        }
        Console.WriteLine($"A zöldségek közül {nemrepa} darab nem répa.");
    }
}