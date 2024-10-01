using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.ViajeOrigen.Entities;

public class ViajeOrigenEntity
{
    [Key]
    public int idControlViajeOrigen { get; set; }
    public int idControlViaje { get; set; }
    public int idOrigen { get; set; }
    public int idCiudad { get; set; }
}
