using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAdatkotes
{
    public class Adat:INotifyPropertyChanged
    {
        private int adat;
        private int min, max;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int BindAdat
        {
            get { return adat; }
            set
            {
                if (value != adat && value>=min && value<=max)
                {
                    adat = value;
                    Prop_Changed("BindAdat");
                }
                
            }
        }

        public Adat(int ertek,int min,int max)
        {
                BindAdat = ertek;
                this.min= min;
                this.max= max;
        }

        private void Prop_Changed(string prop)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
