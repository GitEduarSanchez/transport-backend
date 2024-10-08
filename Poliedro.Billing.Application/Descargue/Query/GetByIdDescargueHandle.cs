using MediatR;
using Poliedro.Billing.Application.Descargue.Dto;
using Poliedro.Billing.Domain.Descargue.Ports;

namespace Poliedro.Billing.Application.Descargue.Query;

public class GetByIdDescargueHandle(IDescargueRepository DescargueRepository) : IRequestHandler<GetByIdDescargueQuery, DescargueDto>
{
    public async Task<DescargueDto> Handle(GetByIdDescargueQuery request, CancellationToken cancellationToken)
    {
        var getByIdDescargue = await DescargueRepository.GetById(request.iddescargue);
        return new DescargueDto(Id: getByIdDescargue.Id, descriocion: getByIdDescargue.descriocion);
    }
}
