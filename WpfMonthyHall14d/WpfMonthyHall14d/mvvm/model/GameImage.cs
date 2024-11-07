using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfMonthyHall14d.mvvm.model
{
    [AddINotifyPropertyChangedInterface]
    public class GameImage
    {
        public Image FrontImage { get; set; }
        public Image BackImage { get; set; }

        public GameImage(Image front,Image back)
        {
            FrontImage = front;
            BackImage = back;
        }
    }
}
