using DvijCShapr.Platforms.Android;
using Microsoft.Extensions.Logging;

namespace DvijCShapr;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
    {
		
		


        var builder = MauiApp.CreateBuilder();
		builder
            .ConfigureMauiHandlers((handlers) =>
            {
#if IOS
                handlers.AddHandler(typeof(Shell), typeof(MyShellRenderer));
#endif
#if ANDROID
                handlers.AddHandler(typeof(Shell), typeof(MyCustomShellRender));
#endif
            })
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();


    }

	

	
}
