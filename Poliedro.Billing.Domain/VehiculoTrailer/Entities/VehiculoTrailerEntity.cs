using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.VehiculoTrailer.Entities;

public class VehiculoTrailerEntity
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
