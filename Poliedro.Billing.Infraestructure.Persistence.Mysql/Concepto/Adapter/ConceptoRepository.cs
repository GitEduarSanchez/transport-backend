using Poliedro.Billing.Domain.Concepto.Entities;
using Poliedro.Billing.Domain.Concepto.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Concepto.Adapter;

public class ConceptoRepository(DataBaseContext context) : IConceptoRepository
{
    public async Task<bool> SaveAsync(ConceptoEntity Concepto)
    {
        await context.Concepto.AddAsync(Concepto);
        return  await context.SaveChangesAsync() > 0;
    }
}
