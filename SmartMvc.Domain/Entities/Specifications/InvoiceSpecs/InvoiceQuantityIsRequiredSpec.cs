using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.InvoiceSpecs
{
    public class InvoiceQuantityIsRequiredSpec : ISpecification<Invoice>
    {
        public bool IsSatisfiedBy(Invoice invoice)
        {
            return invoice.Quantity > 0;
        }
    }
}
