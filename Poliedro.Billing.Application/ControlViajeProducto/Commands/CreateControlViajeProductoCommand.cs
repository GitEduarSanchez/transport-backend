using MediatR;

namespace Poliedro.Billing.Application.ControlViajeProducto.Commands.CreateServerCommand;

public record CreateControlViajeProductoCommand(int idControlViajeProducto,int idControlViaje, int idProducto) : IRequest<bool>;