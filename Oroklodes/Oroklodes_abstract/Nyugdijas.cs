using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_abstract
{
    public class Nyugdijas : Ember
    {
        public int Nyugdij { get; set; }

        public Nyugdijas(int nyugdij,string nev, int suly, int magassag, int szuletesiEv) : base(nev, suly, magassag, szuletesiEv)
        {
            Nyugdij = nyugdij;
        }

        public override void Eszik()
        {
            Console.WriteLine("A nyugdíjas ritkán eszik.");
        }

        public override void Iszik()
        {
            Console.WriteLine("A nyugdíjas keveset iszik.");
        }

        public override void Mozog()
        {
            Console.WriteLine("A nyugdíjas lassan mozog.");
        }

        public override string ToString()
        {
            return base.ToString()+$" Nyugdíja:{Nyugdij}";
        }
    }
}
