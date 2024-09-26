using MediatR;

namespace Poliedro.Billing.Application.Estado.Commands.CreateServerCommand;

public record CreateEstadorCommand(string Name) : IRequest<bool>;