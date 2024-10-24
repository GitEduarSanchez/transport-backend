using Poliedro.Billing.Domain.Producto.Entities;
using Poliedro.Billing.Domain.Producto.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;
using Microsoft.EntityFrameworkCore;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Producto.Adapter;

public class ProductoRepository(DataBaseContext _context) : IProductoRepository
{
    public Task<IEnumerable<ProductoEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ProductoEntity> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> SaveAsync(ProductoEntity producto)
    {
        throw new NotImplementedException();
    }
}
