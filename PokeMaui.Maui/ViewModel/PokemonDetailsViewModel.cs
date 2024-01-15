using CommunityToolkit.Mvvm.ComponentModel;
using PokeMaui.Business.Models;
using PokeMaui.Global.Constants;

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
    }
}
