using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PokeMaui.Business.Api;
using PokeMaui.Business.Mappers;
using PokeMaui.Business.MappingProfile;
using PokeMaui.Business.Models;

namespace PokeMaui.Business.Config
{
    public static class BusinessServices
    {
        /// <summary>
        /// Register any Dependencies Needed for the Business Project
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigureBusinessServices(IServiceCollection services)
        {
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
