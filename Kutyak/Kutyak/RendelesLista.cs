using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class RendelesLista
    {
        public List<Rendeles> Rendelesek { get; set; } = new List<Rendeles>();

        public RendelesLista(string fajl,char hatarolo,int start=1)
        {
            var sorok=File.ReadAllLines(fajl,Encoding.Default);

            for (int i = start; i < sorok.Length; i++)
            {
                Rendelesek.Add(new Rendeles(sorok[i], hatarolo));
            }
        }
    }
}
