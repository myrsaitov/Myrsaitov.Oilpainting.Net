using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using AutoFixture.Xunit2;
using ColorModelsConverter.Application.Services.Contracts;
using ColorModelsConverter.Application.Services.Exceptions;

namespace ColorModelsConverter.Tests
{
    public partial class ColorModelsConverterServiceV1Test
    {
        [Theory]
        [AutoData]
        public async Task Rgb2Cmyk_Returns_Response_Success(
            RgbDto request,
            CancellationToken cancellationToken)
        {
            // Arrange

            // Act
            var response = await _colorLaboratoryServiceV1.Rgb2Cmyk(
                request,
                cancellationToken);

            // Assert

            Assert.NotNull(response);
        }
        [Theory]
        [InlineAutoData(null)]
        public async Task Rgb2Cmyk_Throws_Exception_When_Request_Is_Null(
            RgbDto request,
            CancellationToken cancellationToken)
        {
            // Act
            await Assert.ThrowsAsync<ArgumentNullException>(
                async () => await _colorLaboratoryServiceV1.Rgb2Cmyk(
                    request,
                    cancellationToken));
        }
        [Theory]
        [AutoData]
        public async Task Rgb2Cmyk_Returns_Validation_Error(
            RgbDto request,
            CancellationToken cancellationToken)
        {
            // Arrange
            request = null;

            // Act
            await Assert.ThrowsAsync<Rgb2CmykNotValidException>(
                async () => await _colorLaboratoryServiceV1.Rgb2Cmyk(
                    request,
                    cancellationToken));
        }

    }
}
