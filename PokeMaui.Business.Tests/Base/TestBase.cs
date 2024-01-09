using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PokeMaui.Business.Api;
using PokeMaui.Business.Mappers;
using PokeMaui.Business.MappingProfile;
using PokeMaui.Business.Models;

namespace PokeMaui.Business.Tests.Base
{
    public class TestBase
    {
        // Register Services Required for Unit Tests //
        public virtual IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            // Register Mapping Profiles //
            var mapperConfig = new MapperConfiguration(map =>
            {
                map.AddProfile<MappingProfiles>();
            });

            // Auto Mapper //
            services.AddSingleton(mapperConfig.CreateMapper());

            // Services //
            services.AddScoped<HttpClient>();
            services.AddScoped<PokemonApiService>();
            services.AddScoped<IApiService, ApiService>();
            services.AddScoped<IApiResponseMapper<PokemonDto, PokemonApiResponse>, PokemonApiResponseMapper>();

            return services;
        }
    }
}
