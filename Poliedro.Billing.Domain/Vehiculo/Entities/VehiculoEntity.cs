using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.Conductor.Entities;

public class VehiculoEntity
{
    

    [Key]
    public int Id { get; set; }
    public string placa { get; set; }
    public string idmarca { get; set; }
    public string idtipovehiculo { get; set; }
}
