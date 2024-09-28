using Poliedro.Billing.Domain.Ciudad.Ports;
using Poliedro.Billing.Domain.Ciudad.Entities;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Ciudad.Adapter;

public class CiudadRepository(DataBaseContext context) : ICiudadRepository
{

    public async Task<bool> SaveAsync(CiudadEntity Ciudad)
    {
          await context.Ciudad.AddAsync(Ciudad);
        return  await context.SaveChangesAsync() > 0;
    }
}
