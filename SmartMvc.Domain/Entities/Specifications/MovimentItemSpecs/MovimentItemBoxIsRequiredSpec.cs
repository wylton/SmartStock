using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.MovimentItemSpecs
{
    public class MovimentItemBoxIsRequiredSpec : ISpecification<MovimentItem>
    {
        public bool IsSatisfiedBy(MovimentItem movimentItem)
        {
            return movimentItem.MovimentBox != null;
        }
    }
}
