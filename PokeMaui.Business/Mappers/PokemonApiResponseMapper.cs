using PokeMaui.Business.Api;
using PokeMaui.Business.Models;
using PokeMaui.Global.Constants;
using System.Collections.ObjectModel;
using System.Text;

namespace PokeMaui.Business.Mappers
{
    /// <summary>
    /// PokemonApiResponseMapper - Map From the PokemonApiResponse to the PokemonDto
    /// </summary>
    public class PokemonApiResponseMapper : IApiResponseMapper<PokemonDto, PokemonApiResponse>
    {
        private readonly StringBuilder _builder;
        public PokemonApiResponseMapper()
        {
            _builder = new StringBuilder();
        }

        #region MapFromApiResponseObject
        /// <summary>
        /// Main Method for Mapping From the <see cref="PokemonApiResponse"/> to the <see cref="PokemonDto"/>
        /// 
        /// Name
        /// 
        /// Sprite
        /// 
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public PokemonDto MapFromApiResponseObject(PokemonApiResponse response)
        {

            var pokemonDto = GenerateEmptyPokemonDto();

            if (!String.IsNullOrEmpty(response.name))
                pokemonDto.Name = GeneratePokemonNameFromResponse(response.name);

            if (response.sprites is not null)
                GeneratePokemonSpriteFromResponse(pokemonDto, response.sprites);

            return pokemonDto;
        }
        #endregion


        #region GeneratePokemonNameFromResponse
        /// <summary>
        /// Generate the PokemonDto name from the PokemonApiResponse's Name Property
        /// 
        /// Uppercase the First Letter
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private string GeneratePokemonNameFromResponse(string name)
        {
            _builder.Clear();

            var nameToFormat = name.ToLower().Trim();

            var results = _builder
                .Append(char.ToUpper(nameToFormat[0]))
                .Append(nameToFormat[1..])
                .ToString();

            if (!String.IsNullOrEmpty(results)) return results;

            _builder.Clear();

            return string.Empty;
        }
        #endregion

        #region GeneratePokemonSpriteFromResponse
        /// <summary>
        /// Generate the PokemonDto Sprite From the PokemonApiResponse's Sprite Property 
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="sprites"></param>
        private void GeneratePokemonSpriteFromResponse(PokemonDto dto, Sprites sprites)
        {
            var defaultSprite = sprites.front_default;
            var backupSprite = sprites.front_shiny;

            if (!String.IsNullOrEmpty(defaultSprite))
            {
                dto.Sprite.Name = Constants.DefaultSprite;
                dto.Sprite.Image = defaultSprite;
            }
            else if (!String.IsNullOrEmpty(backupSprite))
            {
                dto.Sprite.Name = Constants.ShinySprite;
                dto.Sprite.Image = backupSprite;
            }
            else
            {
                dto.Sprite.Name = Constants.NotAvailable;
                dto.Sprite.Image = string.Empty;
            }
        }
        #endregion

        #region GenerateEmptyPokemonDto
        /// <summary>
        /// Created an Empty Instance of a PokemonDto
        /// </summary>
        /// <returns></returns>
        private PokemonDto GenerateEmptyPokemonDto()
        {
            return new PokemonDto()
            {
                Id = Guid.NewGuid(),
                Sprite = new SpriteDto(),
                PokemonAbility = new ObservableCollection<PokemonAbilityDto>(),
                PokemonTypes = new ObservableCollection<PokemonTypesDto>(),
                Forms = new ObservableCollection<FormDto>(),
                PokemonMoves = new ObservableCollection<PokemonMovesDto>(),
            };
        }
        #endregion
    }
}
