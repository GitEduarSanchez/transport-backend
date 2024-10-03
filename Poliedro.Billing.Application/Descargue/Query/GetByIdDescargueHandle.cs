using MediatR;
using Poliedro.Billing.Application.Descargue.Dto;
using Poliedro.Billing.Domain.Descargue.Ports;

namespace Poliedro.Billing.Application.Descargue.Query;

public class GetByIdDescargueHandle(IDescargueRepository descargueRepository) : IRequestHandler<GetByIdDescargueQuery, DescargueDto>
{
    public async Task<DescargueDto> Handle(GetByIdDescargueQuery request, CancellationToken cancellationToken)
    {
        var getByIdDescargue = await descargueRepository.GetById(request.IdDescargue);
        return new DescargueDto(iddescargue: getByIdDescargue.iddescargue, descriocion: getByIdDescargue.descriocion);
    }
}
