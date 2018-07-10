using SmartMvc.Domain.Validation;

namespace SmartMvc.Domain.Interfaces.Validation
{
    public interface ISelfValidation
    {
        ValidationResult ValidationResult { get; }
        bool IsValid { get; }
    }
}