namespace DvijCShapr;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("MeetingsPage", typeof(MeetingsPage));
	}
}
