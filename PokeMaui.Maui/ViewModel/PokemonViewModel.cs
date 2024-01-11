using CommunityToolkit.Mvvm.Input;
using PokeMaui.Business.Api;
using PokeMaui.Business.Models;
using PokeMaui.Global.Constants;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PokeMaui.Maui.ViewModel
{
    public partial class PokemonViewModel : BaseViewModel
    {
        private readonly PokemonApiService _apiService;

        public ObservableCollection<PokemonDto> Pokemons { get; set; }


        public PokemonViewModel(PokemonApiService apiService)
        {
            _apiService = apiService;

            Title = "Poke-Maui!";

            Pokemons = new();
        }


        #region InitTestData

        /// <summary>
        /// For now Init with Test Data
        /// </summary>
        /// <returns></returns>
        [RelayCommand]
        private async Task InitTestDataAsync()
        {
            try
            {
                if (IsBusy) return;

                IsBusy = true;

                if (Pokemons.Any()) { return; }

                var testNames = new List<string>() { Constants.Charmander, Constants.Charmeleon, Constants.Charizard };

                if (Pokemons.Count != 0)
                    Pokemons.Clear();

                foreach (var test in testNames)
                {
                    var dto = await _apiService.GetByNameAsync(test);
                    if (dto != null)
                        Pokemons.Add(dto);
                }
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
