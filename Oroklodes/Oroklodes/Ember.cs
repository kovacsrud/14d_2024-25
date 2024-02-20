using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    public class Ember
    {
        public string Nev { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }

        public virtual void Eszik()
        {
            Console.WriteLine("Az ember eszik");
        }
        public virtual void Iszik()
        {
            Console.WriteLine("Az ember iszik");
        }
        public virtual void Mozog()
        {
            Console.WriteLine("Az ember mozog");
        }
        public virtual void Alszik()
        {
            Console.WriteLine("Az ember alszik");
        }

        public override string ToString()
        {
            return $"Név:{Nev},Súly:{Suly},Magassag:{Magassag}";
        }

    }
}
