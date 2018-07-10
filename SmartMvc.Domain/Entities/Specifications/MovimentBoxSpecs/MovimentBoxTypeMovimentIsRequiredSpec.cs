using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.MovimentBoxSpecs
{
    public class MovimentBoxTypeMovimentIsRequiredSpec : ISpecification<MovimentBox>
    {
        public bool IsSatisfiedBy(MovimentBox movimentBox)
        {
            return movimentBox.TypeMoviment.Length > 0;
        }
    }
}
