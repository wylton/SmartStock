using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.MovimentBoxSpecs
{
    public class MovimentBoxDateInitialIsRequiredSpec : ISpecification<MovimentBox>
    {
        public bool IsSatisfiedBy(MovimentBox movimentBox)
        {
            return movimentBox.InitialDate.Day > 0;
        }
    }
}
