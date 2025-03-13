using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokOOP
{
    public class Madar : Allat
    {
        public int SzarnyFesztav { get; set; }
        public Madar(string nev, string faj, int kor,int szarnyfesztav) : base(nev, faj, kor)
        {
            SzarnyFesztav = szarnyfesztav;
        }

     
        public override void Hang()
        {
            Console.WriteLine("A madár csiripel.");
        }

        public override string ToString()
        {
            return base.ToString()+$"Szárny fesztáv:{SzarnyFesztav}";
        }

    }
}
