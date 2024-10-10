namespace MauiNavigacio.mvvm.views;

public partial class EndPage : ContentPage
{
	public EndPage()
	{
		InitializeComponent();
	}

    private void buttonVissza_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void buttonRoot_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}