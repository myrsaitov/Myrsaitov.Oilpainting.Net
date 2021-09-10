﻿using System;
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
        public async Task Cmyk2Rgb_Returns_Response_Success(
            CmykDto request,
            CancellationToken cancellationToken)
        {
            // Arrange
            request.C = 0.1;
            request.M = 0.2;
            request.Y = 0.3;
            request.K = 0.4;
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
            CmykDto request,
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
            CmykDto request,
            CancellationToken cancellationToken)
        {
            // Arrange
            request.C = 1;
            request.M = 2;
            request.Y = 3;
            request.K = 4;

            // Act
            await Assert.ThrowsAsync<Cmyk2RgbNotValidException>(
                async () => await _colorLaboratoryServiceV1.Cmyk2Rgb(
                    request,
                    cancellationToken));
        }

    }
}