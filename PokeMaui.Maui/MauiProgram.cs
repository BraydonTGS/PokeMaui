using PokeMaui.Business.Api;
using PokeMaui.Business.Config;

namespace PokeMaui.Maui
{
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

            Services.ConfigureServices(builder.Services);

            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}