using FluentValidation;
using Poliedro.Billing.Domain.Ports;

namespace Poliedro.Billing.Application.DianResolution.Commands.DeleteDianResolution
{
    public class DeleteDianResolutionCommandValidator : AbstractValidator<DeleteDianResolutionCommand>
    {
        public DeleteDianResolutionCommandValidator(IMessageProvider messageProvider)
        {
            RuleFor(x =>x.ResolutionId)
                .NotEmpty().WithMessage(messageProvider.ErrorValidatorFieldNotNull)
                .NotEmpty().WithMessage(messageProvider.ErrorValidatorFieldNotEmpty);
        }
    }
}
