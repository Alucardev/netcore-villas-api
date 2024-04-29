using AutoMapper;
using Data.Dtos;
using Data.Models;

namespace Villa_API.Helpers
{
    public class MappingConfig : Profile
    {

        public MappingConfig()
        {
            CreateMap<Villa, VillaDto>().ReverseMap();
            CreateMap<Villa, VillaCreateDto>().ReverseMap();
            CreateMap<Villa, VillaUpdateDto>().ReverseMap();
            CreateMap<NumberVilla, NumberVillaDto>().ReverseMap();
            CreateMap<NumberVilla, NumberVillaUpdateDto>().ReverseMap();
            CreateMap<NumberVilla, NumberVillaCreateDto>().ReverseMap();
        }
    }
}
