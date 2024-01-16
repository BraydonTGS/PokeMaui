using PokeMaui.Business.Api;
using PokeMaui.Business.Helpers;
using PokeMaui.Business.Models;
using PokeMaui.Global.Constants;
using System.Collections.ObjectModel;

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

            if (response.abilities is not null)
                GeneratePokemonAbilitiesFromResponse(pokemonDto, response.abilities);

            if (response.base_experience is not null)
                pokemonDto.BaseExperience = (int)response.base_experience;

            if(response.height is not null)
                pokemonDto.Height = (int)response.height;

            if(response.weight is not null)
                pokemonDto.Weight = (int)response.weight;

            if(response.order is not null)
                pokemonDto.Order = (int)response.order;



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

        #region GeneratePokemonAbilitiesFromResponse
        /// <summary>
        /// Generates the Collection of PokemonAbilityDto(s) from the PokemonApiResponse's Abilities Property
        /// </summary>
        /// <param name="pokemonDto"></param>
        /// <param name="abilities"></param>
        private void GeneratePokemonAbilitiesFromResponse(PokemonDto pokemonDto, List<Ability> abilities)
        {
            if (abilities.Count == 0) return;

            var pokemonAbilities = new ObservableCollection<PokemonAbilityDto>();

            foreach (var ability in abilities)
            {
                if (ability.ability is not null)
                {
                    var dtoType = new PokemonAbilityDto()
                    {
                        Ability = new AbilityDto()
                        {
                            Id = Guid.NewGuid(),
                            Name = ability.ability?.name is not null ? FormattingHelpers.UppercaseFirstCharacter(ability.ability.name) : Constants.NotAvailable
                        },
                    };
                    dtoType.PokemonId = pokemonDto.Id;
                    dtoType.AbilityId = dtoType.Ability.Id;

                    pokemonAbilities.Add(dtoType);
                }
            }
            pokemonDto.PokemonAbility = pokemonAbilities;
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
                Sprite = new SpriteDto() {Id = Guid.NewGuid() },
                PokemonAbility = new ObservableCollection<PokemonAbilityDto>(),
                PokemonTypes = new ObservableCollection<PokemonTypesDto>(),
                Forms = new ObservableCollection<FormDto>(),
                PokemonMoves = new ObservableCollection<PokemonMovesDto>(),
            };
        }
        #endregion
    }
}
