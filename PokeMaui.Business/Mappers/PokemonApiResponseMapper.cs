using PokeMaui.Business.Api;
using PokeMaui.Business.Helpers;
using PokeMaui.Business.Models;
using PokeMaui.Entity.Entities;
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
        public PokemonApiResponseMapper()
        {
        }

        #region MapFromApiResponseObject
        /// <summary>
        /// Main Method for Mapping From the <see cref="PokemonApiResponse"/> to the <see cref="PokemonDto"/>
        /// 
        /// Name
        /// 
        /// Sprite
        /// 
        /// Types
        /// 
        /// Abilities
        /// 
        /// BaseExp
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

            if (response.types is not null)
                GeneratePokemonTypesFromResponse(pokemonDto, response.types);

            if (response.base_experience is not null)
                pokemonDto.BaseExperience = (int)response.base_experience;


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
            return FormattingHelpers.UppercaseFirstCharacter(name);
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

        #region GeneratePokemonTypesFromResponse
        /// <summary>
        /// Generates the Collection of PokemonTypeDto(s) from the PokemonApiResponse's Types Property
        /// </summary>
        /// <param name="pokemonDto"></param>
        /// <param name="types"></param>
        private void GeneratePokemonTypesFromResponse(PokemonDto pokemonDto, List<Api.Type> types)
        {
            if (types.Count == 0) return;

            var pokemonTypes = new ObservableCollection<PokemonTypesDto>();

            foreach (var type in types)
            {
                if (type.type is not null)
                {
                    var dtoType = new PokemonTypesDto()
                    {
                        Type = new TypeDto()
                        {
                            Id = Guid.NewGuid(),
                            Name = type.type?.name is not null ? FormattingHelpers.UppercaseFirstCharacter(type.type.name) : Constants.NotAvailable
                        },
                    };
                    dtoType.PokemonId = pokemonDto.Id;
                    dtoType.TypeId = dtoType.Type.Id;

                  pokemonTypes.Add(dtoType);
                }           
            }
            pokemonDto.PokemonTypes = pokemonTypes;
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
