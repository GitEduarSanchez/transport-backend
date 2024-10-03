namespace Poliedro.Billing.Application.Descargue.Dto;

public record DescargueDto(int iddescargue, string descriocion, object Id)
{
    private object descriocion1;

    public DescargueDto(object Id, object descriocion)
    {
        this.Id = Id;
        descriocion1 = descriocion;
    }
}

