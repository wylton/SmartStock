using SmartMvc.Data.Context.Interfaces;

namespace SmartMvc.Application.Interfaces.Common
{
    public interface ITransactionAppService<TContext>
        where TContext : IDbContext, new()
    {
        void BeginTransaction();
        void Commit();
    }
}
