using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class KutyanevLista
    {
        public List<Kutyanev> Kutyanevek { get; set; } = new List<Kutyanev>();

        public KutyanevLista(string fajl,char hatarolo,int start=1)
        {
            var sorok = File.ReadAllLines(fajl, Encoding.Default);

            for (int i = start; i < sorok.Length; i++)
            {
                Kutyanevek.Add(new Kutyanev(sorok[i], hatarolo));
            }


        }
    }
}
