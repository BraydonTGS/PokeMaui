using PokeMaui.Maui.View;

namespace PokeMaui.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register Routing //
            Routing.RegisterRoute(nameof(PokemonView), typeof(PokemonView));
            Routing.RegisterRoute(nameof(PokemonDetailsView), typeof(PokemonDetailsView));           
        }
    }
}