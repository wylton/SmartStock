using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.MovimentBoxSpecs
{
    public class MovimentBoxInvoiceIsRequiredSpec : ISpecification<MovimentBox>
    {
        public bool IsSatisfiedBy(MovimentBox movimentBox)
        {
            return movimentBox.Invoice != null;
        }
    }
}
