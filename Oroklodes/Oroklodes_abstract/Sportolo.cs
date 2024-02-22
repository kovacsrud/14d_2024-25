using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_abstract
{
    public class Sportolo : Ember
    {

        public string Sportag { get; set; }

        public Sportolo(string sportag,string nev, int suly, int magassag, int szuletesiEv) : base(nev, suly, magassag, szuletesiEv)
        {
            Sportag = sportag;
        }
        

        public override void Eszik()
        {
            Console.WriteLine("A sportoló sokat eszik.");
        }

        public override void Iszik()
        {
            Console.WriteLine("A sportoló sokat iszik.");
        }

        public override void Mozog()
        {
            Console.WriteLine("A sportoló sokat mozog.");
        }

        public override string ToString()
        {
            return base.ToString()+$" Sportág:{Sportag}";
        }
    }
}
