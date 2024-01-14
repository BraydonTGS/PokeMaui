using CommunityToolkit.Mvvm.ComponentModel;
using PokeMaui.Business.Models;

namespace PokeMaui.Maui.ViewModel
{
    [QueryProperty(nameof(PokemonDto), nameof(PokemonDto))]
    public partial class PokemonDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        private PokemonDto _pokemonDto;
        public PokemonDetailsViewModel()
        {
           
        }
    }
}
