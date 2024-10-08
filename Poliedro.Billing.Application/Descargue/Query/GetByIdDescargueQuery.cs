using MediatR;
using Poliedro.Billing.Application.Descargue.Dto;

namespace Poliedro.Billing.Application.Descargue.Query;

public record GetByIdDescargueQuery(int Id) : IRequest<DescargueDto>
{
    internal object iddescargue;
}


