
using AutoMapper;
using PokeMaui.Business.MappingProfile;
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
        private readonly IMapper _mapper;

        public PokemonApiService(IApiService apiService, IMapper mapper)
        {
            _apiService = apiService;
            _mapper = mapper;
            _apiService.SetBaseApiUrl(Constants.PokemonApiUrl);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<PokemonDto> GetByNameAsync(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name)) return null;

                var parameter = name.ToLower();
                var response = await _apiService.GetApiResponseAsync<PokemonApiResponse>(parameter);
                var result = _mapper.Map<PokemonDto>(response);

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
