using ColorModelsConverter.Application.Services.Contracts;
using ColorModelsConverter.Domain;
using Mapster;

namespace ColorModelsConverter.Mapper.MapProfiles
{
    public class HslMapProfile
    {
        public static TypeAdapterConfig GetConfiguredMappingConfig()
        {
            var config = TypeAdapterConfig.GlobalSettings;

            config.NewConfig<Hsl, HslDto>();
            config.NewConfig<HslDto, Hsl>();

            return config;
        }
    }
}