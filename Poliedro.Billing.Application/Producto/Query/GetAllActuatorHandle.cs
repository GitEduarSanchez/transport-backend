using MediatR;
using Poliedro.Billing.Application.Producto.Dto;
using Poliedro.Billing.Domain.Producto.Ports;

namespace Poliedro.Billing.Application.Producto.Query;

public class GetAllproductoHandle(IProductoRepository _ProductoRepository) : IRequestHandler<GetAllProductoQuery, IEnumerable<productoDto>>
{
    public async Task<IEnumerable<productoDto>> Handle(GetAllProductoQuery request, CancellationToken cancellationToken)
    {
        var entities = await _ProductoRepository.GetAllAsync();
        return entities.Select(Producto => new productoDto
        (
            Id: Producto.Id,
            descripcion: Producto.descripcion
        ));
    }
}
