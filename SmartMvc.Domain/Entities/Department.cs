using SmartMvc.Domain.Entities.Validations;
using SmartMvc.Domain.Interfaces.Validation;
using SmartMvc.Domain.Validation;

namespace SmartMvc.Domain.Entities
{
    public class Department : ISelfValidation
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public ValidationResult ValidationResult { get; private set; }

        public bool IsValid
        {
            get
            {
                var fiscal = new DepartmentIsValidValidation();
                ValidationResult = fiscal.Valid(this);
                return ValidationResult.IsValid;

            }
        }
    }
}
