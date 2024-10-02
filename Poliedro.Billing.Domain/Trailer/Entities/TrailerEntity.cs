using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.Trailer.Entities;

public class TrailerEntity
{
    [Key]
    public string Descripcion { get; set; }
    public string serial { get; set; }
}
