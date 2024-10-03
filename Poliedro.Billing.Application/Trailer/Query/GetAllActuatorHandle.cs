using MediatR;
using Poliedro.Billing.Application.Trailer.Dto;
using Poliedro.Billing.Domain.Trailer.Ports;

namespace Poliedro.Billing.Application.Trailer.Query;

public class GetAllTrailerHandle(ITrailerRepository _TrailerRepository) : IRequestHandler<GetAllTrailerQuery, IEnumerable<TrailerDto>>
{
    public async Task<IEnumerable<TrailerDto>> Handle(GetAllTrailerQuery request, CancellationToken cancellationToken)
    {
        var entities = await _TrailerRepository.GetAllAsync();
        return entities.Select(Trailer => new TrailerDto
        (
            idtrailer: Trailer.idtrailer,
            descripcion: Trailer.descripcion,
            serial: Trailer.serial


        ));
    }
}
