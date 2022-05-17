using AutoMapper;
using PlatformService.Models;
using PlatformService.Dtos;

namespace PlatformService.Profiles
{
    public class PlatformProfile : Profile
    {
        public void PlatformsProfile()
        {
            // Source -> Target
            // It maps the data in our model, to our DTO
            CreateMap<Platform,PlatformReadDto>();
            CreateMap<PlatformCreateDto,Platform>();
        }
    }
}