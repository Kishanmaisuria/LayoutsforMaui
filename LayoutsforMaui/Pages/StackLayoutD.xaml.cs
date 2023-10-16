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

    private void SLD2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HorizontalLayout());
    }

    private void SLD3_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GridD());
    }

    private void SLD4_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayout());
    }

    private void SLD5_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexLayout());
    }
}