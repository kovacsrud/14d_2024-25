namespace MauiStart;

public partial class ProbaPage : ContentPage
{
	public ProbaPage()
	{
		InitializeComponent();
	}

    private void buttonClick_Clicked(object sender, EventArgs e)
    {
		labelButton.Text = entrySzoveg.Text;
    }
}