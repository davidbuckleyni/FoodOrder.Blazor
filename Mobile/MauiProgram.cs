using Microsoft.AspNetCore.Components.WebView.Maui;
using FoodOrder.Blazor.Data;
using Syncfusion.Blazor;

namespace FoodOrder.Blazor;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        var builder = MauiApp.CreateBuilder();
		try
		{

			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});

			builder.Services.AddMauiBlazorWebView();
#if DEBUG
			builder.Services.AddBlazorWebViewDeveloperTools();
#endif


            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjUwMDkwQDMyMzAyZTMxMmUzMEhYNG91THhKMTZFR2VXYnFzaGdtaE9HRmJqRnBybzZ3Q1RDak05Ni9oOWM9");
            builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });

            builder.Services.AddSingleton<WeatherForecastService>();
		}
		catch (Exception ex)
		{

		}

        return builder.Build();
	}
}
