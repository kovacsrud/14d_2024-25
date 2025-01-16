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
        public MeroOra AktualisOraallas { get; set; } = new MeroOra();
        public bool Modositas { get; set; } = false;

        public MeroViewModel()
        {
          
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
                Application.Current.MainPage.DisplayAlert("Info", App.MeroRepository.StatusMsg, "Ok");
                AdatLetoltes();
            }
            catch (Exception ex)
            {
                //??????
                Application.Current.MainPage.DisplayAlert("Hiba", ex.Message, "Ok");
            }
        }

        public void ModositOraallas(MeroOra meroora) {
            try
            {
                App.MeroRepository.UpdateItem(meroora);
                Application.Current.MainPage.DisplayAlert("Info", App.MeroRepository.StatusMsg, "Ok");
                AdatLetoltes();
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Hiba", ex.Message, "Ok");
            }
        }

        public async void TorolOraallas(MeroOra meroora)
        {
            try
            {
                var result = await Application.Current.MainPage.DisplayAlert("Törlés", "Biztosan törli?", "Igen", "Mégse");

                if (result)
                {
                    App.MeroRepository.DeleteItem(meroora);
                    await Application.Current.MainPage.DisplayAlert("Info", App.MeroRepository.StatusMsg, "Ok");
                    AdatLetoltes();

                }
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Hiba", ex.Message, "Ok");
            }


            
        }

    }
}
