using DvijCShapr.Pages;
using DvijCShapr.Pages.Events;

namespace DvijCShapr;


public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("MeetingsPage", typeof(MeetingsPage));
        
        Routing.RegisterRoute("TabbedPageTest", typeof(EventsFeedPage));
    }

    

        
}
