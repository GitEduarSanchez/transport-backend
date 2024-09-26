using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.Conductor.Entities;

public class ConceptoEntity
{
    [Key]
    public int IdConcepto { get; set; }
    public string Descripcion { get; set; }
}
