using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.ProviderSpecs
{
    public class ProviderNameIsRequiredSpec : ISpecification<Provider>
    {
        public bool IsSatisfiedBy(Provider provider)
        {
            return provider.Name.Length > 0;
        }
    }
}
