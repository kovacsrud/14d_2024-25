namespace MauiNavigacio.mvvm.views;

public partial class MiddlePage : ContentPage
{
	public MiddlePage()
	{
		InitializeComponent();
	}

    private void buttonTovabb_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EndPage());
    }

    private void buttonVissza_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}