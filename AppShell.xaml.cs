using DvijCShapr.Pages;
using DvijCShapr.Pages.Events;
using DvijCShapr.Pages.Other;

namespace DvijCShapr;


public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        
        Routing.RegisterRoute("TabbedPageTest", typeof(EventsFeedPage));
        Routing.RegisterRoute("AboutAdPage", typeof(AboutAdPage));
        Routing.RegisterRoute("FeedbackPage", typeof(FeedbackPage));
        Routing.RegisterRoute("PrivacyPolicyPage", typeof(PrivacyPolicyPage));

        
    }

    

        
}
