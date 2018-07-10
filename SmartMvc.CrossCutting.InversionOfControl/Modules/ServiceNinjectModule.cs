using SmartMvc.Domain.Interfaces.Service;
using SmartMvc.Domain.Interfaces.Service.Common;
using SmartMvc.Domain.Services;
using SmartMvc.Domain.Services.Common;
using Ninject.Modules;

namespace SmartMvc.CrossCutting.InversionOfControl.Modules
{
    public class ServiceNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof (IService<>)).To(typeof (Service<>));

            Bind<IBoxService>().To<BoxService>();
            Bind<IMovimentBoxService>().To<MovimentBoxService>();
            Bind<IMovimentItemService>().To<MovimentItemService>();
            Bind<IDepartmentService>().To<DepartmentService>();
            Bind<IInvoiceService>().To<InvoiceService>();
            Bind<IUserService>().To<UserService>();
        }
    }
}
