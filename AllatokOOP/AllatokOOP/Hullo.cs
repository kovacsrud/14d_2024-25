using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokOOP
{
    public class Hullo:Allat
    {
        public bool IsMergezo { get; set; }
        public Hullo(string nev, string faj, int kor,bool ismergezo) : base(nev, faj, kor)
        {
            IsMergezo = ismergezo;
        }
        

        public override void Hang()
        {
            Console.WriteLine("A hüllő sziszeg.");
        }

        public override string ToString()
        {
            return base.ToString()+$"Ez egy hüllő, ami {(IsMergezo ? "mérges":"nem mérges")}";
        }
    }
}
