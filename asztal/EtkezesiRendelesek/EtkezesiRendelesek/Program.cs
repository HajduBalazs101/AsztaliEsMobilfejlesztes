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
                if(rendeles is HelybenRendeles)
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
                if (!etlap.ContainsKey(e.Split(",")[0])) etlap.Add(e.Split(",")[0], int.Parse(e.Split(",")[1]));
            }
            foreach (var e in etlap)
            {
                Console.WriteLine($"{e.Key}  :  {e.Value}Ft");
            }
        }
    }
}