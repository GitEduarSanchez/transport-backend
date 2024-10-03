using MediatR;
using Poliedro.Billing.Application.Conductor.Query;
using Poliedro.Billing.Application.Trailer.Dto;
using Poliedro.Billing.Domain.Trailer.Ports;

namespace Poliedro.Billing.Application.Trailer.Query;

public class GetByIdTrailerHandle(ITrailerRepository trailerRepository) : IRequestHandler<GetByIdTrailerQuery, TrailerDto>
{
    public async Task<TrailerDto> Handle(GetByIdTrailerQuery request, CancellationToken cancellationToken)
    {
        var getByIdTrailer = await trailerRepository.GetById(request.Id);
        return new TrailerDto(idtrailer: getByIdTrailer.idTrailer, Descripcion: getByIdTrailer.Descripcion , serial:getByIdTrailer.serial);
    }
}
