using PokeMaui.Maui.ViewModel;

namespace PokeMaui.Maui.View;

public partial class PokemonView : ContentPage
{
	public PokemonView(PokemonViewModel pokemonViewModel)
	{
		InitializeComponent();
		BindingContext = pokemonViewModel;
	}
}