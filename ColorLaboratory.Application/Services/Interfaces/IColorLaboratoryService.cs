using System.Threading;
using System.Threading.Tasks;
using ColorLaboratory.Application.Services.Contracts;

namespace ColorLaboratory.Application.Services.Interfaces
{
    public interface IColorLaboratoryService
    {
        Task<Cmyk2Rgb.Response> Cmyk2Rgb(
            Cmyk2Rgb.Request request,
            CancellationToken cancellationToken);
        Task<Rgb2Cmyk.Response> Rgb2Cmyk(
            Rgb2Cmyk.Request request,
            CancellationToken cancellationToken);
    }
}
