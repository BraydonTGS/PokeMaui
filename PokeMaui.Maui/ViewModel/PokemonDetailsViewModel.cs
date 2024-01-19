using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PokeMaui.Business.Models;
using PokeMaui.Global.Constants;
using System.Runtime.CompilerServices;

namespace PokeMaui.Maui.ViewModel
{
    [QueryProperty(nameof(PokemonDto), Constants.PokemonKey)]
    public partial class PokemonDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        private PokemonDto _pokemonDto;
        public PokemonDetailsViewModel()
        {
           
        }

        #region CatchPokemonAsync
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [RelayCommand]
        private async Task CatchPokemonAsync()
        {
            try
            {
                await Shell.Current.DisplayAlert("Hello!", "This is not implemented yet!!!", "OK");
            }
            catch (Exception)
            {
              throw;
            }
        }
        #endregion
    }
}
