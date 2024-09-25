using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.Conductor.Entities;

public class ControlViajeProductoEntity
{
    [Key]
    public int Id { get; set; }
    public int idControlViaje { get; set; }

    public int idProducto { get; set; } 

    
}
