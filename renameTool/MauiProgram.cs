using Microsoft.Extensions.Logging;
using renameTool.Data;
using renameTool.Services;

namespace renameTool;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

        // Note: this part was added
#if WINDOWS
        builder.Services.AddTransient<IFolderPicker, Platforms.Windows.MyFolderPicker>();
#endif
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<App>();
        // Note: end added part

        builder.Services.AddSingleton<WeatherForecastService>();
		builder.Services.AddSingleton<LanguageService>();
        builder.Services.AddSingleton<IDialogService, DialogService>();

        return builder.Build();
	}
}
