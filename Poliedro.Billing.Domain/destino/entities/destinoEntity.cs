using System.ComponentModel.DataAnnotations;

namespace Poliedro.Billing.Domain.Destino.Entities;

public class DestinoEntity
{
    [Key]
    public int idDestino { get; set; }
    public string Descripcion { get; set; }
}
