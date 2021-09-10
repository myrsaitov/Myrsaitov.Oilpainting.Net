using ColorModelsConverter.Application.Services.Contracts;
using FluentValidation;

namespace ColorModelsConverter.Application.Services.Validators
{
    public class Cmyk2RgbRequestValidator : AbstractValidator<Cmyk2Rgb.Request>
    {
        public Cmyk2RgbRequestValidator()
        {
            RuleFor(x => x.cmyk.C)
                .NotNull().WithMessage("Cmyk2Rgb: C is null")
                .InclusiveBetween(0, 1);

            RuleFor(x => x.cmyk.M)
                .NotNull().WithMessage("Cmyk2Rgb: M is null")
                .InclusiveBetween(0, 1);

            RuleFor(x => x.cmyk.Y)
                .NotNull().WithMessage("Cmyk2Rgb: Y is null")
                .InclusiveBetween(0, 1);

            RuleFor(x => x.cmyk.K)
                .NotNull().WithMessage("Cmyk2Rgb: K is null")
                .InclusiveBetween(0, 1);
        }
    }
}
