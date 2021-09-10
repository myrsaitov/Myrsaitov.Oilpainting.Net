using System.Threading;
using System.Threading.Tasks;
using ColorModelsConverter.Application.Services.Contracts;

namespace ColorModelsConverter.Application.Services.Interfaces
{
    public interface IColorModelsConverterService
    {
        Task<Cmyk2Rgb.Response> Cmyk2Rgb(
            Cmyk2Rgb.Request request,
            CancellationToken cancellationToken);
        Task<Rgb2Cmyk.Response> Rgb2Cmyk(
            Rgb2Cmyk.Request request,
            CancellationToken cancellationToken);
    }
}
