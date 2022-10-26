using Blazored.LocalStorage;
using ContactList.Interfaces;
using ContactList.Repositories;

namespace ContactList;

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
		builder.Services.AddBlazoredLocalStorage();
        builder.Services.AddScoped<IContactRepository, ContactRepository>();   

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		#endif
		

		return builder.Build();
	}
}
