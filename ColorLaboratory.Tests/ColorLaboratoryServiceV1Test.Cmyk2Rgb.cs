using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using AutoFixture.Xunit2;
using ColorLaboratory.Application.Services.Contracts;
using ColorLaboratory.Application.Services.Exceptions;

namespace ColorLaboratory.Tests
{
    public partial class ColorLaboratoryServiceV1Test
    {
        [Theory]
        [AutoData]
        public async Task Cmyk2Rgb_Returns_Response_Success(
            Cmyk2Rgb.Request request,
            CancellationToken cancellationToken)
        {
            // Arrange
            request.cmyk.C = 0.1;
            request.cmyk.M = 0.2;
            request.cmyk.Y = 0.3;
            request.cmyk.K = 0.4;
            // Act
            var response = await _colorLaboratoryServiceV1.Cmyk2Rgb(
                request,
                cancellationToken);

            // Assert

            Assert.NotNull(response);
        }
        [Theory]
        [InlineAutoData(null)]
        public async Task Cmyk2Rgb_Throws_Exception_When_Request_Is_Null(
            Cmyk2Rgb.Request request,
            CancellationToken cancellationToken)
        {
            // Act
            await Assert.ThrowsAsync<ArgumentNullException>(
                async () => await _colorLaboratoryServiceV1.Cmyk2Rgb(
                    request,
                    cancellationToken));
        }
        [Theory]
        [AutoData]
        public async Task Cmyk2Rgb_Returns_Validation_Error(
            Cmyk2Rgb.Request request,
            CancellationToken cancellationToken)
        {
            // Arrange
            request.cmyk.C = 1;
            request.cmyk.M = 2;
            request.cmyk.Y = 3;
            request.cmyk.K = 4;

            // Act
            await Assert.ThrowsAsync<Cmyk2RgbNotValidException>(
                async () => await _colorLaboratoryServiceV1.Cmyk2Rgb(
                    request,
                    cancellationToken));
        }

    }
}
