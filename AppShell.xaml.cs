using DvijCShapr.Pages;
using DvijCShapr.Pages.Events;
using DvijCShapr.Pages.Other;
using DvijCShapr.Pages.Profile;

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
        Routing.RegisterRoute("ProfilePage", typeof(ProfilePage));
        Routing.RegisterRoute("AboutAppPage", typeof(AboutAppPage));

        
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ProfilePage");
    }

    private async void MenuItem_Clicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = false;
        await Shell.Current.GoToAsync("AboutAppPage");
               
    }
}
