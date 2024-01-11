using PokeMaui.Business.Models;

namespace PokeMaui.Maui.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        public PokemonViewModel PokemonViewModel { get; set; }
   
        public MainViewModel(PokemonViewModel pokemonViewModel) 
        {
            // Todo: Create a ViewModel Registration Service //
            PokemonViewModel = pokemonViewModel;
        }
    }
}
