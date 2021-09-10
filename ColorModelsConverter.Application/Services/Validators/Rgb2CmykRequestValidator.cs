using ColorModelsConverter.Application.Services.Contracts;
using FluentValidation;

namespace ColorModelsConverter.Application.Services.Validators
{
    public class Rgb2CmykRequestValidator : AbstractValidator<RgbDto>
    {
        public Rgb2CmykRequestValidator()
        {
            RuleFor(x => x)
                .NotNull().WithMessage("RgbDto is null");
        }
    }
}
