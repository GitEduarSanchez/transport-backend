using MediatR;

namespace Poliedro.Billing.Application.Conductor.Commands.CreateServerCommand;

public record CreateTrailerCommand(string Name) : IRequest<bool>;