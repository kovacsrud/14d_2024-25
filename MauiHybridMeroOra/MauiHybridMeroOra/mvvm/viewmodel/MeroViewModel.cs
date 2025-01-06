using MauiHybridMeroOra.mvvm.model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHybridMeroOra.mvvm.viewmodel
{
    [AddINotifyPropertyChangedInterface]
    public class MeroViewModel
    {
        public List<MeroOra> Oraallasok {  get; set; }=new List<MeroOra>();
        public MeroOra AktualisMeroOra { get; set; } = new MeroOra();

        public MeroViewModel()
        {
            //var ujadat=new MeroOra { Termeles=10,Fogyasztas=15};
            //UjOraAllas(ujadat);
            //var megEgyAdat = new MeroOra { Termeles = 20, Fogyasztas = 25 };
            //UjOraAllas(megEgyAdat);

            AdatLetoltes();   
        }

        public void AdatLetoltes()
        {
            Oraallasok = App.MeroRepository.GetItems();
        }

        public void UjOraAllas(MeroOra meroora)
        {
            try
            {
                App.MeroRepository.NewItem(meroora);
                AdatLetoltes();
            }
            catch (Exception ex)
            {
                //??????
                Application.Current.MainPage.DisplayAlert("Hiba", ex.Message, "Ok");
            }
        }
    }
}
