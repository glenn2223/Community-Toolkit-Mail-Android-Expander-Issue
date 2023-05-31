using Community_Toolkit___Android_Button_Expander_Error.Data;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace Community_Toolkit___Android_Button_Expander_Error;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<WeatherForecastService>();

        return builder.Build();
    }
}