using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class KutyafajtaLista
    {
        public List<Kutyafajta> Kutyafajtak { get; set; } = new List<Kutyafajta>();

        public KutyafajtaLista(string fajl,char hatarolo,int start=1)
        {
            var sorok = File.ReadAllLines(fajl, Encoding.Default);

            for (int i = start; i < sorok.Length; i++)
            {
                Kutyafajtak.Add(new Kutyafajta(sorok[i], hatarolo));
            }
        }
    }
}
