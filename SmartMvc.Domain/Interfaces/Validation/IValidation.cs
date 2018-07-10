using SmartMvc.Domain.Validation;

namespace SmartMvc.Domain.Interfaces.Validation
{
    public interface IValidation<in TEntity>
    {
        ValidationResult Valid(TEntity entity);
    }
}