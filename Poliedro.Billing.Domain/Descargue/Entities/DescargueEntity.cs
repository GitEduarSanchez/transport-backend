using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.Descargue.Entities;

public class DescargueEntity
{
    [Key]
    public int Id { get; set; }
    public required string descriocion { get; set; }

}
