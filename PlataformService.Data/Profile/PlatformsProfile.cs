using PlataformService.Data.Entity;
using PlataformService.Domain.Dto;
using PlataformService.Domain.Model;
using PlataformService.Domain.Request;

namespace PlataformService.Data.Profile
{
    public class PlatformsProfile : AutoMapper.Profile
    {
        public PlatformsProfile()
        {
            CreateMap<PlatformEntity, PlatformModel>().ReverseMap();
            CreateMap<PlatformPostRequest, PlatformModel>().ReverseMap();
            CreateMap<PlatformPutRequest, PlatformModel>().ReverseMap();
            CreateMap<PlatformDto, PlatformModel>().ReverseMap();
        }
    }
}