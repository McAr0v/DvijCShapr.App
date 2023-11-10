using DvijCShapr.Pages;

namespace DvijCShapr;



public partial class App : Application
{
	public App()
	{
        InitializeComponent();

        MainPage = new AppShell();
    }
}
