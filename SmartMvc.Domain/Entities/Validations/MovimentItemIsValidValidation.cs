using SmartMvc.Domain.Entities.Specifications.MovimentItemSpecs;
using SmartMvc.Domain.Validation;

namespace SmartMvc.Domain.Entities.Validations
{
    public class MovimentItemIsValidValidation : Validation<MovimentItem>
    {
        public MovimentItemIsValidValidation()
        {
            base.AddRule(new ValidationRule<MovimentItem>(new MovimentItemMovimentBoxIsRequiredSpec(), ValidationMessages.MovimentBoxTypeMoviment));
            base.AddRule(new ValidationRule<MovimentItem>(new MovimentItemBoxIsRequiredSpec(), ValidationMessages.MovimentBoxDateInitial));
        }
    }
}
