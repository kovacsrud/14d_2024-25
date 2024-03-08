using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoadatok
{
    public class AutoadatLista
    {
        public List<Auto> AutoLista { get; set; } = new List<Auto>();

        public AutoadatLista(string fajl,char hatarolo,int start=1)
        {
             var sorok=File.ReadAllLines(fajl,Encoding.UTF7);
            
             for(int i = start; i < sorok.Length; i++)
             {
                AutoLista.Add(new Auto(sorok[i],hatarolo));
             }

        }
    }
}
