using Newtonsoft.Json;
using SmartMvc.Domain.Entities.Validations;
using SmartMvc.Domain.Interfaces.Validation;
using SmartMvc.Domain.Validation;
using System;
using System.Collections.Generic;

namespace SmartMvc.Domain.Entities
{
    public class MovimentBox : ISelfValidation
    {
        public int Id { get; set; }
        public string TypeMoviment { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime? FinalDate { get; set; }

        public Invoice Invoice { get; set; }

        public virtual ICollection<MovimentItem> MovimentItems { get; set; }

        [JsonIgnore]
        public ValidationResult ValidationResult { get; private set; }

        public bool IsValid
        {
            get
            {
                var fiscal = new MovimentBoxIsValidValidation();
                ValidationResult = fiscal.Valid(this);
                return ValidationResult.IsValid;

            }
        }
    }
}
