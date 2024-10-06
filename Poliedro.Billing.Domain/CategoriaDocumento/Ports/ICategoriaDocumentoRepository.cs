using Poliedro.Billing.Domain.CategoriaDocumento.Entities;

namespace Poliedro.Billing.Domain.CategoriaDocumento.Ports;

public interface ICategoriaDocumentoRepository
{
    Task<bool> SaveAsync(CategoriaDocumentoEntity categoriaDocumento);
    Task<IEnumerable<CategoriaDocumentoEntity>> GetAllAsync();
}
