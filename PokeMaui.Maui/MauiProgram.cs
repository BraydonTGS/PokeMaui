using Microsoft.Extensions.Logging;
using PokeMaui.Business.Api;
using PokeMaui.Business.Models;

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

            // Todo: Register My Services in my Business Project for Business Needs //
            builder.Services.AddScoped<HttpClient>();
            builder.Services.AddScoped<PokemonApiService>();    
            builder.Services.AddScoped<IApiService<PokemonApiResponse>, ApiService<PokemonApiResponse>>();

            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}