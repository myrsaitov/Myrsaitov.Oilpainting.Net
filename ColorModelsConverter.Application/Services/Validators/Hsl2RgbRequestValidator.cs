using ColorModelsConverter.Application.Services.Contracts;
using ColorModelsConverter.Application.Services.Validators.Base;
using FluentValidation;

namespace ColorModelsConverter.Application.Services.Validators
{
    public class Hsl2RgbRequestValidator : NullReferenceAbstractValidator<HslDto>
    {
        public Hsl2RgbRequestValidator()
        {
            RuleFor(x => x)
                .NotNull().WithMessage("HslDto is null");

            RuleFor(x => x.Hue)
                .NotNull().WithMessage("HslDto: Hue is null")
                .InclusiveBetween(0, 360);

            RuleFor(x => x.Saturation)
                .NotNull().WithMessage("HslDto: Saturation is null")
                .InclusiveBetween(0, 1);

            RuleFor(x => x.Lightness)
                .NotNull().WithMessage("HslDto: Lightness is null")
                .InclusiveBetween(0, 1);
        }
    }
}
