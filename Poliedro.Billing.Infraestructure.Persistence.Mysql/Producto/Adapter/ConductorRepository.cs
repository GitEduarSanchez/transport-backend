using Poliedro.Billing.Domain.Producto.Entities;
using Poliedro.Billing.Domain.Producto.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Producto.Adapter;

public class CProductoRepository(DataBaseContext context) : IProductoRepository
{
    public async Task<bool> SaveAsync(ProductoEntity Producto)
    {
        await context.Producto.AddAsync(Producto);
        return  await context.SaveChangesAsync() > 0;
    }
}
