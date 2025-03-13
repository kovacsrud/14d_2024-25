using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokOOP
{
    public class Emlos:Allat
    {
        public bool IsSzoros { get; set; }

        public Emlos(string nev, string faj, int kor,bool isszoros) : base(nev, faj, kor)
        {
            IsSzoros = isszoros;
        }
        

        public override void Hang()
        {
            Console.WriteLine("Az emlős morgást hallat.");
        }

        public override string ToString()
        {
            return base.ToString()+$"Ez egy emlős, ami {(IsSzoros ? "szőrös":"nem szőrös")}";
        }
    }
}
