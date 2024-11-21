

using MauiJegyzet.mvvm.view;

namespace MauiJegyzet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new JegyzetView();
        }
    }
}
