using PokeMaui.Business.Api;
using PokeMaui.Business.Models;

namespace PokeMaui.Business.Mappers
{
    /// <summary>
    /// PokemonApiResponseMapper - Map From the PokemonApiResponse to the PokemonDto
    /// </summary>
    public class PokemonApiResponseMapper : IApiResponseMapper<PokemonDto, PokemonApiResponse>
    {
        public PokemonDto MapFromApiResponseObject(PokemonApiResponse response)
        {
            return new PokemonDto();
        }
    }
}
