using SmartMvc.Domain.Entities.Specifications.BoxSpecs;
using SmartMvc.Domain.Validation;

namespace SmartMvc.Domain.Entities.Validations
{
    public class BoxIsValidValidation : Validation<Box>
    {
        public BoxIsValidValidation()
        {
            base.AddRule(new ValidationRule<Box>(new BoxDatePrinterIsRequiredSpec(), ValidationMessages.BoxDatePrinter));
        }
    }
}
