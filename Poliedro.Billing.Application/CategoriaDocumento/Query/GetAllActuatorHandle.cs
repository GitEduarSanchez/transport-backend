using MediatR;
using Poliedro.Billing.Application.CategoriaDocumento.Dto;
using Poliedro.Billing.Domain.CategoriaDocumento.Ports;

namespace Poliedro.Billing.Application.CategoriaDocumento.Query;

public class GetAllActuatorHandle(ICategoriaDocumentoRepository _categoriaDocumentoRepository) : IRequestHandler<GetAllActuatorsQuery, IEnumerable<CategoriaDocumentoDto>>
{
    public async Task<IEnumerable<CategoriaDocumentoDto>> Handle(GetAllActuatorsQuery request, CancellationToken cancellationToken)
    {
        var entities = await _categoriaDocumentoRepository.GetAllAsync();
        return entities.Select(categoriaDocumento => new CategoriaDocumentoDto(
            Id: categoriaDocumento.Id,
            Descripcion: categoriaDocumento.Descripcion
        ));
    }

}
