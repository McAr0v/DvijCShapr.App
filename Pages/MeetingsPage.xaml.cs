namespace DvijCShapr;

public partial class MeetingsPage : TabbedPage
{
	public MeetingsPage()
	{
		

        var stockFavPage = new StockFavPage();
        var stocksAllPage = new StocksAllPage();

        Children.Add(stockFavPage);
        Children.Add(stocksAllPage);
    }
}