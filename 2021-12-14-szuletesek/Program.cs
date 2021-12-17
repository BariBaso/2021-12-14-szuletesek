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

            Console.ReadKey();
           
        }
    }
}
