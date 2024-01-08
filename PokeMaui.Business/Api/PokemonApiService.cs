using PokeMaui.Business.Models;
using PokeMaui.Global.Constants;

namespace PokeMaui.Business.Api
{
    /// <summary>
    /// API Service used for interacting with the Pokemon API
    /// </summary>
    public class PokemonApiService
    {
        private readonly IApiService<ApiResponseWrapper<PokemonApiResponse>> _apiService;

        public PokemonApiService(ApiService<ApiResponseWrapper<PokemonApiResponse>> apiService)
        {
            _apiService = apiService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<List<PokemonDto>> GetByNameAsync(string name)
        {
            _apiService.SetApiUrl(Constants.PokemonApiUrl, name);

            var response = await _apiService.GetApiResponseAsync();

            var data = response.GetDataFromResponse();

            // Map From Api Response to PokemonDto //

            return new List<PokemonDto>();
        }
    }
}
