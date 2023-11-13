using DvijCShapr.Pages;
using DvijCShapr.Pages.Events;
using DvijCShapr.Pages.Other;

namespace DvijCShapr;


public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("MeetingsPage", typeof(MeetingsPage));
        
        Routing.RegisterRoute("TabbedPageTest", typeof(EventsFeedPage));
        Routing.RegisterRoute("AboutAdPage", typeof(AboutAdPage));
    }

    

        
}
