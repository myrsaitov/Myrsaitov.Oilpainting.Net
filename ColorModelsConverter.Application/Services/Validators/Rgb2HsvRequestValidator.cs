using ColorModelsConverter.Application.Services.Contracts;
using ColorModelsConverter.Application.Services.Validators.Base;
using FluentValidation;

namespace ColorModelsConverter.Application.Services.Validators
{
    public class Rgb2HsvRequestValidator : NullReferenceAbstractValidator<RgbDto>
    {
        public Rgb2HsvRequestValidator()
        {
            RuleFor(x => x)
                .NotNull().WithMessage("RgbDto is null");
        }
    }
}
