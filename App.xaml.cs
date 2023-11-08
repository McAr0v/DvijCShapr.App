namespace DvijCShapr;

public partial class App : Application
{
	public App()
	{
        InitializeComponent();

        var profilePage = new ProfilePage();
        var meetingsPage = new MeetingsPage();
        var placesPage = new PlacesPage();
        var stocksPage = new StocksPage();

        MainPage = new TabbedPage
        {
            Children =
                {
                    new NavigationPage(profilePage)
                    {
                        Title = "Профиль",
                        
                    },
                    new NavigationPage(meetingsPage)
                    {
                        Title = "Мероприятия",
                        
                    },
                    new NavigationPage(placesPage)
                    {
                        Title = "Заведения",
                        
                    },
                    new NavigationPage(stocksPage)
                    {
                        Title = "Акции",
                        
                    }
                }
        };
    }
}
