using Newtonsoft.Json;
using SmartMvc.Domain.Entities.Validations;
using SmartMvc.Domain.Interfaces.Validation;
using SmartMvc.Domain.Validation;
using System;
using System.Collections.Generic;

namespace SmartMvc.Domain.Entities
{
    public class Invoice : ISelfValidation
    {
        public int Id { get; set; }
        public string KeyNf { get; set; }
        public string Filial { get; set; }
        public string NumberInvoice { get; set; }
        public string NumberSerieInvoice { get; set; }
        public DateTime Emission { get; set; }
        public int Quantity { get; set; }
        public int Volume { get; set; }
        public string Type { get; set; }

        public virtual ICollection<MovimentBox> MovimentBoxes { get; set; }

        [JsonIgnore]
        public ValidationResult ValidationResult { get; private set; }

        public bool IsValid
        {
            get
            {
                var fiscal = new InvoiceIsValidValidation();
                ValidationResult = fiscal.Valid(this);
                return ValidationResult.IsValid;

            }
        }
    }
}
