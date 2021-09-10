using ColorModelsConverter.Application.Services.Contracts;
using ColorModelsConverter.Domain;
using Mapster;

namespace ColorModelsConverter.Mapper.MapProfiles
{
    public class HsvMapProfile
    {
        public static TypeAdapterConfig GetConfiguredMappingConfig()
        {
            var config = TypeAdapterConfig.GlobalSettings;

            config.NewConfig<Hsv, HsvDto>();
            config.NewConfig<HsvDto, Hsv>();

            return config;
        }
    }
}