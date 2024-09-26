using MediatR;

namespace Poliedro.Billing.Application.Destino.Commands.CreateServerCommand;

public record CreateDestinoCommand(int IdDestino,string Descripcion) : IRequest<bool>;