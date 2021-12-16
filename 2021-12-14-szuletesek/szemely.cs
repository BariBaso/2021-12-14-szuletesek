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
                int CheckSum = int.Parse(sz.Last().ToString());
                int ösz =0;
                for (int i = 0; i < sz.Length-1; i++)
                {
                    ösz += int.Parse(sz[i].ToString()) * (10-i);
                   
                }


                return CheckSum == ösz % 11;
            }
        
        }
        public szemely(string sor)
        {
            SzemelyiSzam = sor;
        }
    }
}