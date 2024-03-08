using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoadatok
{
    public class Pilota
    {
        public string Nev { get; set; }
        public DateTime SzuletesiDatum { get; set; }
        public DateOnly SzuletesiDatumDO { get; set; }
        public string Nemzetiseg { get; set; }
        public int Rajtszam { get; set; }

        public Pilota(string sor,char hatarolo)
        {
            var adatok = sor.Split(hatarolo);
            Nev = adatok[0];
            SzuletesiDatum = Convert.ToDateTime(adatok[1]);
            var datum = adatok[1].Split('.');
            SzuletesiDatumDO = new DateOnly(Convert.ToInt32(datum[0]), Convert.ToInt32(datum[1]), Convert.ToInt32(datum[2]));
            Nemzetiseg= adatok[2];
            if (adatok[3]=="")
            {
                Rajtszam = -111;
            } else
            {
                Rajtszam = Convert.ToInt32(adatok[3]);
            }

        }

    }
}
