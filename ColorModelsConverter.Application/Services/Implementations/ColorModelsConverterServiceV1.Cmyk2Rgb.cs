using System.Threading;
using System.Threading.Tasks;
using ColorModelsConverter.Application.Services.Interfaces;
using ColorModelsConverter.Application.Services.Contracts;
using System.Linq;
using System;
using ColorModelsConverter.Application.Services.Validators;
using ColorModelsConverter.Application.Services.Exceptions;

namespace ColorModelsConverter.Application.Services.Implementations
{
    public partial class ColorModelsConverterServiceV1 : IColorModelsConverterService
    {
        /// <summary>
        /// Преобразование из CMYK в RGB
        /// https://www.rapidtables.com/convert/color/cmyk-to-rgb.html
        /// </summary>
        /// <param name="request">цвет в кодировке CMYK</param>
        /// <param name="cancellationToken"></param>
        /// <returns>цвет в кодировке RGB</returns>
        public async Task<RgbDto> Cmyk2Rgb(
            CmykDto request,
            CancellationToken cancellationToken)
        {
            // Fluent Validation
            var validator = new Cmyk2RgbRequestValidator();
            var result = await validator.ValidateAsync(request);
            if (!result.IsValid)
            {
                throw new Cmyk2RgbNotValidException(result.Errors.Select(x => x.ErrorMessage).ToString());
            }

            var response = new RgbDto { };

            response.R = (byte)(255 * (1 - request.C) * (1 - request.K));
            response.G = (byte)(255 * (1 - request.M) * (1 - request.K));
            response.B = (byte)(255 * (1 - request.Y) * (1 - request.K));

            return response;
        }
    }
}
