namespace LayoutsforMaui.Pages;

public partial class StackLayoutD : ContentPage
{
	public StackLayoutD()
	{
		InitializeComponent();
	}

    private void SLD1_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new VerticalStackLayout());
    }
}