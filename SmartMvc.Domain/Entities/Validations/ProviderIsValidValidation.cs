using SmartMvc.Domain.Entities.Specifications.ProviderSpecs;
using SmartMvc.Domain.Validation;

namespace SmartMvc.Domain.Entities.Validations
{
    public class ProviderIsValidValidation : Validation<Provider>
    {
        public ProviderIsValidValidation()
        {
            base.AddRule(new ValidationRule<Provider>(new ProviderNameIsRequiredSpec(), ValidationMessages.ProviderNameIsRequired));
            base.AddRule(new ValidationRule<Provider>(new ProviderCnpjIsRequiredSpec(), ValidationMessages.ProviderCnpjIsRequired));
            base.AddRule(new ValidationRule<Provider>(new ProviderUfIsRequiredSpec(), ValidationMessages.ProviderUfIsRequired));
            base.AddRule(new ValidationRule<Provider>(new ProviderEmailContactIsRequiredSpec(), ValidationMessages.ProviderEmailContactIsRequired));
            base.AddRule(new ValidationRule<Provider>(new ProviderNameContactIsRequiredSpec(), ValidationMessages.ProviderNameContactIsRequired));
        }
    }
}
