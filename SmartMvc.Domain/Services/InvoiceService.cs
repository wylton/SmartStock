using SmartMvc.Domain.Entities;
using SmartMvc.Domain.Interfaces.Repository;
using SmartMvc.Domain.Interfaces.Repository.ReadOnly;
using SmartMvc.Domain.Interfaces.Service;
using SmartMvc.Domain.Services.Common;

namespace SmartMvc.Domain.Services
{
    public class InvoiceService : Service<Invoice>, IInvoiceService
    {
        public InvoiceService(IInvoiceRepository repository, IInvoiceReadOnlyRepository readOnlyRepository)
            : base(repository, readOnlyRepository)
        {
        }
    }
}
