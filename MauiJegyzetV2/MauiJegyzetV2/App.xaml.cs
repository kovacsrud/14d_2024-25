using MauiJegyzetV2.mvvm.models;
using MauiJegyzetV2.mvvm.views;
using MauiJegyzetV2.Repository;

namespace MauiJegyzetV2
{
    public partial class App : Application
    {
        public static BaseRepository<Note> NotesRepo { get; private set; }
        public static BaseRepository<Category> CategoryRepo { get; private set; }
        public App(BaseRepository<Note> repo,BaseRepository<Category> category)
        {
            InitializeComponent();
            NotesRepo = repo;
            CategoryRepo = category;
            MainPage = new NavigationPage(new NotesView());
        }
    }
}
