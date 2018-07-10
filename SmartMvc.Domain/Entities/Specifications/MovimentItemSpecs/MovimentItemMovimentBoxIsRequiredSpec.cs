using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.MovimentItemSpecs
{
    public class MovimentItemMovimentBoxIsRequiredSpec : ISpecification<MovimentItem>
    {
        public bool IsSatisfiedBy(MovimentItem movimentItem)
        {
            return movimentItem.Box != null;
        }
    }
}
