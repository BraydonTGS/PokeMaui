using PokeMaui.Business.Api;
using PokeMaui.Business.Models;

namespace PokeMaui.Maui.ViewModel
{
    public partial class PokemonViewModel : BaseViewModel
    {
        private readonly PokemonApiService _apiService;

        public PokemonViewModel(PokemonApiService apiService)
        {
            _apiService = apiService;
        }
    }
}
