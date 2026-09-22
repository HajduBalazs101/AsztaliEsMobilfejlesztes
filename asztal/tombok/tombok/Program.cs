internal class Program
{
    private static void Main(string[] args)
    {
        ////Tömb: azonos típusúelemek sorozata.
        //int[] tomb;
        //tomb = new int[10];
        //int[] jegyek = {2, 1, 3, 2, 3, 5 };
        //Console.WriteLine($"Jegyek száma: {jegyek.Length}db");
        //Console.WriteLine($"Jegyek: {String.Join(",", jegyek)}");
        //int osszeg = 0;
        //foreach (int i in jegyek)
        //{
        //    osszeg += i;
        //}
        //double atlag = osszeg / (double)jegyek.Length;
        //Console.WriteLine($"Jegyek átlaga: {atlag}");

        ////van 1-es?
        //bool van = false;
        //foreach(int i in jegyek)
        //    if(i==1)
        //        van = true;

        //Console.WriteLine(van ? "Van 1-es!" : "Nincs 1-es!");

        ////Hány 2-es van?
        //int db = 0;
        //foreach( int i in jegyek)
        //{
        //    if(i==2)
        //        db++;

        //}
        //Console.WriteLine($"2-es jegyek száma: {db}");

        ////Legjobb jegy?
        //int max = jegyek[0];
        //for (int i = 1; i < jegyek.Length; i++)
        //{
        //    if (jegyek[i] > max)
        //        max = jegyek[i]; 
        //}
        //Console.WriteLine($"Legjobb jegy: {max}");
        ////index alapú max 
        //int maxi = 0;
        //for (int i = 1; i < jegyek.Length; i++)
        //{
        //    if (jegyek[i] > jegyek[maxi])
        //        maxi = i;
        //}
        //Console.WriteLine($"Legjobb jegy index alapúan: {jegyek[maxi]}");



        String[] nevek = "Géza, István, Béla, András, Gizella".Split(", ");
        //Hány név van?
        Console.WriteLine($"{nevek.Length}db név van");
        //Összesen hány betű?
        int db = 0;
        foreach (string n in nevek)
            db += n.Length;
        Console.WriteLine($"{db} betű van");

        //Melyik a leghosszabb név?
        int leghosszabb = 0;
        for (int i = 0; i < nevek.Length; i++)
        {
            if (nevek[i].Length > nevek[leghosszabb].Length)
                leghosszabb = i;
        }
        Console.WriteLine($"Leghosszabb név: {nevek[leghosszabb]}");

        //Van g betű valamelyik névben?
        bool van = false;
        foreach (string n in nevek)
        {
            {
                if (n.Contains("g") || n.Contains("G"))
                    van = true;

            }
        }
        Console.WriteLine(van ? "Van g betű az egyik névben" : "Nincs g betű egyik névben sem");

        //Összesen hány l betű van?
        int ldb = 0;
        foreach (string n in nevek)
        {
            foreach (char c in n.ToLower())
            {
                if (c == 'l')
                    ldb++;
            }
        }
        Console.WriteLine($"l betű darabszáma: {ldb}");

        //Legrövidebb név és hány karakter?
        int legrovidebb = nevek[0].Length;
        for (int i = 1; i < nevek.Length; i++)
        {
            if (nevek[i].Length < nevek[legrovidebb].Length)
                legrovidebb = i;
        }
        Console.WriteLine($"Legrövidebb név: {nevek[legrovidebb]}, {nevek[legrovidebb].Length} db betűből áll");


        //Minden név nagybetűvel kezdődik?
        bool minden = true;
        foreach (string n in nevek)
        {
            if (n[0].ToString() != n[0].ToString().ToUpper())
            {
                minden = false;
                Console.WriteLine(minden ? "Minden név nagy betűvel kezdődik" : "Nem minden név kezdődik nagybetűvel");
            }
        }

        //Átlagosan milyen hosszúak a nevek?
        int darabsz = 0;
        double atl = 0;
        for (int i = 0; i < nevek.Length; i++) { 
            darabsz += nevek[i].Count();
        }
        atl = darabsz / nevek.Length;
        Console.WriteLine($"Átlag névhossz: {atl}");


        //Minden második betű kiírása
        
    }
}