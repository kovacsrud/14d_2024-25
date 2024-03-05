using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FajlolvasasFeldolgozas
{
    public class Hegycsucs
    {
        public string HegycsucsNeve { get; set; }
        public string Hegyseg { get; set; }
        public int CsucsMagassaga { get; set; }

        public Hegycsucs(string sor,char hatarolo)
        {
            var adatok = sor.Split(hatarolo);
            HegycsucsNeve = adatok[0];
            Hegyseg = adatok[1];
            CsucsMagassaga = Convert.ToInt32(adatok[2]);
        }
    }
}
