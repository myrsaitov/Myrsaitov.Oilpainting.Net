using System.Threading;
using System.Threading.Tasks;
using ColorModelsConverter.Application.Services.Contracts;

namespace ColorModelsConverter.Application.Services.Interfaces
{
    public interface IColorModelsConverterService
    {
        Task<RgbDto> Cmyk2Rgb(
            CmykDto request,
            CancellationToken cancellationToken);
        Task<CmykDto> Rgb2Cmyk(
            RgbDto request,
            CancellationToken cancellationToken);
    }
}
