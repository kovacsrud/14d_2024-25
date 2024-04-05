using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDatagrid.Model
{
    public class AutoLista
    {
        public List<Auto> Autok { get; set; } = new List<Auto>();

        public AutoLista(string fajl,char hatarolo,int start=1)
        {
            var sorok=File.ReadAllLines(fajl,Encoding.UTF7);

            for(int i=start; i<sorok.Length; i++)
            {
                Autok.Add(new Auto(sorok[i], hatarolo));
            }
        }

    }
}
