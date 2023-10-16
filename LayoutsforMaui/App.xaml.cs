using LayoutsforMaui.Pages;

namespace LayoutsforMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navigationPage = new NavigationPage(new StackLayoutD());
            MainPage = navigationPage;
        }
    }
}