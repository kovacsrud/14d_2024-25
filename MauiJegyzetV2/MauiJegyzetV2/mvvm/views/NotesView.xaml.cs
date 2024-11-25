using MauiJegyzetV2.mvvm.viewmodel;

namespace MauiJegyzetV2.mvvm.views;

public partial class NotesView : ContentPage
{
	public NotesView()
	{
		InitializeComponent();
		BindingContext = new NoteViewModel();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		var vm=BindingContext as NoteViewModel;
		Navigation.PushAsync(new NewNoteView(vm));
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

        var vm = BindingContext as NoteViewModel;
        if (vm.CurrentNote!=null)
        {
            Navigation.PushAsync(new UpdateNoteView(vm));
        }

        
    }
}