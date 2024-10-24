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
        Debug.WriteLine($"-------------------------Hegyek sz�ma:{Hegyek.Count}");
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
}