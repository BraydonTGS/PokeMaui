using PokeMaui.Business.Config;
using PokeMaui.Maui.Config;

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


            BusinessServices.ConfigureBusinessServices(builder.Services);
            MauiServices.ConfigureMauiServices(builder.Services);

            return builder.Build();
        }
    }
}