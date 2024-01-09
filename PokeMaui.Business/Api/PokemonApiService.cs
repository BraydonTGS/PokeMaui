
using PokeMaui.Business.Models;
using PokeMaui.Global.Constants;
using System.Reflection.Metadata.Ecma335;

namespace PokeMaui.Business.Api
{
    /// <summary>
    /// API Service used for interacting with the Pokemon API
    /// </summary>
    public class PokemonApiService
    {
        private readonly IApiService _apiService;

        public PokemonApiService(IApiService apiService)
        {
            _apiService = apiService;
            _apiService.SetBaseApiUrl(Constants.PokemonApiUrl);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<PokemonDto> GetByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) return null;

            var parameter = name.ToLower();
            var response = await _apiService.GetApiResponseAsync<PokemonApiResponse>(parameter);

            if(response is null) 
            return new PokemonDto();
        }
    }
}
