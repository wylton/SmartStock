using SmartMvc.Domain.Validation;

namespace SmartMvc.Application.Interfaces.Common
{
    public interface IWriteOnlyAppService<in TEntity>
    where TEntity : class
    {
        ValidationResult Create(TEntity orderDetail);
        ValidationResult Update(TEntity orderDetail);
        ValidationResult Remove(TEntity orderDetail);
    }

}