namespace Poliedro.Billing.Domain.Server.Entities;

public class ServerEntity
{
    public int ServerId { get; set; } = default!;
    public string Ip { get; set; } = default!;
    public string DatabaseName { get; set; } = default!;
    public string DbUsername { get; set; } = default!;
    public string DbPassword { get; set; } = default!;
    public DateTime CreationDate { get; set; } = default!;
}
