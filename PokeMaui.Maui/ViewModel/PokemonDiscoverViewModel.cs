using CommunityToolkit.Mvvm.Input;
using PokeMaui.Business.Api;
using PokeMaui.Business.Models;
using PokeMaui.Global.Constants;
using PokeMaui.Maui.Navigation;
using PokeMaui.Maui.View;
using System.Collections.ObjectModel;
using System.Diagnostics;


namespace PokeMaui.Maui.ViewModel
{
    public partial class PokemonDiscoverViewModel : BaseViewModel
    {
        private readonly PokemonApiService _apiService;
        private readonly INavigationService _navigationService;
        private readonly IConnectivity _connectivity;

        public ObservableCollection<PokemonDto> Pokemons { get; set; }

        public PokemonDiscoverViewModel(PokemonApiService apiService,
            INavigationService navigationService,
            IConnectivity connectivity)
        {
            _apiService = apiService;
            _navigationService = navigationService;
            Title = "PokemonViewModel";
            
           Pokemons = new();
            _connectivity = connectivity;
        }

        #region NavigateToDetailsAsync
        /// <summary>
        /// Navigate to the PokemonDetailsView
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [RelayCommand]
        public async Task NavigateToDetailsAsync(PokemonDto dto)
        {
            if (dto is null) return;

            var navigationParameters = new Dictionary<string, object>() { { Constants.PokemonKey, dto } };

            await _navigationService.NavigateToAsync(nameof(PokemonDetailsView), navigationParameters);
        }
        #endregion

        #region GenerateRandomPokemonAsync
        /// <summary>
        /// For now Init with Test Data
        /// </summary>
        /// <returns></returns>
        [RelayCommand]
        private async Task GenerateRandomPokemonAsync()
        {
            try
            {
                if (IsBusy) return;
                IsBusy = true;

                if (_connectivity.NetworkAccess != NetworkAccess.Internet)
                    await Shell.Current.DisplayAlert("Error:", $"No Internet Connection Found", "OK");

                if (Pokemons.Count != 0)
                    Pokemons.Clear();

                var caughtPokemon = await _apiService.GenerateRandomPokemonAsync(50);
                if (caughtPokemon?.Count > 0)
                    foreach (var pokemon in caughtPokemon)
                        Pokemons.Add(pokemon);

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
                await Shell.Current.DisplayAlert("Error:", $"Unable to get the Specified Pokemon", "OK");
            }
            finally { IsBusy = false; }
        }
        #endregion
    }
}
