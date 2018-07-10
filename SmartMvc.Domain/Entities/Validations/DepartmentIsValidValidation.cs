using SmartMvc.Domain.Entities.Specifications.DepartmentSpecs;
using SmartMvc.Domain.Validation;

namespace SmartMvc.Domain.Entities.Validations
{
    public class DepartmentIsValidValidation : Validation<Department>
    {
        public DepartmentIsValidValidation()
        {
            base.AddRule(new ValidationRule<Department>(new DepartmentNameIsRequiredSpec(), ValidationMessages.DepartmentName));
        }
    }
}
