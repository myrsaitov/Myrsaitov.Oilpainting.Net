using System.Threading;
using System.Threading.Tasks;
using ColorLaboratory.Services.Interfaces;
using ColorLaboratory.Application.Services.Contracts;
using System.Linq;
using System;

namespace ColorLaboratory.Application.Services
{
    public partial class ColorLaboratoryServiceV1 : IColorLaboratoryService
    {
        /// <summary>
        /// Преобразование из CMYK в RGB
        /// https://www.rapidtables.com/convert/color/cmyk-to-rgb.html
        /// </summary>
        /// <param name="request">цвет в кодировке CMYK</param>
        /// <param name="cancellationToken"></param>
        /// <returns>цвет в кодировке RGB</returns>
        public async Task<Cmyk2Rgb.Response> Cmyk2Rgb(
            Cmyk2Rgb.Request request,
            CancellationToken cancellationToken)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var response = new Cmyk2Rgb.Response { };

            response.rgb.R = (byte)(255 * (1 - request.cmyk.C) * (1 - request.cmyk.K));
            response.rgb.G = (byte)(255 * (1 - request.cmyk.M) * (1 - request.cmyk.K));
            response.rgb.B = (byte)(255 * (1 - request.cmyk.Y) * (1 - request.cmyk.K));

            return response;
        }
    }
}
