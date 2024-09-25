using MediatR;

namespace Poliedro.Billing.Application.Conductor.Commands.CreateServerCommand;

public record CreateControlViajeProductoCommand(int idControlViajeProducto,int idControlViaje, int idProducto) : IRequest<bool>;