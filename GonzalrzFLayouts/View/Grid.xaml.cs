namespace GonzalrzFLayouts;

public partial class Grid : ContentPage
{
	public Grid()
	{
		InitializeComponent();
	}
   

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Stack());
    }
}