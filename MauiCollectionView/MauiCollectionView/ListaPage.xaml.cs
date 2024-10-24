using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MauiCollectionView;

public partial class ListaPage : ContentPage
{
    ObservableCollection<Hegy> Hegyek { get; set; } = new ObservableCollection<Hegy>();
    public ListaPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadMauiAsset();
        Debug.WriteLine($"-------------------------Hegyek száma:{Hegyek.Count}");
        Debug.WriteLine($"-------------------------{Hegyek.First().HegyCsucsNeve}");
        BindingContext = Hegyek;
    }

    async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("hegyekMo.txt");
        using var reader = new StreamReader(stream);
        reader.ReadLine();
        while (!reader.EndOfStream)
        {
            Hegyek.Add(new Hegy(reader.ReadLine()));
        }
    }

    private async void buttonSzur_Clicked(object sender, EventArgs e)
    {
        try
        {
            var result = Hegyek.Where(x => x.Magassag >= Convert.ToInt32(entryMagassag.Text));

            if (result.Count()>0)
            {
                collectionHegyek.ItemsSource=result;
            } else
            {
                await DisplayAlert("Info","Nincs találat","Ok");
            }
            
        }
        catch (Exception ex)
        {
            await DisplayAlert("Hiba",ex.Message,"Ok");        
        }
    }

    private void buttonVissza_Clicked(object sender, EventArgs e)
    {
        collectionHegyek.ItemsSource = Hegyek;
    }
}