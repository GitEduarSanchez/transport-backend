using Poliedro.Billing.Domain.Trailer.Entities;

namespace Poliedro.Billing.Domain.Trailer.Ports;

public interface ITrailerRepository
{
    Task<bool> SaveAsync(TrailerEntity Trailer);
    Task<IEnumerable<TrailerEntity>> GetAllAsync();
    Task<TrailerEntity> GetById(int Id);
}
