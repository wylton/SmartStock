using SmartMvc.Domain.Entities.Specifications.MovimentBoxSpecs;
using SmartMvc.Domain.Validation;

namespace SmartMvc.Domain.Entities.Validations
{
    public class MovimentBoxIsValidValidation : Validation<MovimentBox>
    {
        public MovimentBoxIsValidValidation()
        {
            base.AddRule(new ValidationRule<MovimentBox>(new MovimentBoxTypeMovimentIsRequiredSpec(), ValidationMessages.MovimentBoxTypeMoviment));
            base.AddRule(new ValidationRule<MovimentBox>(new MovimentBoxDateInitialIsRequiredSpec(), ValidationMessages.MovimentBoxDateInitial));
            base.AddRule(new ValidationRule<MovimentBox>(new MovimentBoxInvoiceIsRequiredSpec(), ValidationMessages.MovimentBoxInvoice));
        }
    }
}
