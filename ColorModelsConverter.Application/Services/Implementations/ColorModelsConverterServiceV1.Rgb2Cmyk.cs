using System.Threading;
using System.Threading.Tasks;
using ColorModelsConverter.Application.Services.Interfaces;
using ColorModelsConverter.Application.Services.Contracts;
using System.Linq;
using System;
using ColorModelsConverter.Application.Services.Validators;
using ColorModelsConverter.Application.Services.Exceptions;
using ColorModelsConverter.Domain;

namespace ColorModelsConverter.Application.Services.Implementations
{
    public partial class ColorModelsConverterServiceV1 : IColorModelsConverterService
    {
        /// <summary>
        /// Преобразование из RGB в CMYK
        /// https://www.rapidtables.com/convert/color/rgb-to-cmyk.html
        /// </summary>
        /// <param name="request">цвет в кодировке RGB</param>
        /// <param name="cancellationToken"></param>
        /// <returns>цвет в кодировке CMYK</returns>
        public async Task<CmykDto> Rgb2Cmyk(
            RgbDto request,
            CancellationToken cancellationToken)
        {
            // Fluent Validation
            var validator = new Rgb2CmykRequestValidator();
            var result = await validator.ValidateAsync(request);

            if (!result.IsValid)
            {
                throw new Rgb2CmykNotValidException(result.Errors.Select(x => x.ErrorMessage).ToString());
            }

            var response = new CmykDto {};

            double R = (double)request.R / 255;
            double G = (double)request.G / 255;
            double B = (double)request.B / 255;

            double K = 1 - (new double[] { R, G, B }.Max());
            if (K < 1)
            {
                response.C = (1 - R - K) / (1 - K);
                response.M = (1 - G - K) / (1 - K);
                response.Y = (1 - B - K) / (1 - K);
                response.K = K;
            }
            else if (K == 1)
            {
                response.C = 0;
                response.M = 0;
                response.Y = 0;
                response.K = K;
            }

            return response;
        }
    }
}
