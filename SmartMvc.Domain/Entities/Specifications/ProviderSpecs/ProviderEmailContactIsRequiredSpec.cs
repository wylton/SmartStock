using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.ProviderSpecs
{
    class ProviderEmailContactIsRequiredSpec : ISpecification<Provider>
    {
        public bool IsSatisfiedBy(Provider provider)
        {
            return provider.EmailContact.Length > 0;
        }
    }
}
