using SmartMvc.Domain.Entities.Validations;
using SmartMvc.Domain.Interfaces.Validation;
using SmartMvc.Domain.Validation;
using System;

namespace SmartMvc.Domain.Entities
{
    public class User : ISelfValidation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateCreate { get; set; }
        public bool IsAdmin { get; set; }

        public ValidationResult ValidationResult { get; private set; }

        public bool IsValid
        {
            get
            {
                var fiscal = new UserIsValidValidation();
                ValidationResult = fiscal.Valid(this);
                return ValidationResult.IsValid;

            }
        }
    }
}
