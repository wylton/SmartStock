using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.InvoiceSpecs
{
    public class InvoiceTypeIsRequiredSpec : ISpecification<Invoice>
    {
        public bool IsSatisfiedBy(Invoice invoice)
        {
            return invoice.Type.Length > 0;
        }
    }
}
