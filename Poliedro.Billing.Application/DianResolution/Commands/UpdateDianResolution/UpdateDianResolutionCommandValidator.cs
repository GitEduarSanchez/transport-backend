using FluentValidation;
using Poliedro.Billing.Application.DianResolution.Commands.CreateDianResolution;
using Poliedro.Billing.Domain.Ports;

namespace Poliedro.Billing.Application.ClientBillingElectronic.Commands.UpdateClientBillingElectronic
{
    public class UpdateDianResolutionCommandValidator : AbstractValidator<UpdateDianResolutionCommand>
    {
        public UpdateDianResolutionCommandValidator(IMessageProvider messageProvider)
        {
            RuleFor(x => x.id)
                .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull)
                .NotEmpty().WithMessage(messageProvider.ErrorValidatorFieldNotEmpty);
            
            When(x => !string.IsNullOrEmpty(x.ResolutionNumber), () =>
            {
                RuleFor(x => x.ResolutionNumber)
                    .NotEmpty().WithMessage(messageProvider.ErrorValidatorFieldNotNull);
            });

            When(x => !string.IsNullOrEmpty(x.Prefix), () =>
            {
                RuleFor(x => x.Prefix)
                    .NotEmpty().WithMessage(messageProvider.ErrorValidatorFieldNotEmpty);
            });

            When(x => x.InitialRange != 0, () =>
            {
                RuleFor(x => x.InitialRange)
                    .GreaterThan(0).WithMessage(messageProvider.ErrorValidatorFieldGreatherThanZero);
            });

            When(x => x.FinalRange != 0, () =>
            {
                RuleFor(x => x.FinalRange)
                    .GreaterThan(0).WithMessage(messageProvider.ErrorValidatorFieldGreatherThanZero);
            });

            When(x => x.ResolutionDate != default, () =>
            {
                RuleFor(x => x.ResolutionDate)
                    .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull);
            });

            When(x => !string.IsNullOrEmpty(x.Description), () =>
            {
                RuleFor(x => x.Description)
                    .NotEmpty().WithMessage(messageProvider.ErrorValidatorFieldNotEmpty);
            });

            When(x => x.ResolutionFile != null, () =>
            {
                RuleFor(x => x.ResolutionFile)
                    .NotEmpty().WithMessage(messageProvider.ErrorValidatorFieldNotEmpty)
                    .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull);
            });

            When(x => x.CreationDate != default, () =>
            {
                RuleFor(x => x.CreationDate)
                    .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull);
            });

            When(x => x.VigencyMonth != 0, () =>
            {
                RuleFor(x => x.VigencyMonth)
                    .GreaterThan(0).WithMessage(messageProvider.ErrorValidatorFieldGreatherThanZero)
                    .LessThan(12).WithMessage(messageProvider.ErrorValidatorFieldLessThanTwelve);
            });

            When(x => x.ExpirationDate != default, () =>
            {
                RuleFor(x => x.ExpirationDate)
                    .NotNull().WithMessage(messageProvider.ErrorValidatorFieldNotNull);
            });

            When(x => x.ResolutionType != default, () =>
            {
                RuleFor(x => x.ResolutionType)
                    .IsInEnum().WithMessage(messageProvider.ErrorValidatorResolutionTypeValid);
            });

            When(x => x.ClientBillingElectronicId != default, () =>
            {
                RuleFor(x => x.ClientBillingElectronicId)
                    .GreaterThan(0).WithMessage(messageProvider.ErrorValidatorFieldGreatherThanZero);
            });
        }
    }
}
