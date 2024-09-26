using Poliedro.Billing.Domain.Concepto.Entities;

namespace Poliedro.Billing.Domain.Concepto.Ports;

public interface IConceptoRepository
{
    Task<bool> SaveAsync(ConceptoEntity conductor);
}
