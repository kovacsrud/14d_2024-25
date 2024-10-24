using MauiMvvm.mvvm.viewmodel;

namespace MauiMvvm.mvvm.view;

public partial class MiddlePage : ContentPage
{
	public MiddlePage()
	{
		InitializeComponent();
	}

    private void buttonTovabb_Clicked(object sender, EventArgs e)
    {
        var vm = BindingContext as PageViewModel;
        Navigation.PushAsync(new EndPage {BindingContext=vm });
    }

    private void buttonVissza_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}