using MediatR;

namespace Poliedro.Billing.Application.Conductor.Commands.CreateServerCommand;

public record CreateDestinoCommand(int IdDestino,string Descripcion) : IRequest<bool>;