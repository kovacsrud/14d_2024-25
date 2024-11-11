namespace MauiRandom.Pages;

public partial class StartPage1 : ContentPage
{
	public StartPage1()
	{
		InitializeComponent();
	}

    private void buttonStart_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ListPage());
    }
}