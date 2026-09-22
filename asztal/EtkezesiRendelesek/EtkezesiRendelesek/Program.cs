using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EtkezesiRendelesek
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("input.txt");
            List<Rendeles> rendelesek = new List<Rendeles>();
            int felnemdolgozottsorokszama = 0;
            foreach (string s in sorok)
            {
                try
                {
                    string[] darabok = s.Split(';');
                    if (darabok.Length <= 1) continue;
                    int rendelesid = int.Parse(darabok[1]);
                    List<string> etelek = darabok[2].Split(',').ToList();
                    int ar = int.Parse(darabok[3]);
                    if (darabok[0] == "H")
                    {
                        int asztalszam = int.Parse(darabok[4]);
                        rendelesek.Add(new HelybenRendeles(rendelesid, etelek, ar, asztalszam));
                    }
                    else if (darabok[0] == "E")
                    {
                        string cim = darabok[4];
                        string futar = darabok[5];
                        rendelesek.Add(new ElvitelreRendeles(rendelesid, etelek, ar, cim, futar));
                    }
                }
                catch (Exception)
                {
                    felnemdolgozottsorokszama++;
                }
            }

            foreach (Rendeles r in rendelesek)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine($"Fel nem dolgozott sorok száma: {felnemdolgozottsorokszama}");
            List<string> helyben = new List<string>();
            List<string> elvitel = new List<string>();

            foreach (var rendeles in rendelesek)
            {
                if (rendeles is HelybenRendeles)
                {
                    helyben.Add(rendeles.ToString());
                }
                else
                {
                    elvitel.Add(rendeles.ToString());
                }
            }
            File.WriteAllLines("helyben.txt", helyben);
            File.WriteAllLines("elvitel.txt", elvitel);

            string[] etels = File.ReadAllLines("etelek.txt");
            Dictionary<string, int> etlap = new Dictionary<string, int>();
            foreach (var e in etels)
            {
                if (!etlap.ContainsKey(e.Split(",")[0].ToLower()))
                {
                    etlap.Add(e.Split(",")[0].ToLower(), int.Parse(e.Split(",")[1]));
                }
            }
            foreach (var k in etlap)
            {
                Console.WriteLine($"{k.Key}  :  {k.Value}Ft");
            }

            int vegosszeg = 0;
            List<string> rendelestetelei = new List<string>();
            string etel = "";
            Console.WriteLine("Mit szeretne? ");
            do
            {
                etel = Console.ReadLine();
                int ara;
                if (!etlap.TryGetValue(etel.ToLower(), out ara))
                {
                    Console.WriteLine("Sajnos nincs ilyen étel az étlapon!");
                    etel = Console.ReadLine();
                }
                else
                {
                    vegosszeg += ara;
                    rendelestetelei.Add(etel);
                    Console.WriteLine("Más valamit?");
                    etel = Console.ReadLine();
                }
            } while (etel != "" && etel != "nem");
            Console.WriteLine("Helyben fogyasztja vagy elvitel? (H/E)");
            string hol = Console.ReadLine();
            if (hol == "H")
            {
                Console.WriteLine("Melyik asztalnál ül?");
                int aszam = int.Parse(Console.ReadLine());
                Rendeles ujrendeles = new HelybenRendeles(rendelesek.Count() + 1, rendelestetelei, vegosszeg, aszam);
                Console.WriteLine("Az ön rendelése: ");
                Console.WriteLine(ujrendeles);
                rendelesek.Add(ujrendeles);
            }
            else
            {
                Console.WriteLine("Mi a címe?");
                string cim = Console.ReadLine();
                Rendeles ujrendeles = new ElvitelreRendeles(rendelesek.Count() + 1, rendelestetelei, vegosszeg, cim, "Szabó Józsi");
                Console.WriteLine("Az ön rendelése: ");
                Console.WriteLine(ujrendeles);
                rendelesek.Add(ujrendeles);
            }
            File.WriteAllText("input.txt", string.Join("\n",rendelesek));

        }
        }
    }
