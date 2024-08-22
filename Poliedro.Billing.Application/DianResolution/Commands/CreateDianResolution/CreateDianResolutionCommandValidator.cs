using FluentValidation;
using Poliedro.Billing.Domain.Ports;

namespace Poliedro.Billing.Application.DianResolution.Commands.CreateDianResolution
{
    public class CreateDianResolutionCommandValidator : AbstractValidator<CreateDianResolutionCommand>
    {
        public CreateDianResolutionCommandValidator(IMessageProvider messageProvider)
        {
            RuleFor(x => x.ResolutionNumber)
                .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull)
                .NotEmpty().WithMessage(messageProvider.ErrorValidatorFieldNotEmpty);

            RuleFor(x => x.Prefix)
                 .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull)
                .NotEmpty().WithMessage(messageProvider.ErrorValidatorFieldNotEmpty);

            RuleFor(x => x.InitialRange)
                .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull)
                .NotEmpty().WithMessage(messageProvider.ErrorValidatorFieldNotEmpty)
                .GreaterThan(0).WithMessage(messageProvider.ErrorValidatorFieldGreatherThanZero);

            RuleFor(x => x.FinalRange)
                .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull)
                .NotEmpty().WithMessage(messageProvider.ErrorValidatorFieldNotEmpty)
                .GreaterThan(0).WithMessage(messageProvider.ErrorValidatorFieldGreatherThanZero);

            RuleFor(x => x.ResolutionDate)
                .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull)
                .NotEmpty().WithMessage(messageProvider.ErrorValidatorFieldNotEmpty);
            RuleFor(x => x.ResolutionDate)
            .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull);

            RuleFor(x => x.Description)
                .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull);

            RuleFor(x => x.CreationDate)
                .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull);

            RuleFor(x => x.VigencyMonth)
                .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull)
                .GreaterThan(0).WithMessage(messageProvider.ErrorValidatorFieldGreatherThanZero)
                .LessThan(12).WithMessage(messageProvider.ErrorValidatorFieldLessThanTwelve);

            RuleFor(x => x.ExpirationDate)
                .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull);

            RuleFor(x => x.ResolutionType)
                .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull);

            RuleFor(x => x.ClientBillingElectronicId)
                .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull);
        }
    }
}
