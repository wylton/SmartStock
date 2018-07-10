using SmartMvc.Domain.Entities;
using SmartMvc.Domain.Interfaces.Repository.Common;

namespace SmartMvc.Domain.Interfaces.Repository.ReadOnly
{
    public interface IUserReadOnlyRepository : IReadOnlyRepository<User>
    {
    }
}
