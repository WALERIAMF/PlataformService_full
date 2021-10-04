using FluentValidation;
using PlataformService.Domain.Request;

namespace PlataformService.Service.Validators

{
    public class PlatformPostRequestValidator : AbstractValidator<PlatformPostRequest>
    {
        public PlatformPostRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("É necessário informar o Nome.");
            RuleFor(x => x.Publisher).NotEmpty().WithMessage("É necessário informar o editor.");
        }
    }
}
