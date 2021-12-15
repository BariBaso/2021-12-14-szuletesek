using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_12_14_szuletesek
{
    class szemely
    {
        public string SzemelyiSzam { get; set; }

        public bool CvdEll { 
            get
            {
                string sz = SzemelyiSzam.Replace("-","");
                int CheckSum = sz[sz.Length];
                int a = 10;
                int ösz =0;
                for (int i = 0; i < sz.Length-1; i++)
                {
                    ösz=+ sz[i] * a;
                    a--;
                }


                return false;
            }
        
        }
        public szemely(string sor)
        {
            SzemelyiSzam = sor;
        }
    }
}
