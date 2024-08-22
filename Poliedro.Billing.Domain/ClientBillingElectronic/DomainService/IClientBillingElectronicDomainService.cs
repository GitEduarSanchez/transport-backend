using Poliedro.Billing.Domain.ClientBillingElectronic.Entities;

namespace Poliedro.Billing.Domain.ClientBillingElectronic.DomainService;

public interface IClientBillingElectronicDomainService
{
    Task<bool> Create(ClientBillingElectronicEntity clientBillingElectronicEntity);
    Task<bool> Update(ClientBillingElectronicEntity clientBillingElectronicEntity);
    Task<IEnumerable<ClientBillingElectronicEntity>> GetAll();
    Task<ClientBillingElectronicEntity> GetById(int id);
    Task<bool> Delete(int id);
}
