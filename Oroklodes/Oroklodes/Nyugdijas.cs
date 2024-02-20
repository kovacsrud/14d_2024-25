using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    public class Nyugdijas:Ember
    {
        public int Nyugdij { get; set; }
        public string MiVoltAFoglalkozasa { get; set; }

        public void AkcioVadaszat()
        {
            Console.WriteLine("A nyugdíjas akciókra vadászik");
        }

        public override void Mozog()
        {
            Console.WriteLine("A nyugdíjas lassan mozog");
        }

        public override string ToString()
        {
            return base.ToString()+$",Nyugdíja:{Nyugdij},Foglalkozása a nyugdíj előtt:{MiVoltAFoglalkozasa}";
        }
    }
}
