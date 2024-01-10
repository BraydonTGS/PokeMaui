using Microsoft.Extensions.DependencyInjection;
using PokeMaui.Business.Api;
using PokeMaui.Business.Models;
using PokeMaui.Business.Tests.Base;
using PokeMaui.Global.Constants;
using PokeMaui.Global.Exceptions;

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

        #region PokemonApiService_NoName_ReturnsNull_Success
        [TestMethod]
        public async Task PokemonApiService_NoName_ReturnsNull_Success()
        {
            var pokemon = await _pokemonApiService.GetByNameAsync(string.Empty);

            Assert.IsNull(pokemon);
        }
        #endregion

        #region PokemonApiService_GetByPokemonName_Success
        [TestMethod]
        [DataRow(Constants.Ditto, Constants.Ditto)]
        [DataRow(Constants.Pikachu, Constants.Pikachu)]
        [DataRow(Constants.Charmander, Constants.Charmander)]
        [DataRow(Constants.Bulbasaur, Constants.Bulbasaur)]
        [DataRow(Constants.Eevee, Constants.Eevee)]
        [DataRow(Constants.Squirtle, Constants.Squirtle)]
        [DataRow(Constants.Jigglypuff, Constants.Jigglypuff)]
        [DataRow(Constants.Psyduck, Constants.Psyduck)]
        [DataRow(Constants.Snorlax, Constants.Snorlax)]
        [DataRow(Constants.Mew, Constants.Mew)]
        public async Task PokemonApiService_GetByPokemonName_Success(string name, string expectedName)
        {
            var pokemon = await _pokemonApiService.GetByNameAsync(name);

            Assert.IsNotNull(pokemon);
            Assert.IsInstanceOfType(pokemon, typeof(PokemonDto));
            Assert.AreEqual(pokemon.Name, expectedName);
            Assert.IsNotNull(pokemon.Sprite);
        }
        #endregion

        #region PokemonApiService_GetByPokemonId_Success
        [TestMethod]
        [DataRow(1, Constants.Bulbasaur)]
        [DataRow(2, Constants.Ivysaur)]
        [DataRow(3, Constants.Venusaur)]
        [DataRow(4, Constants.Charmander)]
        [DataRow(5, Constants.Charmeleon)]
        [DataRow(6, Constants.Charizard)]
        [DataRow(7, Constants.Squirtle)]
        [DataRow(8, Constants.Wartortle)]
        [DataRow(9, Constants.Blastoise)]
        [DataRow(10, Constants.Caterpie)]
        public async Task PokemonApiService_GetByPokemonId_Success(int id, string expectedName)
        {
            var pokemon = await _pokemonApiService.GetByIdAsync(id);

            Assert.IsNotNull(pokemon);
            Assert.IsInstanceOfType(pokemon, typeof(PokemonDto));
            Assert.AreEqual(pokemon.Name, expectedName);
            Assert.IsNotNull(pokemon.Sprite);
        }

        #endregion

        #region PokemonApiService_NameNotFound_ThrowsApiException_404_Success
        [TestMethod]
        public async Task PokemonApiService_NameNotFound_ThrowsApiException_404_Success()
        {
            ApiException apiException = null;

            try { _ = await _pokemonApiService.GetByNameAsync("AlabasterDuck"); }
            catch (ApiException ex) { apiException = ex; }

            Assert.IsNotNull(apiException);
            Assert.IsNotNull(apiException.Message);
            Assert.IsNotNull(apiException.InnerException);

            Assert.IsNotNull("An error occurred while processing the request.", apiException.Message);
            Assert.AreEqual("Response status code does not indicate success: 404 (Not Found).", apiException.InnerException.Message);

        }
        #endregion
    }
}
