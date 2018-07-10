using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.InvoiceSpecs
{
    public class InvoiceNumberSerieIsRequiredSpec : ISpecification<Invoice>
    {
        public bool IsSatisfiedBy(Invoice invoice)
        {
            return invoice.NumberSerieInvoice.Length > 0;
        }
    }
}
