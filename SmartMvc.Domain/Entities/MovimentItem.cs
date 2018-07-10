using SmartMvc.Domain.Entities.Validations;
using SmartMvc.Domain.Interfaces.Validation;
using SmartMvc.Domain.Validation;

namespace SmartMvc.Domain.Entities
{
    public class MovimentItem : ISelfValidation
    {
        public int Id { get; set; }
        public Box Box { get; set; }
        public MovimentBox MovimentBox { get; set; }

        public ValidationResult ValidationResult { get; private set; }

        public bool IsValid
        {
            get
            {
                var fiscal = new MovimentItemIsValidValidation();
                ValidationResult = fiscal.Valid(this);
                return ValidationResult.IsValid;

            }
        }
    }
}
