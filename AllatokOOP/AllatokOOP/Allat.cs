using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokOOP
{
    public abstract class Allat
    {
        public string Nev { get; set; }
        public string Faj { get; set; }
        public int Kor { get; set; }

        protected Allat(string nev, string faj, int kor)
        {
            Nev = nev;
            Faj = faj;
            Kor = kor;
        }
        

        public abstract void Hang();

        public override string ToString()
        {
            return $"Név:{Nev},Faj:{Faj},Kor:{Kor} év ";
        }

    }
}
