using Microsoft.Extensions.DependencyInjection;
using PokeMaui.Business.Api;
using PokeMaui.Business.Models;
using PokeMaui.Business.Tests.Base;

namespace PokeMaui.Business.Tests.PokemonApiTest
{
    /// <summary>
    /// Test Class for the PokemonApiService
    /// </summary>
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
        [DataRow("Ditto", "Ditto")]
        [DataRow("Pikachu", "Pikachu")]
        [DataRow("Charmander", "Charmander")]
        [DataRow("Bulbasaur", "Bulbasaur")]
        [DataRow("Eevee", "Eevee")]
        [DataRow("Squirtle", "Squirtle")]
        [DataRow("Jigglypuff", "Jigglypuff")]
        [DataRow("Psyduck", "Psyduck")]
        [DataRow("Snorlax", "Snorlax")]
        [DataRow("Mew", "Mew")]
        public async Task PokemonApiService_GetByPokemonName_Success(string name, string expectedName)
        {
            var pokemon = await _pokemonApiService.GetByNameAsync(name);
            Assert.IsNotNull(pokemon);
            Assert.AreEqual(pokemon.Name, expectedName);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(9)]
        [DataRow(10)]
        public async Task PokemonApiService_GetByPokemonId_Success(int id)
        {
            var pokemon = await _pokemonApiService.GetByIdAsync(id);
            Assert.IsNotNull(pokemon);
        }
    }
}
