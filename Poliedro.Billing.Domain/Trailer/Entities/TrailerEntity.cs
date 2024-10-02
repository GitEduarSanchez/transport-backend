using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.Trailer.Entities;

public class TrailerEntity
{
    [Key]
    public int idtrailer { get; set; }
    public string descripcion { get; set; }
    public string serial {get; set; }
}