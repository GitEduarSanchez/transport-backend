using Poliedro.Billing.Domain.Producto.Entities;
using Poliedro.Billing.Domain.Producto.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Producto.Adapter;

public class ProductoRepository(DataBaseContext context) : IProductoRepository
{
    public async Task<bool> SaveAsync(ProductoEntity producto)
    {
        await context.Producto.AddAsync(producto);
        return  await context.SaveChangesAsync() > 0;
    }
}
