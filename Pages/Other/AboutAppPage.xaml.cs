namespace DvijCShapr.Pages.Other;

public partial class AboutAppPage : ContentPage
{
	public AboutAppPage()
	{
		InitializeComponent();
	}

    private async void GoToAdBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("AboutAdPage");
    }

    private async void GoToFeedbackPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("FeedbackPage");
    }

    private async void GoToPrivacyPolicyPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("PrivacyPolicyPage");
    }
}