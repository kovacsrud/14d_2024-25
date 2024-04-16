using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace WpfAdatkotes2
{
    [AddINotifyPropertyChangedInterface]
    public class Adat
    {
        private int min,max;
        public int BindAdat { get; set; }

        public Adat(int ertek,int min,int max) {
            this.min = min;
            this.max = max;
            BindAdat = ertek;
        }
    }
}
