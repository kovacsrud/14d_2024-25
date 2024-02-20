using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    public class Sportolo:Ember
    {
        public string Sportag { get; set; }

        public void Edzes()
        {
            Console.WriteLine("A sportoló edz");
        }

        public override void Mozog()
        {
            Console.WriteLine("A sportoló gyorsan mozog");
        }

        public override string ToString()
        {
            return base.ToString()+$",Sportág:{Sportag}";
        }
    }
}
