using PokeMaui.Business.Config;
using PokeMaui.Maui.Config;
using CommunityToolkit.Maui;

namespace PokeMaui.Maui
{
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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

            BusinessServices.ConfigureBusinessServices(builder.Services);
            MauiServices.ConfigureMauiServices(builder.Services);

            return builder.Build();
        }
    }
}