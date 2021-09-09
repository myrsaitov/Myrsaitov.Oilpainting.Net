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
        /// Преобразование из RGB в CMYK
        /// https://www.rapidtables.com/convert/color/rgb-to-cmyk.html
        /// </summary>
        /// <param name="request">цвет в кодировке RGB</param>
        /// <param name="cancellationToken"></param>
        /// <returns>цвет в кодировке CMYK</returns>
        public async Task<Rgb2Cmyk.Response> Rgb2Cmyk(
            Rgb2Cmyk.Request request,
            CancellationToken cancellationToken)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var response = new Rgb2Cmyk.Response { };

            double R = (double)request.rgb.R / 255;
            double G = (double)request.rgb.G / 255;
            double B = (double)request.rgb.B / 255;

            double K = 1 - (new double[] { R, G, B }.Max());
            if (K < 1)
            {
                response.cmyk.C = (1 - R - K) / (1 - K);
                response.cmyk.M = (1 - G - K) / (1 - K);
                response.cmyk.Y = (1 - B - K) / (1 - K);
                response.cmyk.K = K;
            }
            else if (K == 1)
            {
                response.cmyk.C = 0;
                response.cmyk.M = 0;
                response.cmyk.Y = 0;
                response.cmyk.K = K;
            }

            return response;
        }
    }
}
