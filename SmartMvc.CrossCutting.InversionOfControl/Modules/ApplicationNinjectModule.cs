using SmartMvc.Application;
using SmartMvc.Application.Interfaces;
using Ninject.Modules;

namespace SmartMvc.CrossCutting.InversionOfControl.Modules
{
    public class ApplicationNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBoxAppService>().To<BoxAppService>();
            Bind<IMovimentBoxAppService>().To<MovimentBoxAppService>();
            Bind<IMovimentItemAppService>().To<MovimentItemAppService>();
            Bind<IDepartmentAppService>().To<DepartmentAppService>();
            Bind<IInvoiceAppService>().To<InvoiceAppService>();
            Bind<IUserAppService>().To<UserAppService>();
        }
    }
}
