using MauiJegyzetV2.mvvm.models;
using MauiJegyzetV2.mvvm.viewmodel;
using PropertyChanged;

namespace MauiJegyzetV2.mvvm.views;

[AddINotifyPropertyChangedInterface]

public partial class NewNoteView : ContentPage
{
    public Note NewNote { get; set; }=new Note();
    public NoteViewModel ViewModel { get; set; }
    public NewNoteView(NoteViewModel vm)
	{
		InitializeComponent();
        ViewModel = vm;
		BindingContext = this;	
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var result = await DisplayAlert("Új jegyzet", "Biztosan rögzíti?", "Igen", "Nem");
        if (result)
        {
            App.NotesRepo.NewItem(NewNote);
            ViewModel.GetNotes();
        }

    }
}