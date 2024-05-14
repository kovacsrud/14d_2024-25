using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class Rendeles
    {
        public int Id { get; set; }
        public int FajtaId { get; set; }
        public int NevId { get; set; }
        public int Eletkor { get; set; }
        public DateTime UtolsoEll { get; set; }

        public Rendeles(string sor,char hatarolo) {
            var adatok = sor.Split(hatarolo);

            Id = Convert.ToInt32(adatok[0]);
            FajtaId = Convert.ToInt32(adatok[1]);
            NevId= Convert.ToInt32(adatok[2]);
            Eletkor = Convert.ToInt32(adatok[3]);
            UtolsoEll = Convert.ToDateTime(adatok[4]);


        }
    }
}
