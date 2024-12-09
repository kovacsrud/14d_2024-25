using MauiHybridStart.mvvm.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PropertyChanged;

namespace MauiHybridStart.mvvm.viewmodel
{
    [AddINotifyPropertyChangedInterface]
    public class RandomViewModel
    {
        HttpClient client=new HttpClient();
        JsonSerializerOptions serializerOptions = new JsonSerializerOptions { WriteIndented=true};
        string baseUrl = "https://randomuser.me/api";
        public RandomUsers randomUsers=new RandomUsers();
        public string StatusMsg { get; set; } = string.Empty;

        public RandomViewModel()
        {
           
        }

        public static async Task<RandomViewModel> CreateAsync()
        {
            var viewModel=new RandomViewModel();
            await viewModel.GetData();
            return viewModel;
        }


        public async Task GetData()
        {
            var url = $"{baseUrl}/?results=50";

            if (Connectivity.Current.NetworkAccess==NetworkAccess.Internet)
            {
                try
                {
                    var keres= await client.GetAsync(url);
                    if (keres.IsSuccessStatusCode)
                    {
                        using (var keresStream=await keres.Content.ReadAsStreamAsync())
                        {
                            var data = await JsonSerializer.DeserializeAsync<RandomUsers>(keresStream, serializerOptions);
                            randomUsers = data;
                            
                        }
                        
                    } else
                    {
                        StatusMsg = "Nincsenek adatok";
                    }

                }
                catch (Exception ex)
                {
                    StatusMsg = ex.Message;                    
                }
                
            } else
            {
                StatusMsg = "Nincs internet!";
            }

        }
    }
}
