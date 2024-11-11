using MauiRandom.Model;
using System.Text.Json;

namespace MauiRandom.Pages;

public partial class ListPage : ContentPage
{
	HttpClient client;
	JsonSerializerOptions serializerOptions;
	string baseUrl = "https://randomuser.me/api";
	public ListPage()
	{
		InitializeComponent();
		client = new HttpClient();
		serializerOptions = new JsonSerializerOptions { WriteIndented=true };
	}

    private async void buttonGetData_Clicked(object sender, EventArgs e)
    {
		var url = $"{baseUrl}/?results=50";

        if (Connectivity.Current.NetworkAccess==NetworkAccess.Internet) { 

        try
        {
            var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync())
                    {
                        var data = await JsonSerializer.DeserializeAsync<RandomUsers>(responseStream, serializerOptions);
                        collectionUsers.ItemsSource = data.results;
                    }
                }
                else
                {
                    collectionUsers.EmptyView = "No data";
                }
            }
		    catch (Exception ex)
		    {
                DisplayAlert("Hiba", ex.Message,"Ok");
		    }
        } else
        {
            collectionUsers.EmptyView = "Nincs internet hozzáférés";
        }

    }

    private void collectionUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		var selectedUser=collectionUsers.SelectedItem as Result;
		Navigation.PushAsync(new DetailPage(selectedUser));
    }
}