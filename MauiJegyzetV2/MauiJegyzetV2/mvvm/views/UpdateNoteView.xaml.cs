using MauiJegyzetV2.mvvm.viewmodel;

namespace MauiJegyzetV2.mvvm.views;

public partial class UpdateNoteView : ContentPage
{
	public UpdateNoteView(NoteViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}