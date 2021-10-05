using FluentValidation;
using PlataformService.Domain.Request;

namespace PlataformService.Service.Validators

{
    public class PlatformPutRequestValidator : AbstractValidator<PlatformPutRequest>
    {
        public PlatformPutRequestValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("É necessário informar o Nome.");
            RuleFor(x => x.Publisher).NotNull().NotEmpty().WithMessage("É necessário informar o editor.");
        }
    }
}
