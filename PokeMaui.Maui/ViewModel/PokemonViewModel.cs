using CommunityToolkit.Mvvm.Input;
using PokeMaui.Business.Api;
using PokeMaui.Business.Models;
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

            Title = "PokemonViewModel";
         
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

                var random = new Random();
                var pokemonId = new HashSet<int>();

                for (int i = 1; i <= 20; i++)
                {
                    int randomId;
                    do
                        randomId = random.Next(1, 999);
                     while (pokemonId.Contains(randomId));

                    pokemonId.Add(randomId);

                    var dto = await _apiService.GetByIdAsync(randomId);

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

        /// <summary>
        /// Refresh the Pokemon Collection with a new set of Pokemon
        /// </summary>
        /// <returns></returns>
        [RelayCommand]
        private async Task RefreshAsync()
        {
            if (Pokemons.Count != 0)
                Pokemons.Clear();

            await InitTestDataAsync();
        }
    }
}
