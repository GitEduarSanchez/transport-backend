using MediatR;

namespace Poliedro.Billing.Application.Producto.Commands.CreateServerCommand;

public record CreateProductoCommand(string descripcion, int UnidadMedida) : IRequest<bool>;