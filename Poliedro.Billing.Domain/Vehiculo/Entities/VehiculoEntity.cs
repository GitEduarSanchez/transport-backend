using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.Vehiculo.Entities;

public class VehiculoEntity
{
    [Key]
    public int Id { get; set; }
    public string placa { get; set; }
    public int idmarca { get; set; }
    public int idtipodevehiculo { get; set; }
}
