using MediatR;
using Poliedro.Billing.Application.Producto.Dto;
using Poliedro.Billing.Domain.Producto.Ports;

namespace Poliedro.Billing.Application.Producto.Query;

public class GetByIdproductoHandle(IProductoRepository ProductoRepository) : IRequestHandler<GetByIdProductoQuery, ProductoDto>
{
    public async Task<ProductoDto> Handle(GetByIdProductoQuery request, CancellationToken cancellationToken)
    {
        var getByIdproducto = await ProductoRepository.GetById(request.Id);
        return new ProductoDto(Id: getByIdproducto.Id, Name: getByIdproducto.Name);
    }
}
