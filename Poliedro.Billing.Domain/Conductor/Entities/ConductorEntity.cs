using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.Conductor.Entities;

public class ConductorEntity
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
