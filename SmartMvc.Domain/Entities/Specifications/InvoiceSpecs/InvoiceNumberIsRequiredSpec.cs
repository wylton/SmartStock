using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.InvoiceSpecs
{
    public class InvoiceNumberIsRequiredSpec : ISpecification<Invoice>
    {
        public bool IsSatisfiedBy(Invoice invoice)
        {
            return invoice.NumberInvoice.Length > 0;
        }
    }
}
