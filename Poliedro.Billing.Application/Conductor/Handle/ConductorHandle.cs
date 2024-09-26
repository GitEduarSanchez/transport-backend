using MediatR;
using Poliedro.Billing.Application.Producto.Commands.CreateServerCommand;
using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Producto.Entities;
using Poliedro.Billing.Domain.Producto.Ports;

namespace Poliedro.Billing.Application.Producto.Handle;

public class ProductoHandle(IProductoRepository _ProductoRepository) : IRequestHandler<CreateProductoCommand, bool>
{
    public async Task<bool> Handle(CreateProductoCommand request, CancellationToken cancellationToken)
    {
        ProductoEntity producto = new ProductoEntity() { idProducto};
        return await _ProductoRepository.SaveAsync(producto);
    }
}
