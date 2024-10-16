using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.Origen.Entities;

public class OrigenEntity
{
    [Key]
    public int IdOrigen { get; set; }
    public string descripcion { get; set; }
}
