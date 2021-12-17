using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021_12_14_szuletesek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<szemely> szemelyek = new List<szemely>();

            foreach (var sor in File.ReadAllLines("vas.txt"))
            {
                szemelyek.Add(new szemely(sor));
            }

            Console.WriteLine("ellenörzés");

            szemelyek
                .Where(x => !x.CvdEll).ToList()
                .ForEach(sz => Console.WriteLine($"\tHibás az {sz.SzemelyiSzam}szemelyi azonosíto"));
            int törlölt = szemelyek.RemoveAll(x => !x.CvdEll);

            /*  Console.WriteLine(szemelyek.Count);
              for (int i = 0; i < szemelyek.Count; i++)
              {
                  if (!szemelyek[i].CvdEll)
                  {
                      Console.WriteLine($"\tHibás az {szemelyek[i].SzemelyiSzam}szemelyi azonosíto");
                      szemelyek.Remove(szemelyek[i]);
                  }


              }
              Console.WriteLine(szemelyek.Count);*/

            Console.WriteLine($"5. feladat vaz megyében a vicsgált évek alatt {szemelyek.Count} csecsemő született");

            int fiuk = szemelyek.Where(x => x.SzemelyiSzam.First() == '1' || x.SzemelyiSzam.First() == '3').ToList().Count();
            Console.WriteLine($"Fiuk száma {fiuk}");

            int minEv = 0, maxEv = 0;

            foreach (var sz in szemelyek)
            {
                int AK = int.Parse(sz.SzemelyiSzam.Substring(2, 2));
                if (AK >= 97 && AK <= 99)
                    AK += 1900;
                else
                    AK += 2000;
                if (AK < minEv) minEv = AK;

                if (AK > maxEv) maxEv = AK;
            }
            Console.WriteLine(minEv);
            Console.WriteLine(maxEv);

            Console.ReadKey();
           
        }
    }
}
