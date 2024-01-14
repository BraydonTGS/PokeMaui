using PokeMaui.Maui.ViewModel;

namespace PokeMaui.Maui.View;

public partial class PokemonDetailsView : ContentPage
{
	public PokemonDetailsView(PokemonDetailsViewModel pokemonDetailsViewModel)
	{
		InitializeComponent();
		BindingContext = pokemonDetailsViewModel;
	}
}