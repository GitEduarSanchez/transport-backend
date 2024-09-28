using MediatR;
using Poliedro.Billing.Application.Conductor.Commands.CreateServerCommand;
using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Conductor.Ports;

namespace Poliedro.Billing.Application.Descargue.Handle;

public class DescargueHandle(IDescargueRepository _descargueRepository) : IRequestHandler<CreateDescargueCommand, bool>
{
    public async Task<bool> Handle(CreateDescargueCommand request, CancellationToken cancellationToken)
    {
        DescargueEntity descargue = new() { Name = request.Name };
        return await _DescargueRepository.SaveAsync(descargue);
    }
}
