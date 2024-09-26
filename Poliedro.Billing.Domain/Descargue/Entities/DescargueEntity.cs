using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.Conductor.Entities;

public class DescargueEntity
{
    [Key]
    public int Id { get; set; }
    public required string descriocion { get; set; }

}
