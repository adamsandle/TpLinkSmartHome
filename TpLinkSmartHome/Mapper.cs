using AutoMapper;
using TpLinkSmartHome.models;

namespace TpLinkSmartHome
{
    internal static class MapConfigurations
    {
        public static MapperConfiguration Configs()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Response, DeviceSystemInfo>()
                    .Include<Response, PlugSystemInfo>()
                    .ForMember(x => x.Alias, m => m.MapFrom(c => c.System.SystemInfo.Alias))
                    .ForMember(x => x.Location, m => m.MapFrom(c => new Location{Latitude = c.System.SystemInfo.Latitude, Longitude = c.System.SystemInfo.Longitude}))
                    .ForMember(x => x.Mac, m => m.MapFrom(c => c.System.SystemInfo.Mac));


                cfg.CreateMap<Response, PlugSystemInfo>()
                    .ForMember(x => x.PowerState, m => m.MapFrom(c => c.System.SystemInfo.RelayState));

            });
        }
    }
}
