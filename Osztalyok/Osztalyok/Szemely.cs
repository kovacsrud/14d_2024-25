using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    public class Szemely
    {
        //adatmezők, adattagok
        //az osztály adatmezőit csak metódusokon keresztül lehessen elérni
        //az osztály csak azokat az adatokat/metódusokat tegye láthatóvá, amelyek a megfeleő
        //működéshez okvetlenül szükségesek

        //Property: olyan változó, amely lekérdező és beállító függvényt is tartalmaz

       private string vezeteknev;
       public string Vezeteknev { 
            get { return vezeteknev; } 
            set {
                if (value.Length > 1)
                {
                    vezeteknev = value;
                } else
                {
                    throw new ArgumentException("Hibás vezetéknév");
                }

            }
        }
       public string Keresztnev { get; set; }

        private int szuletesiEv;

       public string Lakhely { get; set; }


        public Szemely(string vezeteknev,string keresztnev,int szulev,string lakhely)
        {
            Vezeteknev= vezeteknev;
            Keresztnev= keresztnev;
            szuletesiEv=szulev;
            Lakhely= lakhely;
        }

        public Szemely()
        {
            
        }




        //metódusok
        public int Eletkor()
        {
            return DateTime.Now.Year-szuletesiEv;
        }

        public int GetSzuletesiEv()
        {
            return szuletesiEv;
        }

        public void SetSzuletesiEv(int szuletesiEv)
        {
            if (szuletesiEv>1900 && szuletesiEv<=DateTime.Now.Year)
            {
                this.szuletesiEv = szuletesiEv;
            } else
            {
                this.szuletesiEv=DateTime.Now.Year;
            }
        }

    }
}
