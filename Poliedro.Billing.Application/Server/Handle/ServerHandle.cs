using AutoMapper;
using MediatR;
using Poliedro.Billing.Application.Server.Commands.CreateServerCommand;
using Poliedro.Billing.Domain.Server.Entities;
using Poliedro.Billing.Domain.Server.Ports;

namespace Poliedro.Billing.Application.Server.Handle;
public class ServerHandle(IServerRepository serverRepository, IMapper mapper) : IRequestHandler<CreateServerCommand, bool>
{
    async Task<bool> IRequestHandler<CreateServerCommand, bool>.Handle(CreateServerCommand request, CancellationToken cancellationToken)
    {
      
        var server = mapper.Map<ServerEntity>(request);
        await serverRepository.SaveAsync(server);
        return true;
    }
}

