using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCollectionView
{
    public class Hegy
    {
        public string HegyCsucsNeve { get; set; }
        public string Hegyseg { get; set; }
        public int Magassag { get; set; }

        public Hegy(string sor)
        {
            var adatok = sor.Split(';');
            HegyCsucsNeve = adatok[0];
            Hegyseg = adatok[1];
            Magassag=Convert.ToInt32(adatok[2]);
            
        }


    }
}
