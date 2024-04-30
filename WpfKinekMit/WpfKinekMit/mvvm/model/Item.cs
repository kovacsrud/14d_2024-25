using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfKinekMit.mvvm.model
{
    public class Item
    {
        public string Targy { get; set; }
        public int DarabSzam { get; set; }
        public BitmapImage? TargyKepe { get; set; }
        public string Kinek { get; set; }
        public BitmapImage? KinekKep { get; set; }
        public DateTime Datum { get; set; } = DateTime.Now;

    }
}
