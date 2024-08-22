using FluentValidation;
using Poliedro.Billing.Application.Server.Commands.CreateServerCommand;
using Poliedro.Billing.Domain.Ports;
using System.Net;

namespace Poliedro.Billing.Application.Server.Validator;

public class ServerCommandValidator : AbstractValidator<CreateServerCommand>
{
    public ServerCommandValidator(IMessageProvider messageProvider)
    {
        RuleFor(x => x.Ip)
            .NotEmpty().WithMessage("messageProvider.ErrrorValidatorIp")
            .Must(BeAValidIpAddress).WithMessage("The IP address must be a valid IPv4 or IPv6 address.");

        RuleFor(x => x.DatabaseName)
            .NotEmpty().WithMessage("The database name is required.");

        RuleFor(x => x.DbUsername)
            .NotEmpty().WithMessage("The database username is required.");

        RuleFor(x => x.DbPassword)
            .NotEmpty().WithMessage("The database password is required.");
    }
    private bool BeAValidIpAddress(string ip) => IPAddress.TryParse(ip, out _);
}

