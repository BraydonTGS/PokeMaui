using PokeMaui.Business.Mappers;
using PokeMaui.Business.Models;
using PokeMaui.Global.Constants;

namespace PokeMaui.Business.Api
{
    /// <summary>
    /// API Service used for interacting with the Pokemon API
    /// </summary>
    public class PokemonApiService
    {
        private readonly IApiService _apiService;
        private readonly IApiResponseMapper<PokemonDto, PokemonApiResponse> _mapper;

        public PokemonApiService(IApiService apiService,
            IApiResponseMapper<PokemonDto, PokemonApiResponse> mapper)
        {
            _apiService = apiService;
            _mapper = mapper;
            _apiService.SetBaseApiUrl(Constants.PokemonApiUrl);
        }

        /// <summary>
        /// Get by the Pokemon Name
        /// 
        /// Uses the PokemonApiServiceMapper to Map the Response to the PokemonDto
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<PokemonDto> GetByNameAsync(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name)) return null;

                var parameter = name.ToLower().Trim();
                var response = await _apiService.GetApiResponseAsync<PokemonApiResponse>(parameter);
                var result = _mapper.MapFromApiResponseObject(response);

                return result;
            }
            catch (Exception) { throw; }

        }


        /// <summary>
        /// Get by the Pokemon Id
        /// 
        /// Uses the PokemonApiServiceMapper to Map the Response to the PokemonDto
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<PokemonDto> GetByIdAsync(int id)
        {
            try
            {
                var parameter = id.ToString().Trim();
                var response = await _apiService.GetApiResponseAsync<PokemonApiResponse>(parameter);
                var result = _mapper.MapFromApiResponseObject(response);

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
