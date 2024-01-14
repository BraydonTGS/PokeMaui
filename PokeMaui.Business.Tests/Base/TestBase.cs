using Microsoft.Extensions.DependencyInjection;
using PokeMaui.Business.Api;
using PokeMaui.Business.Mappers;
using PokeMaui.Business.Models;

namespace PokeMaui.Business.Tests.Base
{
    public class TestBase
    {
        // Register Services Required for Unit Tests //
        public virtual IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            // Services //
            services.AddScoped<HttpClient>();
            services.AddScoped<PokemonApiService>();
            services.AddScoped<IApiService, ApiService>();
            services.AddScoped<IApiResponseMapper<PokemonDto, PokemonApiResponse>, PokemonApiResponseMapper>();

            return services;
        }
    }
}
