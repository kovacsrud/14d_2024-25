using MauiRandom.Pages;

namespace MauiRandom
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartPage1());
        }
    }
}
