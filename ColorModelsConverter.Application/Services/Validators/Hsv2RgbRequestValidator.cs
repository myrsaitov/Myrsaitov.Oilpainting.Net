using ColorModelsConverter.Application.Services.Contracts;
using ColorModelsConverter.Application.Services.Validators.Base;
using FluentValidation;

namespace ColorModelsConverter.Application.Services.Validators
{
    public class Hsv2RgbRequestValidator : NullReferenceAbstractValidator<HsvDto>
    {
        public Hsv2RgbRequestValidator()
        {
            RuleFor(x => x)
                .NotNull().WithMessage("HsvDto is null");

            RuleFor(x => x.Hue)
                .NotNull().WithMessage("HsvDto: Hue is null")
                .InclusiveBetween(0, 360);

            RuleFor(x => x.Saturation)
                .NotNull().WithMessage("HsvDto: Saturation is null")
                .InclusiveBetween(0, 1);

            RuleFor(x => x.Value)
                .NotNull().WithMessage("HsvDto: Value is null")
                .InclusiveBetween(0, 1);
        }
    }
}
