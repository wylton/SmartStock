using SmartMvc.Domain.Entities;
using SmartMvc.Domain.Interfaces.Repository;
using SmartMvc.Domain.Interfaces.Repository.ReadOnly;
using SmartMvc.Domain.Interfaces.Service;
using SmartMvc.Domain.Services.Common;

namespace SmartMvc.Domain.Services
{
    public class DepartmentService : Service<Department>, IDepartmentService
    {
        public DepartmentService(IDepartmentRepository repository, IDepartmentReadOnlyRepository readOnlyRepository)
            : base(repository, readOnlyRepository)
        {
        }
    }
}
