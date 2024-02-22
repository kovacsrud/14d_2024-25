using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_abstract
{
    public abstract class Ember
    {
        

        public string Nev { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }
        public int SzuletesiEv { get; set; }

        public Ember(string nev, int suly, int magassag, int szuletesiEv)
        {
            Nev = nev;
            Suly = suly;
            Magassag = magassag;
            SzuletesiEv = szuletesiEv;
        }

        public int Eletkor()
        {
            return DateTime.Now.Year-SzuletesiEv;
        }

        //Eszik, iszik, mozog
        public abstract void Eszik();

        public abstract void Mozog();

        public abstract void Iszik();

        public override string ToString()
        {
            return $"Név:{Nev},Súly:{Suly},Magasság:{Magassag},Születési év:{SzuletesiEv}";
        }


    }
}
