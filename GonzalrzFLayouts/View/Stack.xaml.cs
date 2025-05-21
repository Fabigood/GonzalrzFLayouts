using GonzalrzFLayouts.View;

namespace GonzalrzFLayouts;

public partial class Stack : ContentPage
{
	public Stack()
	{
		InitializeComponent();
	}
	private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Flex());
    }
}