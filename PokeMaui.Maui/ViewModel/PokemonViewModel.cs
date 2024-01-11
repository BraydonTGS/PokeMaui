using PokeMaui.Business.Api;
using PokeMaui.Business.Models;
using PokeMaui.Global.Constants;
using System.Collections.ObjectModel;

namespace PokeMaui.Maui.ViewModel
{
    public partial class PokemonViewModel : BaseViewModel
    {
        private readonly PokemonApiService _apiService;

        public ObservableCollection<PokemonDto> Pokemons { get; set; }

        public PokemonViewModel(PokemonApiService apiService)
        {
            _apiService = apiService;

            Task.WaitAll(InitTestData());
        }

        #region InitTestData
        /// <summary>
        /// For now Init with Test Data
        /// </summary>
        /// <returns></returns>
        private async Task InitTestData()
        {
            Pokemons = new ObservableCollection<PokemonDto>();
            var testNames = new List<string>() { Constants.Charmander, Constants.Charmeleon, Constants.Charizard };

            foreach (var test in testNames)
            {
                var dto = await _apiService.GetByNameAsync(test);

                if (dto != null) { Pokemons.Add(dto); }
            }
        }
        #endregion
    }
}
