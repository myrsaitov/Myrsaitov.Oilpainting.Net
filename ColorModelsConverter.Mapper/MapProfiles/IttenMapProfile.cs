using ColorModelsConverter.Application.Services.Contracts;
using ColorModelsConverter.Domain;
using Mapster;

namespace ColorModelsConverter.Mapper.MapProfiles
{
    public class IttenMapProfile
    {
        public static TypeAdapterConfig GetConfiguredMappingConfig()
        {
            var config = TypeAdapterConfig.GlobalSettings;

            config.NewConfig<Itten, IttenDto>();
            config.NewConfig<IttenDto, Itten>();

            return config;
        }
    }
}