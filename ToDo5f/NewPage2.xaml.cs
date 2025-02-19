namespace ToDo5f;

public partial class NewPage2 : ContentPage
{
    ToDo td;
	public NewPage2(ToDo todo)
	{
		InitializeComponent();
        subjectEntry.Text = todo.Subject;
        descroptionEditor.Text = todo.Description;
        td = todo;
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
        var todo = ToDo.toDos.FirstOrDefault(
            x => x.Subject == td.Subject
            && x.Description == td.Description);

        todo.Subject = td.Subject;
        todo.Description = td.Description;

        await Navigation.PopAsync();
    }

    private async void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
    {
        await Navigation.PopAsync();
    }
}