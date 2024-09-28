using MediatR;

namespace Poliedro.Billing.Application.Descargue.Commands.CreateServerCommand;

public record CreateDescargueCommand(string Name) : IRequest<bool>
{
    internal string descriocion;
}
