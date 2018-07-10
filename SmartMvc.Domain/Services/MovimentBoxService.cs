using SmartMvc.Domain.Entities;
using SmartMvc.Domain.Interfaces.Repository;
using SmartMvc.Domain.Interfaces.Repository.ReadOnly;
using SmartMvc.Domain.Interfaces.Service;
using SmartMvc.Domain.Services.Common;

namespace SmartMvc.Domain.Services
{
    public class MovimentBoxService : Service<MovimentBox>, IMovimentBoxService
    {
        public MovimentBoxService(IMovimentBoxRepository repository, IMovimentBoxReadOnlyRepository readOnlyRepository)
            : base(repository, readOnlyRepository)
        {
        }
    }
}
