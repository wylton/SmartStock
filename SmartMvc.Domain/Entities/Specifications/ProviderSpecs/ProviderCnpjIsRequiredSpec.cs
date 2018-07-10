using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.ProviderSpecs
{
    public class ProviderCnpjIsRequiredSpec : ISpecification<Provider>
    {
        public bool IsSatisfiedBy(Provider provider)
        {
            return provider.Cnpj.Length > 0;
        }
    }
}
