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
        public async Task Rgb2Cmyk_Returns_Response_Success(
            Rgb2Cmyk.Request request,
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
            Rgb2Cmyk.Request request,
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
            Rgb2Cmyk.Request request,
            CancellationToken cancellationToken)
        {
            // Arrange
            request.rgb = null;

            // Act
            await Assert.ThrowsAsync<Rgb2CmykNotValidException>(
                async () => await _colorLaboratoryServiceV1.Rgb2Cmyk(
                    request,
                    cancellationToken));
        }

    }
}
