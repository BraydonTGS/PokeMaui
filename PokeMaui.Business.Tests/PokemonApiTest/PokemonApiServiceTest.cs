using Microsoft.Extensions.DependencyInjection;
using PokeMaui.Business.Api;
using PokeMaui.Business.Models;
using PokeMaui.Business.Tests.Base;

namespace PokeMaui.Business.Tests.PokemonApiTest
{
    [TestClass]
    public class PokemonApiServiceTest : TestBase
    {
        private readonly IServiceCollection _services;
        private readonly IServiceProvider _serviceProvider;
        private readonly PokemonApiService _pokemonApiService;

        public PokemonApiServiceTest()
        {
            _services = ConfigureServices();
            _serviceProvider = _services.BuildServiceProvider();
            _pokemonApiService = _serviceProvider.GetRequiredService<PokemonApiService>();
        }

        [TestMethod]
        [DataRow("Ditto")]
        [DataRow("Pikachu")]
        [DataRow("Charmander")]
        [DataRow("Bulbasaur")]
        public async Task PokemonApiService_GetByPokemonName_Success(string name)
        {
            var pokemon = await _pokemonApiService.GetByNameAsync(name);
            Assert.IsNotNull(pokemon);
        }
    }
}
