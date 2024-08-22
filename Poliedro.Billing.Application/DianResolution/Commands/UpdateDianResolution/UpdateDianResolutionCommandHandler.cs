using AutoMapper;
using MediatR;
using Poliedro.Billing.Application.Resolution.Dtos;
using Poliedro.Billing.Domain.Resolution.DomainService;
using Poliedro.Billing.Domain.Resolution.Entities;

namespace Poliedro.Billing.Application.DianResolution.Commands.CreateDianResolution
{
    public class UpdateDianResolutionCommandHandler(
        IDianResolutionDomainService dianResolutionDomainService,
        IMapper mapper) : IRequestHandler<UpdateDianResolutionCommand, DianResolutionDto>
    {
        public async Task<DianResolutionDto> Handle(UpdateDianResolutionCommand request, CancellationToken cancellationToken)
        {
            var existingEntity = await dianResolutionDomainService.GetById(request.id, cancellationToken);
            if (existingEntity == null)
            {
                return null;
            }

            var properties = typeof(UpdateDianResolutionCommand).GetProperties();
            foreach (var property in properties)
            {
                var value = property.GetValue(request);
                if (value != null && !IsDefaultValue(value, property.PropertyType))
                {
                    var entityProperty = typeof(DianResolutionEntity).GetProperty(property.Name);
                    if (entityProperty != null)
                    {
                        entityProperty.SetValue(existingEntity, value);
                    }
                }
            }

            var response = await dianResolutionDomainService.Update(existingEntity, cancellationToken);
            var dianResolutionDto = mapper.Map<DianResolutionDto>(response);
            return dianResolutionDto;
        }

        private bool IsDefaultValue(object value, Type type)
        {
            if (value == null) return true;
            if (type.IsValueType) return Activator.CreateInstance(type).Equals(value);
            return false;
        }
    }
}
