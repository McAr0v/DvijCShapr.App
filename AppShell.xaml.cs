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
        
        // Регистрируем пути к страницам

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

    private async void AboutAppBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = false;
        await Shell.Current.GoToAsync("AboutAppPage");
               
    }

    private async void PrivacyPolicyBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = false;
        await Shell.Current.GoToAsync("PrivacyPolicyPage");
    }

    private async void AboutAdBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = false;
        await Shell.Current.GoToAsync("AboutAdPage");
    }

    private async void FeedbackBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = false;
        await Shell.Current.GoToAsync("FeedbackPage");
    }
}
