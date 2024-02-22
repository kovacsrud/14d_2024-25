using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Kor:ISikidom
    {
        
        public double  Sugar { get; set; }

        public Kor(double sugar)
        {
            Sugar = sugar;
        }

        public double Kerulet()
        {
            return 2 * Sugar*Math.PI;
        }

        public double Terulet()
        {
            return Sugar*Sugar*Math.PI;
        }
    }
}
