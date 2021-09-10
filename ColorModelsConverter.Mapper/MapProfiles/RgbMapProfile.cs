using ColorModelsConverter.Application.Services.Contracts;
using ColorModelsConverter.Domain;
using Mapster;

namespace ColorModelsConverter.Mapper.MapProfiles
{
    public class RgbMapProfile
    {
        public static TypeAdapterConfig GetConfiguredMappingConfig()
        {
            var config = TypeAdapterConfig.GlobalSettings;

            config.NewConfig<Rgb, RgbDto>();
            config.NewConfig<RgbDto, Rgb>();

            return config;
        }
    }
}