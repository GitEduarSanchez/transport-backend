using MediatR;
using Poliedro.Billing.Application.Producto.Dto;

namespace Poliedro.Billing.Application.Producto.Query;

public class GetAllproductoHandle(IProductoRepository _ProductoRepository) : IRequestHandler<GetAllProductoQuery, IEnumerable<productoDto>>
{
    public async Task<IEnumerable<ProductoDto>> Handle(GetAllProductoQuery request, CancellationToken cancellationToken)
    {
        var entities = await _ProductoRepository.GetAllAsync();
        return entities.Select(Producto => new ProductoDto
        (
            Id: Producto.Id,
            descripcion: Producto.descripcion
        ));
    }
}
