using SmartMvc.Domain.Interfaces.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMvc.Domain.Entities
{
    public class Provider : ISelfValidation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Uf { get; set; }
        public string EmailContact { get; set; }
        public string NameContact { get; set; }

        public ValidationResult ValidationResult { get; private set; }

        public bool IsValid
        {
            get
            {
                var fiscal = new ProviderIsValidValidation();
                ValidationResult = fiscal.Valid(this);
                return ValidationResult.IsValid;

            }
        }
    }
}
