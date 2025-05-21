namespace GonzalrzFLayouts.View;

public partial class Absolute : ContentPage
{
	public Absolute()
	{
		InitializeComponent();
	}

    private void OnGridLayoutClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Grid());
    }
}