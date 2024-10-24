using MauiMvvm.mvvm.model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvm.mvvm.viewmodel
{
    [AddINotifyPropertyChangedInterface]
    public class PageViewModel
    {
        public Name Nev { get; set; }=new Name();
    }
}
