using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.Conductor.Entities;

public class TrailerEntity
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
