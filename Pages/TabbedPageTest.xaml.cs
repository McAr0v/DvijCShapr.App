namespace DvijCShapr.Pages;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class TabbedPageTest : TabbedPage
{
	
	public TabbedPageTest()
	{
		InitializeComponent();

		
	}

	private async void Button_clicked (object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TabbedPage());
	}
}