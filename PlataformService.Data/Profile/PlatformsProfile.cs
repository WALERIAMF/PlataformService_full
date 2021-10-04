using PlataformService.Data.Entity;
using PlataformService.Domain.Model;

namespace PlataformService.Data.Profile
{
    public class PlatformsProfile : AutoMapper.Profile
    {
        public PlatformsProfile()
        {
            CreateMap<PlatformEntity, PlatformModel>().ReverseMap();
        }
    }
}