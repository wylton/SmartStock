using SmartMvc.Domain.Entities.Specifications.InvoiceSpecs;
using SmartMvc.Domain.Validation;

namespace SmartMvc.Domain.Entities.Validations
{
    public class InvoiceIsValidValidation : Validation<Invoice>
    {
        public InvoiceIsValidValidation()
        {
            base.AddRule(new ValidationRule<Invoice>(new InvoiceKeyNfIsRequiredSpec(), ValidationMessages.InvoiceKeyNfIsRequired));
            base.AddRule(new ValidationRule<Invoice>(new InvoiceFilialIsRequiredSpec(), ValidationMessages.InvoiceFilialIsRequired));
            base.AddRule(new ValidationRule<Invoice>(new InvoiceNumberIsRequiredSpec(), ValidationMessages.InvoiceNumberIsRequired));
            base.AddRule(new ValidationRule<Invoice>(new InvoiceNumberSerieIsRequiredSpec(), ValidationMessages.InvoiceNumberSerieIsRequired));
            base.AddRule(new ValidationRule<Invoice>(new InvoiceEmissionIsRequiredSpec(), ValidationMessages.InvoiceEmissionIsRequired));
            base.AddRule(new ValidationRule<Invoice>(new InvoiceQuantityIsRequiredSpec(), ValidationMessages.InvoiceQuantityIsRequired));
            base.AddRule(new ValidationRule<Invoice>(new InvoiceVolumeIsRequiredSpec(), ValidationMessages.InvoiceVolumeIsRequired));
            base.AddRule(new ValidationRule<Invoice>(new InvoiceTypeIsRequiredSpec(), ValidationMessages.InvoiceTypeIsRequired));
        }
    }
}

