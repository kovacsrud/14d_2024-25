using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoadatok
{
    public class Pilotak
    {
        public List<Pilota> PilotaLista { get; set; } = new List<Pilota>();

        public Pilotak(string fajl,char hatarolo,int start=1)
        {
            var sorok=File.ReadAllLines(fajl,Encoding.Default);

            for(int i = start; i < sorok.Length; i++) {
                PilotaLista.Add(new Pilota(sorok[i], hatarolo));
            }
            
        }
    }
}
