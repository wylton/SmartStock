using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.InvoiceSpecs
{
    public class InvoiceKeyNfIsRequiredSpec : ISpecification<Invoice>
    {
        public bool IsSatisfiedBy(Invoice invoice)
        {
            return invoice.KeyNf.Length > 0;
        }
    }
}
