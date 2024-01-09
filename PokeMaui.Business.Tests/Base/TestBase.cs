using Microsoft.Extensions.DependencyInjection;
using PokeMaui.Business.Api;

namespace PokeMaui.Business.Tests.Base
{
    public class TestBase
    {
        // Register Services Required for Unit Tests //
        public virtual IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<HttpClient>();
            services.AddScoped<PokemonApiService>();
            services.AddScoped<IApiService, ApiService>();

            return services;
        }
    }
}
