using MediatR;

namespace Poliedro.Billing.Application.Conductor.Commands.CreateServerCommand;

public record CreateConductorCommand(string Name) : IRequest<bool>
{
    
}
