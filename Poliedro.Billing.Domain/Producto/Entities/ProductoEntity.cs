using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.Producto.Entities;

public class ProductoEntity
{
    [Key]
    public int idProducto { get; set; }
    public string descripcion { get; set; }

    public int UnidadMedida { get; set; }
}
