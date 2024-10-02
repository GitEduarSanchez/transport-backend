using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.Producto.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class ProductoConfiguration
{
    public ProductoConfiguration(EntityTypeBuilder<ProductoEntity> builder)
    {
        builder.ToTable("producto");
        builder.HasKey(x => x.idProducto);
        builder.Property(x => x.idProducto).HasColumnName("idproducto");
        builder.Property(x => x.descripcion).HasColumnName("descripcion");
        builder.Property(x => x.UnidadMedida).HasColumnName("idunidad_medida");
    }
}
