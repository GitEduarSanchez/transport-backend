using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.Conductor.Entities;

public class DestinoEntity
{
    [Key]
    public int IdDestino { get; set; }
    public required string Descripcion { get; set; }
}
