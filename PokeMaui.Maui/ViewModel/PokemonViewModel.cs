using CommunityToolkit.Mvvm.Input;
using PokeMaui.Business.Api;
using PokeMaui.Business.Models;
using PokeMaui.Maui.Navigation;
using PokeMaui.Maui.View;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PokeMaui.Maui.ViewModel
{
    public partial class PokemonViewModel : BaseViewModel
    {
        private readonly PokemonApiService _apiService;
        private readonly INavigationService _navigationService;

        public ObservableCollection<PokemonDto> Pokemons { get; set; }

        public PokemonViewModel(PokemonApiService apiService, INavigationService navigationService)
        {
            _apiService = apiService;
            _navigationService = navigationService;
            Title = "PokemonViewModel";
            Pokemons = new();
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

            var navigationParameters = new Dictionary<string, object>() { { nameof(PokemonDto), dto } };

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

                if (Pokemons.Count != 0)
                    Pokemons.Clear();

                var caughtPokemon = await _apiService.GenerateRandomPokemonAsync(50);
                if (caughtPokemon?.Count > 0)
                    foreach (var pokemon in caughtPokemon)
                        Pokemons.Add(pokemon);

            }
            catch (Exception ex)
            {
                // Todo: Navigate to Error View with Message - Don't Crash //
                Debug.WriteLine($"Error: {ex.Message}");
                await Shell.Current.DisplayAlert("Error:", $"Unable to get the Specified Pokemon", "OK");
            }
            finally { IsBusy = false; }
        }
        #endregion
    }
}
