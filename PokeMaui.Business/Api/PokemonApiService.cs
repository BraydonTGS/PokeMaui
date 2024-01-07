using PokeMaui.Business.Connection;
using PokeMaui.Business.Models;

namespace PokeMaui.Business.Api
{
    public class PokemonApiService
    {
        private readonly IApiService<ApiResponseWrapper<PokemonApiResponse>> _apiService;

        public PokemonApiService(ApiService<ApiResponseWrapper<PokemonApiResponse>> apiService)
        {
            _apiService = apiService;
            _apiService.SetApiUrl(Hidden.GetApiUrl());
        }
        public async Task<List<PokemonDto>> GetAsync()
        {
            var response = await _apiService.GetApiResponseAsync();

            var data = response.GetDataFromResponse();

            // Map From Api Response to PokemonDto //

            return new List<PokemonDto>();
        }
    }
}
