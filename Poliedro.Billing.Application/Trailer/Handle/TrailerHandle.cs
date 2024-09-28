using MediatR;
using Poliedro.Billing.Application.Trailer.Commands.CreateServerCommand;
using Poliedro.Billing.Domain.Trailer.Entities;
using Poliedro.Billing.Domain.Trailer.Ports;

namespace Poliedro.Billing.Application.Trailer.Handle;

public class ConductorHandle(ITrailerRepository _TrailerRepository) : IRequestHandler<CreateTrailerCommand, bool>
{
    public async Task<bool> Handle(CreateTrailerCommand request, CancellationToken cancellationToken)
    {
        TrailerEntity Trailer = new() { idTrailer = request.idTrailer };
        return await _TrailerRepository.SaveAsync(Trailer);
    }
}
