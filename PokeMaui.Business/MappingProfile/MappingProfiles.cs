using AutoMapper;
using PokeMaui.Business.Models;
using PokeMaui.Entity.Entities;

namespace PokeMaui.Business.MappingProfile
{
    /// <summary>
    /// AutoMapper Mapping Profile - Configure All Mappings within the Constructor
    /// </summary>
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // PokemonDto => Pokemon //
            CreateMap<PokemonDto, Pokemon>().ReverseMap();
            CreateMap<AbilityDto, Entity.Entities.Ability>().ReverseMap();
            CreateMap<FormDto, Entity.Entities.Form>().ReverseMap();
            CreateMap<MoveDto, Entity.Entities.Move>().ReverseMap();
            CreateMap<SpriteDto, Sprite>().ReverseMap();
            CreateMap<TypeDto, Entity.Entities.Type>().ReverseMap();
            CreateMap<PokemonAbilityDto, PokemonAbility>().ReverseMap();
            CreateMap<PokemonMovesDto, PokemonMoves>().ReverseMap();
            CreateMap<PokemonTypesDto, PokemonTypes>().ReverseMap();

        }
    }
}
