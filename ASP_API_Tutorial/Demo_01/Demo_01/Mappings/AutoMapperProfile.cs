using AutoMapper;
using Demo_01.Models.Domain;
using Demo_01.Models.DTOs;

namespace Demo_01.Mappings
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegionDTO, Region>().ReverseMap();
            CreateMap<AddRegionRequestDTO, Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDTO, Region>().ReverseMap();

            CreateMap<AddWalkRequestDTO,Walk>().ReverseMap();
            CreateMap<UpdateWalkRequestDTO,Walk>().ReverseMap();
            CreateMap<WalkDTO,Walk>().ReverseMap();
        }
    }
}
