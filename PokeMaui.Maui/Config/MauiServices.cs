using PokeMaui.Maui.Navigation;
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
            services.AddSingleton<PokemonDiscoverViewModel>();
            services.AddTransient<PokemonDetailsViewModel>();
            services.AddSingleton<MainViewModel>();

            // Views & Pages //
            services.AddSingleton<PokemonDiscoverPage>();
            services.AddTransient<PokemonDetailsView>();
            services.AddSingleton<MainPage>();

            // Services //
            services.AddSingleton(Connectivity.Current);
            services.AddScoped<INavigationService, ShellNavigationService>();
          
            return services;

        }
    }
}
