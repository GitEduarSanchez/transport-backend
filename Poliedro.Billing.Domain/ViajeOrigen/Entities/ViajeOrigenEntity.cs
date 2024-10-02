using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.ViajeOrigen.Entities;

public class ViajeOrigenEntity
{
    [Key]
    public int Id{ get; set; }
    public int IdControlViaje{ get; set; }
    public int IdOrigen {get;set;}
    public int IdCiudad{get;set;}
}
