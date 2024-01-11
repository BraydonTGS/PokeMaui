using PokeMaui.Maui.View;
using PokeMaui.Maui.ViewModel;

namespace PokeMaui.Maui.Config
{
    internal static class MauiServices
    {
        /// <summary>
        /// Register any Dependencies Needed for the Maui Project
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigureMauiServices(IServiceCollection services)
        {
            // ViewModels //
            services.AddSingleton<PokemonViewModel>();
            services.AddSingleton<PokemonDetailsViewModel>();
            services.AddSingleton<MainViewModel>();

            // Views //
            services.AddSingleton<PokemonView>();
            services.AddSingleton<MainPage>();

            return services;

        }
    }
}
