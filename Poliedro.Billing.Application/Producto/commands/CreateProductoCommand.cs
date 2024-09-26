using MediatR;

namespace Poliedro.Billing.Application.Producto.Commands.CreateServerCommand;

public record CreateProductoCommand(int idProducto, String descripcion, int UnidadMedida) : IRequest<bool>;