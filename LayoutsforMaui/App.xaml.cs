using LayoutsforMaui.Pages;

namespace LayoutsforMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StackLayoutD();
        }
    }
}