using MauiRandom.Model;

namespace MauiRandom.Pages;

public partial class DetailPage : ContentPage
{
	public DetailPage(Result result)
	{
		InitializeComponent();
		BindingContext=result;
	}
}