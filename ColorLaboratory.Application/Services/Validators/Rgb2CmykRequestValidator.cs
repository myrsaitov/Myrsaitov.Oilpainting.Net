using ColorLaboratory.Application.Services.Contracts;
using FluentValidation;

namespace ColorLaboratory.Application.Services.Validators
{
    public class Rgb2CmykRequestValidator : AbstractValidator<Rgb2Cmyk.Request>
    {
        public Rgb2CmykRequestValidator()
        {
            RuleFor(x => x.rgb)
                .NotNull().WithMessage("Rgb2Cmyk: rgb is null");
        }
    }
}
