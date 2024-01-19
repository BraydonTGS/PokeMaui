using PokeMaui.Maui.ViewModel;

namespace PokeMaui.Maui.View;

public partial class PokemonDiscoverPage : ContentPage
{
    public PokemonDiscoverPage(PokemonDiscoverViewModel pokemonDiscoverViewModel)
    {
        InitializeComponent();
        BindingContext = pokemonDiscoverViewModel;
    }
}