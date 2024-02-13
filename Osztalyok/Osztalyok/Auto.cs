using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    public class Auto
    {
       

        public string Marka { get; set; }
        public string Tipus { get; set; }

        private int gyartasiev;
        public int GyartasiEv { 
            get 
            {
                return gyartasiev;
            }
            set
            {
                if(value< 1990 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Hibás gyártási év!");
                } else
                {
                    gyartasiev = value;
                }
            } 
        }
        public string Szin { get; set; }

        private int futottkm;
        public int FutottKM {
            get
            {  return futottkm; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A Futott km nem lehet kisebb mint 0!");
                } else
                {
                    futottkm = value;
                }
            } 
        
        }

        public Auto(string marka, string tipus, int gyartasiEv, string szin, int futottKM)
        {
            Marka = marka;
            Tipus = tipus;
            GyartasiEv = gyartasiEv;
            Szin = szin;
            FutottKM = futottKM;
        }

        public Auto()
        {
                
        }


    }
}
