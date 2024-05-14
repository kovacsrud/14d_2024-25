using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class Kutyanev
    {
        public int Id { get; set; }
        public string KutyaNev { get; set; }

        public Kutyanev(string sor,char hatarolo)
        {
            var adatok = sor.Split(hatarolo);
            Id = Convert.ToInt32(adatok[0]);
            KutyaNev= adatok[1];
        }
    }
}
