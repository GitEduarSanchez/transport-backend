using Poliedro.Billing.Domain.Trailer.Entities;

namespace Poliedro.Billing.Domain.Trailer.Ports;

public interface ITrailerRepository
{
    Task<bool> SaveAsync(TrailerEntity Trailer);
}
