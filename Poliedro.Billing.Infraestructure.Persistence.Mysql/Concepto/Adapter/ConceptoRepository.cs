using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.Concepto.Entities;
using Poliedro.Billing.Domain.Concepto.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Concepto.Adapter;

public class ConceptoRepository(DataBaseContext _context) : IConceptoRepository
{
    public Task<IEnumerable<ConceptoEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ConceptoEntity> GetById(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> SaveAsync(ConceptoEntity concepto)
    {
        throw new NotImplementedException();
    }
}
