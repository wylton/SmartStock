using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.ProviderSpecs
{
    public class ProviderNameContactIsRequiredSpec : ISpecification<Provider>
    {
        public bool IsSatisfiedBy(Provider provider)
        {
            return provider.NameContact.Length > 0;
        }
    }
}
