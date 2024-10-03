using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.TipoVehiculo.Entities;

public class TipoVehiculoEntity
{
    [Key]
    public int idtipovehiculo { get; set; }
    public string descripcion { get; set; }
}
