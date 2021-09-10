using ColorModelsConverter.Application.Services.Contracts;
using ColorModelsConverter.Domain;
using Mapster;

namespace ColorModelsConverter.Mapper.MapProfiles
{
    public class CmykMapProfile
    {
        public static TypeAdapterConfig GetConfiguredMappingConfig()
        {
            var config = TypeAdapterConfig.GlobalSettings;

            config.NewConfig<Cmyk, CmykDto>();
            config.NewConfig<CmykDto, Cmyk>();

            return config;
        }
    }
}