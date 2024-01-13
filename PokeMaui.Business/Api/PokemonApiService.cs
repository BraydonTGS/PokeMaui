using PokeMaui.Business.Mappers;
using PokeMaui.Business.Models;
using PokeMaui.Global.Constants;
using System.Collections.ObjectModel;

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

        #region GetByNameAsync
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
        #endregion

        #region GetByIdAsync
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
            catch (Exception) { throw; }
        }
        #endregion

        #region GenerateRandomPokemonAsync
        /// <summary>
        /// Generates 20 Random Pokemon
        /// </summary>
        /// <returns></returns>
        public async Task<ObservableCollection<PokemonDto>> GenerateRandomPokemonAsync(int numToGenerate = 20)
        {
            try
            {
                if (numToGenerate is 0) numToGenerate = 20;
                var caughtPokemon = new ObservableCollection<PokemonDto>();

                var random = new Random();
                var pokemonId = new HashSet<int>();

                for (int i = 1; i <= numToGenerate; i++)
                {
                    int randomId;
                    do
                        randomId = random.Next(1, 999);
                    while (pokemonId.Contains(randomId));

                    pokemonId.Add(randomId);

                    var dto = await GetByIdAsync(randomId);

                    if (dto != null)
                        caughtPokemon.Add(dto);
                }

                return caughtPokemon;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
