using SmartMvc.Domain.Entities.Validations;
using SmartMvc.Domain.Interfaces.Validation;
using SmartMvc.Domain.Validation;
using System;
using System.Collections.Generic;

namespace SmartMvc.Domain.Entities
{
    public class Box : ISelfValidation
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime DatePrinter { get; set; }
        public DateTime? DateChecked { get; set; }

        public virtual ICollection<MovimentItem> MovimentItems { get; set; }

        public ValidationResult ValidationResult { get; private set; }

        public bool IsValid
        {
            get
            {
                var fiscal = new BoxIsValidValidation();
                ValidationResult = fiscal.Valid(this);
                return ValidationResult.IsValid;

            }
        }
    }
}
