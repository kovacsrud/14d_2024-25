using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class Kutyafajta
    {
        public int Id { get; set; }
        public string FajtaNev { get; set; }
        public string FajtaEredetiNev { get; set; }

        public Kutyafajta(string sor,char hatarolo)
        {
            var adatok = sor.Split(hatarolo);
            Id = Convert.ToInt32(adatok[0]);
            FajtaNev = adatok[1];
            FajtaEredetiNev = adatok[2];
        }

    }
}
