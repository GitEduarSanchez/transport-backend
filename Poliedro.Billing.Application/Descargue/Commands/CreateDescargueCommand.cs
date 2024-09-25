using MediatR;

namespace Poliedro.Billing.Application.Conductor.Commands.CreateServerCommand;

public record CreateDescargueCommand(string Name) : IRequest<bool>;