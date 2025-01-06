using MauiHybridMeroOra.mvvm.model;
using MauiHybridMeroOra.repository;

namespace MauiHybridMeroOra
{
    public partial class App : Application
    {
        public static MeroRepository<MeroOra> MeroRepository { get; private set; }
        public App(MeroRepository<MeroOra> merorepository)
        {
            InitializeComponent();
            MeroRepository = merorepository;
            MainPage = new MainPage();
        }
    }
}
