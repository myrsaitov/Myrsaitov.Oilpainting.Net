using ColorModelsConverter.Application.Services.Contracts;
using FluentValidation;

namespace ColorModelsConverter.Application.Services.Validators
{
    public class Cmyk2RgbRequestValidator : AbstractValidator<CmykDto>
    {
        public Cmyk2RgbRequestValidator()
        {
            RuleFor(x => x.C)
                .NotNull().WithMessage("Cmyk2Rgb: C is null")
                .InclusiveBetween(0, 1);

            RuleFor(x => x.M)
                .NotNull().WithMessage("Cmyk2Rgb: M is null")
                .InclusiveBetween(0, 1);

            RuleFor(x => x.Y)
                .NotNull().WithMessage("Cmyk2Rgb: Y is null")
                .InclusiveBetween(0, 1);

            RuleFor(x => x.K)
                .NotNull().WithMessage("Cmyk2Rgb: K is null")
                .InclusiveBetween(0, 1);
        }
    }
}
