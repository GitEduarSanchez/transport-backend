using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.CategoriaDocumento.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class CategoriaDocumentoConfiguration
{
    public CategoriaDocumentoConfiguration(EntityTypeBuilder<CategoriaDocumentoEntity> builder)
    {
        builder.ToTable("categoria_documento");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("idcategoria_documento");
        builder.Property(x => x.Descripcion).HasColumnName("descripcion");
    }
}
