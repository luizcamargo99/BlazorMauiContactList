using Blazored.LocalStorage;
using ListaTelefonica.Interfaces;
using ListaTelefonica.Repositories;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace ListaTelefonica;

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
