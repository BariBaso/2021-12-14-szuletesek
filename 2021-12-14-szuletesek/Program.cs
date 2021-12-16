using System;
using System.Collections.Generic;
using System.IO;

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

        
        }
    }
}
