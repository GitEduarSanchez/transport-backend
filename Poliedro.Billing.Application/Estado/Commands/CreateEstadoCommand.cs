using MediatR;

namespace Poliedro.Billing.Application.Conductor.Commands.CreateServerCommand;

public record CreateEstadoCommand(string Descripcion) : IRequest<bool>;