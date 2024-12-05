using MauiJegyzetV2.mvvm.models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiJegyzetV2.mvvm.viewmodel
{
    [AddINotifyPropertyChangedInterface]
    public class NoteViewModel
    {
        public List<Note> Notes { get; set; }= new List<Note>();
        public Note CurrentNote { get; set; }

        public List<Category> Categories { get; set; }
        public Category CurrentCategory { get; set; }

        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; } 

        public NoteViewModel()
        {
            //App.CategoryRepo.NewItem(new Category { CategoryName = "mozgás" });
            //App.CategoryRepo.NewItem(new Category { CategoryName = "bevásárlás" });
            //App.CategoryRepo.NewItem(new Category { CategoryName = "munka" });
            //App.CategoryRepo.NewItem(new Category { CategoryName = "edzés" });

            GetNotes();
            if (Categories.Count<1)
            {
                App.CategoryRepo.NewItem(new Category { CategoryName="alapértelmezett"});
            }
            UpdateCommand = new Command(async () =>
            {
                var result = await Application.Current.MainPage.DisplayAlert("Jegyzet módosítása","Biztosan módosítja?","Igen","Nem");
                if (result)
                {
                    App.NotesRepo.UpdateItem(CurrentNote);
                    await Application.Current.MainPage.DisplayAlert("Módosítás",App.NotesRepo.StatusMsg,"Ok");
                    GetNotes();
                }
            });
            DeleteCommand = new Command(async () =>
            {
                var result = await Application.Current.MainPage.DisplayAlert("Jegyzet törlése", "Biztosan törli?", "Igen", "Nem");
                if (result)
                {
                    App.NotesRepo.DeleteItem(CurrentNote);
                    await Application.Current.MainPage.DisplayAlert("Törlés", App.NotesRepo.StatusMsg, "Ok");
                    GetNotes();
                }
            });
        }


        public void GetNotes()
        {
            Notes = App.NotesRepo.GetItemsWithChildren();
            Categories = App.CategoryRepo.GetItems();
        }
    }
}
