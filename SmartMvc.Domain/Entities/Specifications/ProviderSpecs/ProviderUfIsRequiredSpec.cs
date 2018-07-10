using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.ProviderSpecs
{
    class ProviderUfIsRequiredSpec : ISpecification<Provider>
    {
        public bool IsSatisfiedBy(Provider provider)
        {
            return provider.Uf.Length > 0;
        }
    }
}
