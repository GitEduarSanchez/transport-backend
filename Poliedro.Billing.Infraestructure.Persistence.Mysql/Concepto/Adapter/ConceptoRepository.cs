using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Conductor.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Conductor.Adapter;

public class ConceptoRepository(DataBaseContext context) : IConceptoRepository
{
    public async Task<bool> SaveAsync(ConceptoEntity concepto)
    {
        await context.Conductor.AddAsync(concepto);
        return  await context.SaveChangesAsync() > 0;
    }
}
