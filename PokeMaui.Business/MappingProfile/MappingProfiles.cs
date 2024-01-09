using AutoMapper;
using PokeMaui.Business.Api;
using PokeMaui.Business.Models;

namespace PokeMaui.Business.MappingProfile
{
    /// <summary>
    /// AutoMapper Mapping Profile - Configure All Mappings within the Constructor
    /// </summary>
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // PokemonApiResponse => PokemonDto
            CreateMap<PokemonApiResponse, PokemonDto>(MemberList.Destination)
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
            .ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.order))
            .ForMember(dest => dest.Weight, opt => opt.MapFrom(src => src.weight))
            .ForMember(dest => dest.BaseExperience, opt => opt.MapFrom(src => src.base_experience))
            .ForMember(dest => dest.Height, opt => opt.MapFrom(src => src.height))
            .ForMember(dest => dest.Sprite, opt => opt.Ignore())
            .ForMember(dest => dest.PokemonTypes, opt => opt.Ignore())
            .ForMember(dest => dest.Forms, opt => opt.Ignore())
            .ForMember(dest => dest.PokemonMoves, opt => opt.Ignore())
            .ForMember(dest => dest.Sprite, opt => opt.Ignore())
            .ReverseMap();
        }
    }
}
